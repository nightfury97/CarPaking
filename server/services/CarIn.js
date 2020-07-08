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
    var sql = require("mssql");
    var config = {
        user: 'sa',
        password: '123456',
        server: 'localhost', 
        database: 'CarParking' 
    };
    sql.connect(config).then(pool => {
        return pool.request()
            // .input('input_parameter', sql.NChar, value)              
            // .query('select * from Cart')
            .query("declare @out1 int exec Checkin @username ="+req.query.name+",@out= @out1 output  select @out1 as id")
    }).then(result => {
        var data = req.query.name+"-"+result.recordset[0].id;
        console.log(data )
        client.publish('checkin',JSON.stringify(data));
        client.on('connect', function () {
            client.publish('checkin',JSON.stringify(data));
            console.log('Message Sent '+data);
        });
        res.status(200).json(result.recordset[0].id);

    }).catch(err => {
        console.log(err)// ... error checks
    })
    // sql.disconnect();
   
  })

export default router;