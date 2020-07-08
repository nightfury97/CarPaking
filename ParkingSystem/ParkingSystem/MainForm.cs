using CSDL.EF;
using CSDL.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
namespace ParkingSystem
{
    public partial class MainForm : Form
    {
        MqttClient client;
        string clientId;
        public MainForm()
        {
            InitializeComponent();
            client = new MqttClient("192.168.8.100");
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);
            client.Subscribe(new string[] { "OpenGate" }, new byte[] { 2 });
            client.Subscribe(new string[] { "OpenGate" }, new byte[] { 2 });
        }
        delegate void SetImageCallback(string[] arrListStr);
        private void SetImage(string[] arrListStr)
        {
            
            if (this.tabParking.InvokeRequired)
            {
                SetImageCallback d = new SetImageCallback(SetImage);
                this.Invoke(d, new object[] { arrListStr });
            }
            else
            {
                tbLis.Text = arrListStr[2];
                imageBox.Image = Image.FromFile("D:/Driver/DoAnTuan/recognize-license-plate/anh/"+ arrListStr[1]);
                imageLis.Image = Image.FromFile("D:/Driver/DoAnTuan/recognize-license-plate/anh/crop/" + arrListStr[1]);
            }
        }
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
            string[] arrListStr = ReceivedMessage.Split('+');
            SetImage(arrListStr);
            //MessageBox.Show(ReceivedMessage);
            //Dispatcher.Invoke(delegate
            //{              // we need this construction because the receiving code in the library and the UI with textbox run on different threads
            //    mqtt.Text = ReceivedMessage;
            //});
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            F_BaiGiuXe fbgx = new F_BaiGiuXe();
            BaiGiuXe bgx = fbgx.GetSingleById(1);
            tbTong.Text = bgx.TongSoCho.ToString();
            tbXe.Text = bgx.DaCoXe.ToString();
            tbDatCho.Text = bgx.DatTruoc.ToString();
            tbTrong.Text = (bgx.TongSoCho - bgx.DaCoXe - bgx.DatTruoc).ToString();
        }

        private void Parking_Click(object sender, EventArgs e)
        {
           
        }
    }
}
