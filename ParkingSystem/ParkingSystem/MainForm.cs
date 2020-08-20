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
            //client = new MqttClient("192.168.8.100");
            //client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            //clientId = Guid.NewGuid().ToString();
            //client.Connect(clientId);
            //client.Subscribe(new string[] { "OpenGate" }, new byte[] { 2 });
            //client.Subscribe(new string[] { "RFID" }, new byte[] { 2 });
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
                imageBox.Image = Image.FromFile("D:/Driver/DoAnTuan/CarLiscense/anh/" + arrListStr[1]);
                imageLis.Image = Image.FromFile("D:/Driver/DoAnTuan/CarLiscense/anh/crop/" + arrListStr[1]);
                if (arrListStr[0] == "ON")
                {
                    lbOn.Visible = true;
                    lbOff.Visible = false;
                }
                else
                {
                    lbOn.Visible = false;
                    lbOff.Visible = true;
                }
            }
        }
        delegate void SetRFIDCallback(string[] arrListStr);
        private void SetRFID(string[] arrListStr)
        {

            if (this.tabParking.InvokeRequired)
            {
                SetImageCallback d = new SetImageCallback(SetRFID);
                this.Invoke(d, new object[] { arrListStr });
            }
            else
            {
                F_TheRFID frf = new F_TheRFID();
                string code = arrListStr[1];
                var the = frf.GetSingleByCondition(x => x.MaCode == code);
                tbMaRF.Text = the.MaCode;
                tbTenKhach.Text = the.HoTen;
                tbBSDK.Text = the.BienSoXe;
            }
        }
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
            string Topic = e.Topic;
            if(Topic== "OpenGate")
            {
                string[] arrListStr = ReceivedMessage.Split('+');
                SetImage(arrListStr);
            }
            if(Topic == "RFID")
            {
                var mes = ReceivedMessage.Replace(" ", "");
                string[] arrListStr = ReceivedMessage.Split('-');
                SetRFID(arrListStr);
            }
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btDK_Click(object sender, EventArgs e)
        {
            string msrfid = tbRFID.Text;
            string tenkh = tbTKH.Text;
            string bsxdk = tbBSXDK.Text;
            DateTime bd = dtpBD.Value;
            DateTime kt = dtpKT.Value;
            TheRFID trf = new TheRFID();
            F_TheRFID ftrf = new F_TheRFID();
            trf.MaCode = msrfid;
            trf.HoTen = tenkh;
            trf.TrangThai = 1;
            trf.BienSoXe = bsxdk;
            trf.ThoiGianBatDau = bd;
            trf.ThoiGianKetThuc = kt;
            ftrf.Add(trf);
            ftrf.Save();
        }

        private void btGH_Click(object sender, EventArgs e)
        {
            string msrfid = tbRFID.Text;
            string tenkh = tbTKH.Text;
            string bsxdk = tbBSXDK.Text;
            DateTime bd = dtpBD.Value;
            DateTime kt = dtpKT.Value;
            F_TheRFID ftrf = new F_TheRFID();
            TheRFID trf = ftrf.GetSingleByCondition(x => x.MaCode == msrfid);
            trf.HoTen = tenkh;
            trf.TrangThai = 1;
            trf.BienSoXe = bsxdk;
            trf.ThoiGianBatDau = bd;
            trf.ThoiGianKetThuc = kt;
            ftrf.Save();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
