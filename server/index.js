import express from "express";
import cors from "cors";
const config = require('./config');
const bodyParser = require('body-parser');
import {Login,CarIn,GetCarParking,GetListParking,GetLisence} from "./services";


global.mqtt = require('./mqtt.js');
mqtt.configure(config);
mqtt.start();

const APP = express();

APP.use([
    bodyParser.json(),
    bodyParser.urlencoded({
        extended: true,
    })
]);

APP.get('/', (req, res) => {
    // res.json({status: true});
    res.status(200).send('My name is Tuan')
});



APP.use("/api/login", Login);
APP.use("/api/CarIn", CarIn);
APP.use("/api/GetCarParking", GetCarParking);
APP.use("/api/GetListParking", GetListParking);
APP.use("/api/GetLisence", GetLisence);
APP.listen(8082, () => {
    console.log('SERVER IS LISTENING AT PORT 8082');
});


