import React, {Component} from 'react';
import { SafeAreaView, View, FlatList, StyleSheet, Text, AppRegistry,ScrollView  } from 'react-native';
import FL from "../data/FLdata";
import { Table, Row, Rows } from 'react-native-table-component';
import Swipeout from 'react-native-swipeout';

class FlatListItem extends Component {

    // render() {
    //     return(
    //         <View style={{flex:1,backgroundColor: this.props.index %2 ==0 ? "green":"red"}}>
    //             <Text>{this.props.item.Name}</Text>
    //         </View>
    //     )
    // }
    render() {
        return(
            <View style={{
                flex: 1,
                flexDirection: 'column'
            }}>
                <View style={{
                flex: 1,
                flexDirection: 'row',
                backgroundColor: 'mediumseagreen'
                }}>
                    <Image
                        source={{uri:this.props.item.imageUrl}}
                        style={{width:100, height:100, margin:5}}
                    >

                    </Image>
                    <View style={{
                        flex: 1,
                        flexDirection: 'column'
                    }}>
                        <Text style={styles.flatListItem}>{this.props.item.DiaDiem}</Text>
                        <Text style={styles.flatListItem}>{this.props.item.TongSoCho}</Text>
                    </View>
                </View>

                <View style={{
                    flex: 1,
                    backgroundColor: 'white',
                    height: 1
                }}>
                </View>
            </View>
        );
    }
}
const swipeSettings = {
    autoClose: true,
    onClose: (secId, rowId, direction) => {
        if(this.state.activeRowKey != null) {
            this.setState({activeRowKey: null});
        }
    },
    onOpen: (sectId, rowId, direction) => {
        this.setState({activeRowKey: this.props.item.key});
    },
    right: [
        {
            onPress: () => {
                const deletingRow = this.state.activeRowKey
                Alert.alert(
                    'Alert',
                    'Are you sure you want to delete?',
                    [
                        {text: 'No', onPress: () => console.log('Cancel pressed'), style: 'cancel'},
                        {text: 'Yes', onPress: () => {
                            flatListData.splice(this.props.index, 1);
                            //Refresh FlatList
                            this.props.parentFlatList.refreshFlatList(deletingRow)
                        }},
                    ],
                    { cancelable: true }
                );
            },
            text: 'Delete', type: 'delete'
        }
    ],
    rowId: this.props.index,
    sectionId: 1
};
const BasicFlatList = ( {data  } ) =>{
    // this.state = { widthArr: [200, 60, 80, 100]}

    const tableData = [];
    console.log(data);
    // console.log(JSON.parse(data).Name);
    JSON.parse(data).map(dataInfo => {
        console.log(dataInfo);
        // dt=JSON.parse(dataInfo)
        console.log("data  "+dataInfo.Name);
        const rowData = [];
        // rowData.push(`${dataInfo.key}`);
        rowData.push(`${dataInfo.Ten}`);
        rowData.push(`${dataInfo.TongSoCho}`);
        rowData.push(`${dataInfo.DaCoXe}`);
        rowData.push(`${dataInfo.DiaDiem}`);
        tableData.push(rowData);
        console.log(rowData)
    })
    // console.log(tableData)
    return (
        <View style={{flex:1,marginTop:22}}>
            {/* <Table borderStyle={{borderWidth: 2, borderColor: '#c8e1ff'}}>
                <Row data={['Tên sản phẩm', 'Đơn giá', 'Số lượng', 'Ghi chú']} widthArr={[200, 60, 80, 100]} style={styles.head} textStyle={styles.text}/>
                
            </Table> */}
            {/* <ScrollView style={styles.dataWrapper}>
                <Table borderStyle={{borderWidth: 1, borderColor: '#C1C0B9'}}>
                    {
                    tableData.map((rowData, index) => (
                        <Row
                            key={index}
                            data={rowData}
                            widthArr={[200, 60, 80, 100]}
                            style={[styles.row, index%2 && {backgroundColor: '#F7F6E7'}]}
                            textStyle={styles.text}
                        />
                    ))
                    }
                </Table>
            </ScrollView> */}
            <FlatList data={JSON.parse(data)}
            
            renderItem={({item,index})=>{
                console.log(`item = ${JSON.stringify(item) }, index= ${index}`);
                return(<FlatListItem item={item} index={index}></FlatListItem>)
            }}
            >

            </FlatList>
        </View>
        )
    
};
 
const styles = StyleSheet.create({
    container: { flex: 1, padding: 16, paddingTop: 30, backgroundColor: '#fff' },
    header: { height: 50, backgroundColor: '#537791' },
    text: { textAlign: 'center', fontWeight: '100' },
    dataWrapper: { marginTop: -1 },
    row: { height: 40, backgroundColor: '#E7E6E1' }
  });
export default BasicFlatList;
// export default class BasicFlatList extends Component {
//     render() {
//         return (
//             <View style={{flex:1,marginTop:22}}>
//                 <FlatList data={FL}
//                 renderItem={({item,index})=>{
//                     console.log(`item = ${JSON.stringify(item) }, index= ${index}`);
//                     return(<FlatListItem item={item} index={index}></FlatListItem>)
//                 }}
//                 >

//                 </FlatList>
//             </View>
//         )
//     }
// }