

import React, {Component ,  useRef, useState, useEffect } from 'react';
import {Platform,Dimensions,Alert, StyleSheet,Image,Button,TouchableOpacity, Text, View, width,height,TextInput,AppRegistry,ActivityIndicator,AsyncStorage,DeviceEventEmitter,NativeEventEmitter,NativeModules } from 'react-native';
import QRCode from 'react-native-qrcode-image';
// import FlatList from "./component/BasicFlatList"
import { createAppContainer } from 'react-navigation';
import { createStackNavigator } from 'react-navigation-stack';
// import mq from "./MqttClient";
import MqttService from "./src/core/services/MqttService";
import OfflineNotification from "./src/core/components/OfflineNotification";

class HomeScreen extends React.Component {

  constructor(props){
    super(props);
    this.state={
      photo: null,
      data:[],
      serverIP:"192.168.8.101",
      username:"",
      password:"",
      checkLogin:0,
      statuslogin:""
    }
  }
  _onSubmit=()=>{
    // Alert.alert('http://'+this.state.serverIP+':8082/api/login?username='+this.state.username+'&password='+this.state.password);
    fetch('http://'+this.state.serverIP+':8082/api/login?username='+this.state.username+'&password='+this.state.password, { 
      method: 'GET',
      headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json',
      }
    })
    .then((response) => response.json())
    .then((responseJson) => {
        this.setState({checkLogin:responseJson.success});
        if(this.state.checkLogin>0){
            //console.warn(responseJson);
            this.setState({statuslogin:"Bạn đã đăng nhập thành công!"});
            this.props.navigation.navigate('Doc',{id:this.state.serverIP,username:this.state.username})
        }
        else{
            // console.warn(responseJson);
            this.setState({statuslogin:"Đăng nhập thất bại!"});
        }
    })
    .catch((error) =>{
        console.error(error);
    });
  }
    
  render() {
    return (
      <View style={{ flex: 1, alignItems: 'center', justifyContent: 'center' }}>
        {/* <TextInput style={{ height: 40, borderColor: 'gray', borderWidth: 1 ,width:300}}  placeholder="Input server ip"
        onChangeText={(text) => this.setState({serverIP:text})}
        /> */}
        <Image source={require('./icon.jpg')} style={{ width:350,height:160 }}/>
        <Text>{this.state.statuslogin}</Text>
        <TextInput placeholder="Username"
          placeholderTextColor="black"
          underlineColorAndroid="transparent"
          style={styles.txtInput}  onChangeText={(username) => this.setState({username:username})}/>
        <TextInput placeholder="Password"
            underlineColorAndroid="transparent"
            placeholderTextColor="black"
            secureTextEntry={true}
            style={styles.txtInput}  onChangeText={(password) => this.setState({password:password})}/>
        <TouchableOpacity onPress={this._onSubmit} style={styles.btnLogin}>
            <Text style={styles.txtLogin}>Login</Text>
        </TouchableOpacity>
        <Button
        title="START"
        onPress={() => this.props.navigation.navigate('Doc',{id:this.state.serverIP,username:this.state.username})}
        />
      </View>
    );
  }
}


class TakeDoc extends Component {
  constructor(props){
    super(props);
    this.state={    
    dataSource: null,
    message: '',
    cartContent: '',
    isConnected: false,
    page: "QR",
    serverIP: '192.168.8.101',
    username: this.props.navigation.getParam('username'),
    cartid: 1,
    total: 0
    }
  }
  // componentDidMount() {
  //   MqttService.connectClient(
  //     this.mqttSuccessHandler,
  //     this.mqttConnectionLostHandler
  //   );
  //   EventEmitter.addListener('RCTMoMoNoficationCenterRequestTokenReceived', (response) => {
  //     try{
  //         console.log("<MoMoPay>Listen.Event::" + JSON.stringify(response));
  //           if (response && response.status == 0) {
  //             //SUCCESS: continue to submit momoToken,phonenumber to server
  //             let fromapp = response.fromapp; //ALWAYS:: fromapp==momotransfer
  //             let momoToken = response.data;
  //             let phonenumber = response.phonenumber;
  //             let message = response.message;
  //             let orderId = response.refOrderId;
  //           } else {
  //             //let message = response.message;
  //             //Has Error: show message here
  //           }
  //     }catch(ex){}
  //   });
  //   //OPTIONAL
  //   EventEmitter.addListener('RCTMoMoNoficationCenterRequestTokenState',(response) => {
  //       console.log("<MoMoPay>Listen.RequestTokenState:: " + response.status);
  //       // status = 1: Parameters valid & ready to open MoMo app.
  //       // status = 2: canOpenURL failed for URL MoMo app 
  //       // status = 3: Parameters invalid
  //   })
  // }

  // onWORLD = message => {
  //   var arr =String(message).replace('"','').split("-");
  //       var cus =arr[0];
  //       var cartid =arr[1].replace('"','');
  //   this.setState({
  //     message
  //   });
  //   // alert(cus+"+"+this.state.username);
  //   if(cus==this.state.username){
  //     // MqttService.disconnect();
  //     // this.props.navigation.navigate('Details',{cart:cartid})
  //     this.setState({page:"cart",cartid:cartid});
  //   }
  // };
  // onWORLD2 = message => {
  //   var arr =String(message).replace('"','').split("-");
  //   var Nocart = arr[0];
  //   console.log(Nocart);
  //   console.log(this.state.cartid);

  //   this.setState({
  //     message
  //   });
    
  //   if(String(Nocart)==this.state.cartid){
  //     // alert(Nocart+"-"+this.state.cartContent)
  //     let options = {
  //       headers: {
  //         'Content-Type': 'multipart/form-data'
  //       },
  //       method: 'GET'
  //     };
  //     fetch("http://192.168.43.250:8082/api/getcart?cartID="+Nocart , options)
  //           .then(response => response.json())
  //           .then(response => {
  //             console.log("content", response);
  //             this.setState({cartContent:response})
              
  //           })
  //           .catch(error => {
  //             console.log("upload error", error);
  //         });
  //         this.setState({page:"cart",cartid:Nocart});
  //   }
  //   else{
  //     console.log("cart id "+this.state.cartid+"_"+Nocart);
  //   }
  // };
  // onWORLD3 = message => {
  //   var arr =String(message).replace('"','').split("-");
  //   var Nocart =arr[0];

  //   let options = {
  //     headers: {
  //       'Content-Type': 'multipart/form-data'
  //     },
  //     method: 'GET'
  //   };
  //   fetch("http://192.168.43.250:8082/api/checkout?cartid="+this.state.cartid , options)
  //       .then(response => response.json())
  //       .then(response => {
  //         this.setState({total: parseInt(String(response),10)})
  //         console.log("total ", this.state.total);

  //       })
  //       .then(this.onMomo)
  //       .catch(error => {
  //         console.log("upload error", error);
  //       });
  // };
  // onSuccess = async () => {
    
  //   let options = {
  //     headers: {
  //       'Content-Type': 'multipart/form-data'
  //     },
  //     method: 'GET'
  //   };
  //   fetch("http://192.168.43.250:8082/api/checkout?cartid="+this.state.cartid , options)
  //       .then(response => response.json())
  //       .then(response => {
  //         this.setState({total: parseInt(String(response),10)})
  //         console.log("total ", this.state.total);

  //       })
  //       .then(this.onMomo)
  //       .catch(error => {
  //         console.log("upload error", error);
  //       });
  // }

  

  // mqttSuccessHandler = () => {
  //   this.setState({
  //     isConnected: true
  //   });
  //   console.info("connected to mqtt");
  //   MqttService.subscribe("checkin", this.onWORLD);
  //   MqttService.subscribe("getCart", this.onWORLD2);
  //   MqttService.subscribe("cusCheckout", this.onWORLD3);
    
  // };

  // mqttConnectionLostHandler = () => {
  //   console.info("Fail connect to mqtt");
  //   this.setState({
  //     isConnected: false
  //   });
  // };
  render() {
    const { isConnected, message } = this.state;
    let page;
    let cart;
    if (this.state.page=="QR"){
      return (
        <View  style={{ flex: 1,  alignItems: 'center', justifyContent: 'center' }}>
          <Text style={styles.welcome}>Quét QR mã tại cửa vào</Text>
          <QRCode
              value={this.state.username}
              size={200}
              bgColor='#FFFFFF'
              fgColor='#000000'/>
            {/* <Button
              title={this.state.username}
              onPress={() => this.setState({page:"cart"})}          
              // onPress={() => this.props.navigation.navigate('Details',{cart:12})}          
            /> */}
            {/* <FlatList></FlatList> */}
        </View>
        );
    }
    else
    {
      const { isConnected, message } = this.state;
      let cart;
      if (this.state.cartContent=='') {
        cart = <Text>{this.state.cartid}</Text>;
      } else {
        cart = <FlatList data={this.state.cartContent}></FlatList>;
      }
      return (
        <View style={styles.container}>
          {!isConnected && <OfflineNotification />}
      <Text style={styles.welcome}>cart id  {this.state.cartid }You received message: {message}</Text>
          {cart}
          
          <Button
            onPress={this.onSuccess}
            title="publish"
            color="#841584"
          />
        </View>
        );
    }
  }
}

const DEVICE_WIDTH = Dimensions.get('window').width;
const DEVICE_HEIGHT = Dimensions.get('window').height;

const styles = StyleSheet.create({
  container: {
      flex: 1,
      backgroundColor: 'white',
      alignItems: 'center',
      justifyContent: 'center'
  },

  input: {
      height: 40,
      borderColor: 'gray',
      borderWidth: 1,
      margin: 10,
      borderRadius: 5,
      padding: 5,
  },
  title:{
    fontSize:30,
    color:'red'
  },
  txtInput:{
    backgroundColor: 'rgba(0,0,0, 0.1)',
    width: DEVICE_WIDTH - 40,
      
    marginHorizontal: 20,
    padding:8,
    borderRadius: 20,
    color: '#000',
    marginTop:2
  },
  btnLogin:{
      width: DEVICE_WIDTH - 40,
      backgroundColor:'rgba(0,145,234,1)',
      padding:8,
      borderRadius: 20,
      marginTop:2
  
  },
  txtLogin:{
    color:'#fff',
    textAlign:'center'
  } 
    
});   
const RootStack = createStackNavigator({
  Home: HomeScreen,
  Doc: TakeDoc,
  // Details: DetailsScreen
});

export default createAppContainer(RootStack);
