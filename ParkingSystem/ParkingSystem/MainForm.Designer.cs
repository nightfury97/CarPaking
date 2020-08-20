using System.Windows.Forms;

namespace ParkingSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Parking = new System.Windows.Forms.TabPage();
            this.tbXe = new System.Windows.Forms.TextBox();
            this.tbTrong = new System.Windows.Forms.TextBox();
            this.tbDatCho = new System.Windows.Forms.TextBox();
            this.tbTong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RFID = new System.Windows.Forms.TabPage();
            this.btGH = new System.Windows.Forms.Button();
            this.btDK = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpKT = new System.Windows.Forms.DateTimePicker();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbBSXDK = new System.Windows.Forms.TextBox();
            this.tbTKH = new System.Windows.Forms.TextBox();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.tabParking = new System.Windows.Forms.TabPage();
            this.lbOff = new System.Windows.Forms.Label();
            this.lbOn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBSDK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaRF = new System.Windows.Forms.TextBox();
            this.tbTenKhach = new System.Windows.Forms.TextBox();
            this.tbLis = new System.Windows.Forms.TextBox();
            this.imageLis = new System.Windows.Forms.PictureBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Parking.SuspendLayout();
            this.RFID.SuspendLayout();
            this.tabParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Parking);
            this.tabControl.Controls.Add(this.RFID);
            this.tabControl.Controls.Add(this.tabParking);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(6, 4);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1440, 862);
            this.tabControl.TabIndex = 0;
            // 
            // Parking
            // 
            this.Parking.Controls.Add(this.tbXe);
            this.Parking.Controls.Add(this.tbTrong);
            this.Parking.Controls.Add(this.tbDatCho);
            this.Parking.Controls.Add(this.tbTong);
            this.Parking.Controls.Add(this.label1);
            this.Parking.Controls.Add(this.label3);
            this.Parking.Controls.Add(this.label4);
            this.Parking.Controls.Add(this.label2);
            this.Parking.Location = new System.Drawing.Point(8, 53);
            this.Parking.Margin = new System.Windows.Forms.Padding(6);
            this.Parking.Name = "Parking";
            this.Parking.Padding = new System.Windows.Forms.Padding(6);
            this.Parking.Size = new System.Drawing.Size(1424, 801);
            this.Parking.TabIndex = 0;
            this.Parking.Text = "Bãi giữ xe";
            this.Parking.UseVisualStyleBackColor = true;
            this.Parking.Click += new System.EventHandler(this.Parking_Click);
            // 
            // tbXe
            // 
            this.tbXe.Location = new System.Drawing.Point(343, 194);
            this.tbXe.Name = "tbXe";
            this.tbXe.Size = new System.Drawing.Size(108, 47);
            this.tbXe.TabIndex = 7;
            // 
            // tbTrong
            // 
            this.tbTrong.Location = new System.Drawing.Point(343, 451);
            this.tbTrong.Name = "tbTrong";
            this.tbTrong.Size = new System.Drawing.Size(108, 47);
            this.tbTrong.TabIndex = 6;
            // 
            // tbDatCho
            // 
            this.tbDatCho.Location = new System.Drawing.Point(343, 321);
            this.tbDatCho.Name = "tbDatCho";
            this.tbDatCho.Size = new System.Drawing.Size(108, 47);
            this.tbDatCho.TabIndex = 6;
            // 
            // tbTong
            // 
            this.tbTong.Location = new System.Drawing.Point(343, 68);
            this.tbTong.Name = "tbTong";
            this.tbTong.Size = new System.Drawing.Size(108, 47);
            this.tbTong.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 454);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Còn trống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đã đặt chỗ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 44);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số xe trong bãi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng số chỗ";
            // 
            // RFID
            // 
            this.RFID.Controls.Add(this.btGH);
            this.RFID.Controls.Add(this.btDK);
            this.RFID.Controls.Add(this.label14);
            this.RFID.Controls.Add(this.label13);
            this.RFID.Controls.Add(this.dtpKT);
            this.RFID.Controls.Add(this.dtpBD);
            this.RFID.Controls.Add(this.label10);
            this.RFID.Controls.Add(this.label11);
            this.RFID.Controls.Add(this.label12);
            this.RFID.Controls.Add(this.tbBSXDK);
            this.RFID.Controls.Add(this.tbTKH);
            this.RFID.Controls.Add(this.tbRFID);
            this.RFID.Location = new System.Drawing.Point(8, 53);
            this.RFID.Margin = new System.Windows.Forms.Padding(6);
            this.RFID.Name = "RFID";
            this.RFID.Padding = new System.Windows.Forms.Padding(6);
            this.RFID.Size = new System.Drawing.Size(1424, 801);
            this.RFID.TabIndex = 1;
            this.RFID.Text = "Đăng kí thẻ";
            this.RFID.UseVisualStyleBackColor = true;
            // 
            // btGH
            // 
            this.btGH.BackColor = System.Drawing.Color.Aqua;
            this.btGH.Location = new System.Drawing.Point(1005, 360);
            this.btGH.Name = "btGH";
            this.btGH.Size = new System.Drawing.Size(310, 131);
            this.btGH.TabIndex = 25;
            this.btGH.Text = "Gia hạn";
            this.btGH.UseVisualStyleBackColor = false;
            this.btGH.Click += new System.EventHandler(this.btGH_Click);
            // 
            // btDK
            // 
            this.btDK.BackColor = System.Drawing.Color.Lime;
            this.btDK.Location = new System.Drawing.Point(1005, 106);
            this.btDK.Name = "btDK";
            this.btDK.Size = new System.Drawing.Size(310, 131);
            this.btDK.TabIndex = 24;
            this.btDK.Text = "Đăng kí";
            this.btDK.UseVisualStyleBackColor = false;
            this.btDK.Click += new System.EventHandler(this.btDK_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(98, 363);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(244, 44);
            this.label14.TabIndex = 23;
            this.label14.Text = "Ngày bắt đầu";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(98, 448);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(251, 44);
            this.label13.TabIndex = 22;
            this.label13.Text = "Ngày kết thúc";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // dtpKT
            // 
            this.dtpKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKT.Location = new System.Drawing.Point(486, 445);
            this.dtpKT.Name = "dtpKT";
            this.dtpKT.Size = new System.Drawing.Size(428, 47);
            this.dtpKT.TabIndex = 21;
            // 
            // dtpBD
            // 
            this.dtpBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBD.Location = new System.Drawing.Point(486, 360);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(428, 47);
            this.dtpBD.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 190);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 44);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tên khách hàng";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(98, 275);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(278, 44);
            this.label11.TabIndex = 17;
            this.label11.Text = "Biển số đăng kí";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(98, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 44);
            this.label12.TabIndex = 18;
            this.label12.Text = "Thẻ RFID";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tbBSXDK
            // 
            this.tbBSXDK.Location = new System.Drawing.Point(486, 275);
            this.tbBSXDK.Name = "tbBSXDK";
            this.tbBSXDK.Size = new System.Drawing.Size(428, 47);
            this.tbBSXDK.TabIndex = 15;
            // 
            // tbTKH
            // 
            this.tbTKH.Location = new System.Drawing.Point(486, 190);
            this.tbTKH.Name = "tbTKH";
            this.tbTKH.Size = new System.Drawing.Size(428, 47);
            this.tbTKH.TabIndex = 16;
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(486, 105);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(428, 47);
            this.tbRFID.TabIndex = 14;
            // 
            // tabParking
            // 
            this.tabParking.Controls.Add(this.lbOff);
            this.tabParking.Controls.Add(this.lbOn);
            this.tabParking.Controls.Add(this.label8);
            this.tabParking.Controls.Add(this.label7);
            this.tabParking.Controls.Add(this.label9);
            this.tabParking.Controls.Add(this.label6);
            this.tabParking.Controls.Add(this.tbBSDK);
            this.tabParking.Controls.Add(this.label5);
            this.tabParking.Controls.Add(this.tbMaRF);
            this.tabParking.Controls.Add(this.tbTenKhach);
            this.tabParking.Controls.Add(this.tbLis);
            this.tabParking.Controls.Add(this.imageLis);
            this.tabParking.Controls.Add(this.imageBox);
            this.tabParking.Location = new System.Drawing.Point(8, 53);
            this.tabParking.Name = "tabParking";
            this.tabParking.Padding = new System.Windows.Forms.Padding(3);
            this.tabParking.Size = new System.Drawing.Size(1424, 801);
            this.tabParking.TabIndex = 2;
            this.tabParking.Text = "Theo dõi";
            this.tabParking.UseVisualStyleBackColor = true;
            // 
            // lbOff
            // 
            this.lbOff.AutoSize = true;
            this.lbOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOff.ForeColor = System.Drawing.Color.Red;
            this.lbOff.Location = new System.Drawing.Point(1039, 635);
            this.lbOff.Name = "lbOff";
            this.lbOff.Size = new System.Drawing.Size(195, 89);
            this.lbOff.TabIndex = 15;
            this.lbOff.Text = "OFF";
            this.lbOff.Visible = false;
            // 
            // lbOn
            // 
            this.lbOn.AutoSize = true;
            this.lbOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOn.ForeColor = System.Drawing.Color.Blue;
            this.lbOn.Location = new System.Drawing.Point(766, 635);
            this.lbOn.Name = "lbOn";
            this.lbOn.Size = new System.Drawing.Size(155, 89);
            this.lbOn.TabIndex = 15;
            this.lbOn.Text = "ON";
            this.lbOn.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(624, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 44);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ảnh ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(624, 340);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 44);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(624, 499);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 44);
            this.label9.TabIndex = 12;
            this.label9.Text = "Biển số đăng kí";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(624, 415);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 44);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thẻ RFID";
            // 
            // tbBSDK
            // 
            this.tbBSDK.Location = new System.Drawing.Point(1022, 499);
            this.tbBSDK.Name = "tbBSDK";
            this.tbBSDK.Size = new System.Drawing.Size(303, 47);
            this.tbBSDK.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(624, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 44);
            this.label5.TabIndex = 11;
            this.label5.Text = "Biển số";
            // 
            // tbMaRF
            // 
            this.tbMaRF.Location = new System.Drawing.Point(1024, 412);
            this.tbMaRF.Name = "tbMaRF";
            this.tbMaRF.Size = new System.Drawing.Size(301, 47);
            this.tbMaRF.TabIndex = 10;
            // 
            // tbTenKhach
            // 
            this.tbTenKhach.Location = new System.Drawing.Point(1024, 340);
            this.tbTenKhach.Name = "tbTenKhach";
            this.tbTenKhach.Size = new System.Drawing.Size(301, 47);
            this.tbTenKhach.TabIndex = 9;
            // 
            // tbLis
            // 
            this.tbLis.Location = new System.Drawing.Point(840, 152);
            this.tbLis.Name = "tbLis";
            this.tbLis.Size = new System.Drawing.Size(501, 47);
            this.tbLis.TabIndex = 8;
            // 
            // imageLis
            // 
            this.imageLis.Location = new System.Drawing.Point(840, 27);
            this.imageLis.Name = "imageLis";
            this.imageLis.Size = new System.Drawing.Size(501, 103);
            this.imageLis.TabIndex = 1;
            this.imageLis.TabStop = false;
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(28, 27);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(560, 747);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(8, 53);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1424, 801);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Thống kê";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Location = new System.Drawing.Point(8, 53);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1424, 801);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Báo mất thẻ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(84, 172);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(290, 44);
            this.label15.TabIndex = 25;
            this.label15.Text = "Tên khách hàng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(84, 257);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(278, 44);
            this.label16.TabIndex = 23;
            this.label16.Text = "Biển số đăng kí";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(84, 87);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(182, 44);
            this.label17.TabIndex = 24;
            this.label17.Text = "Thẻ RFID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 47);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(472, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(428, 47);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(472, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(428, 47);
            this.textBox3.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(997, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 131);
            this.button1.TabIndex = 26;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(997, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 131);
            this.button2.TabIndex = 27;
            this.button2.Text = "Khóa thẻ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(96, 455);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 44);
            this.label18.TabIndex = 28;
            this.label18.Text = "Kết quả";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 865);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.Parking.ResumeLayout(false);
            this.Parking.PerformLayout();
            this.RFID.ResumeLayout(false);
            this.RFID.PerformLayout();
            this.tabParking.ResumeLayout(false);
            this.tabParking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Parking;
        private System.Windows.Forms.TabPage RFID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbXe;
        private System.Windows.Forms.TextBox tbDatCho;
        private System.Windows.Forms.TextBox tbTong;
        private System.Windows.Forms.TextBox tbTrong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabParking;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaRF;
        private System.Windows.Forms.TextBox tbTenKhach;
        private System.Windows.Forms.TextBox tbLis;
        private System.Windows.Forms.PictureBox imageLis;
        private Label lbOff;
        private Label lbOn;
        private Label label9;
        private TextBox tbBSDK;
        private DateTimePicker dtpBD;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox tbBSXDK;
        private TextBox tbTKH;
        private TextBox tbRFID;
        private Label label14;
        private Label label13;
        private DateTimePicker dtpKT;
        private Button btGH;
        private Button btDK;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label18;
        private Button button2;
    }
}

