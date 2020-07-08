var config;
var server;
const mosca = require('mosca');
const fetch = require("node-fetch");
module.exports = {
    configure: function (c) {
        config = c;
    },

    start: function () {
        server = new mosca.Server({
            
            http: config.mqtt.http,
            port: config.mqtt.port,
        });

        server.on('ready', setup);
        server.on('clientConnected', connected);
        server.on('clientDisconnected', disconnected);
        server.on('published', published);
        server.on('subscribed', subscribed);
        server.on('unsubscribed', unsubscribed);
    },

    publish: function (topic, message) {
        var payload = {
            topic: topic,
            payload: message,
            qos: 0,
            retain: false
        };

        server.publish(payload, function () {
            console.log('Published callback complete.');
        });
    }
};

function setup() {
    console.log('Mosca server started.');
}

function connected(client) {
    console.log(`Client ${client.id} connected`);
}

function subscribed(topic, client) {
    console.log(`Client ${client.id} subscribed to ${topic}.`);
}

function unsubscribed(topic, client) {
    console.log(`Client ${client.id} unsubscribed from ${topic}.`);
}

function disconnected(client) {
    console.log(`Client ${client.id}`);
}


function published(packet, client) {
    console.log(`Published to ${packet.topic} <- ${packet.payload}`);
    var sql = require("mssql");
    var config = {
        user: 'sa',
        password: '123456',
        server: "localhost", 
        database: 'CarParking' 
    };
    if(packet.topic=="RFID") {
        var mes = String(packet.payload).replace(" ","");
        var pos = mes.slice(0, 4);
        var rf = mes.slice(5, mes.length);
        console.log(pos+"+"+rf);
        sql.connect(config).then(pool => {
            return pool.request()
                .query("SELECT dbo.GetLiscense('"+rf+"') as lis")
        }).then(result => {
            console.log(result.recordset[0].lis) 
            server.publish({
                topic: 'CheckLiscense',
                payload: result.recordset[0].lis,
                qos: 1 // this is important for offline messaging
              }, null, function done() {})
        }).catch(err => {
            console.log(err)// ... error checks
        })
        // server.publish({
        //     topic: 'CheckLiscense',
        //     payload: lis,
        //     qos: 1 // this is important for offline messaging
        //   }, null, function done() {})
        // sql.connect(config).then(pool => {
        //     console.log("result")
        //     return pool.request()
        //         .query('declare @out1 as nvarchar(max) exec addCart @pos='+pos+',@pro='+pro+',@out= @out1 output select @out1 as cartID')
        // }).then(result => {
        //     console.log(result.recordset[0].cartID) 
        //     server.publish({
        //         topic: 'getCart',
        //         payload: result.recordset[0].cartID,
        //         qos: 1 // this is important for offline messaging
        //       }, null, function done() {})
        // }).catch(err => {
        //     console.log(err)// ... error checks
        // })
    }
    // if(packet.topic=="person/seen") {
    //     var arr =String(packet.payload).split("-");
    //     var cus =arr[0];
    //     var pos =arr[1];
    //     var emo =arr[2];
    //     var emo_arr=["Binh thuong","Vui","Buon","Ngac nhien","Tuc gian"];
    //     var idEmo=emo_arr.indexOf(emo);
    //     console.log(pos+"+"+cus);
    //     var pos_arr = ["A001","A002"];
        
    //     sql.connect(config).then(pool => {        
    //         // Stored procedure
    //         console.log('CusPos  @cusid='+cus+', @pos='+pos_arr[pos]+', @expression='+idEmo)
    //         return pool.request()
    //             // .input('input_parameter', sql.NChar, value)              
    //             // .query(')
    //             .query('CusPos  @cusid='+cus+', @pos='+pos_arr[pos]+', @expression='+idEmo)
    //     }).then(result => {
    //         // var re = JSON.parse(result.recordset)   
    //         console.log("pass")      
    //         console.log(JSON.stringify(result))
    //         server.publish({
    //             topic: 'cusPos',
    //             payload: cus,
    //             qos: 1 // this is important for offline messaging
    //           }, null, function done() {})
    //     }).catch(err => {
    //         // ... error checks
    //     })
    // }
}
