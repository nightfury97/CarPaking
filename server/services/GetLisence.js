import {Router} from "express";
import multer from 'multer';
import fs from 'fs';
const Express = require('express')
const cors = require('cors')
const bodyParser = require('body-parser')
var mqtt = require('mqtt');
var client  = mqtt.connect('mqtt://192.168.8.100');
const router = Router();
router.get('/', function (req, res) {
    var data = req.query.code;
    var pos = req.query.pos;
    // client.publish('checkin',JSON.stringify(data));
    // client.on('connect', function () {
    //     client.publish('GetLis',JSON.stringify(data));
    //     console.log('Message Sent '+data);
    // });
    // console.log("declare @out1 int exec Checkin @username =("+req.query.name+"),@out= @out1 output  select @out1");

    var sql = require("mssql");
    var config = {
        user: 'sa',
        password: '123456',
        server: 'localhost', 
        database: 'CarParking' 
    };
    sql.connect(config).then(pool => {
    
        // Stored procedure
        console.log("result")
        return pool.request()
            // .input('input_parameter', sql.NChar, value)              
            // .query('select * from Cart')
            .query("SELECT dbo.GetLiscense('"+data+"') as carparking")
    }).then(result => {
        var data = req.query.pos+"-"+result.recordset[0].carparking;
        console.log(data )
        client.publish('CheckLiscense',JSON.stringify(data));
        client.on('connect', function () {
            client.publish('CheckLiscense',JSON.stringify(data));
            console.log('Message Sent '+data);
        });
        res.status(200).json(result.recordset[0].carparking);

    }).catch(err => {
        console.log(err)// ... error checks
    })
    // sql.disconnect();
   
  })

export default router;