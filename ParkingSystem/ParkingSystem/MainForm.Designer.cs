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
            this.tabParking = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbLis = new System.Windows.Forms.TextBox();
            this.imageLis = new System.Windows.Forms.PictureBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Parking.SuspendLayout();
            this.tabParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Parking);
            this.tabControl.Controls.Add(this.RFID);
            this.tabControl.Controls.Add(this.tabParking);
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
            this.RFID.Location = new System.Drawing.Point(8, 53);
            this.RFID.Margin = new System.Windows.Forms.Padding(6);
            this.RFID.Name = "RFID";
            this.RFID.Padding = new System.Windows.Forms.Padding(6);
            this.RFID.Size = new System.Drawing.Size(1424, 801);
            this.RFID.TabIndex = 1;
            this.RFID.Text = "Quản lý thẻ";
            this.RFID.UseVisualStyleBackColor = true;
            // 
            // tabParking
            // 
            this.tabParking.Controls.Add(this.label10);
            this.tabParking.Controls.Add(this.label9);
            this.tabParking.Controls.Add(this.label8);
            this.tabParking.Controls.Add(this.label7);
            this.tabParking.Controls.Add(this.label6);
            this.tabParking.Controls.Add(this.label5);
            this.tabParking.Controls.Add(this.textBox1);
            this.tabParking.Controls.Add(this.textBox2);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(648, 125);
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
            this.label7.Location = new System.Drawing.Point(648, 518);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 44);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(648, 391);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 44);
            this.label6.TabIndex = 12;
            this.label6.Text = "Đăng kí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(648, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 44);
            this.label5.TabIndex = 11;
            this.label5.Text = "Biển số";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(967, 391);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 47);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(967, 518);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 47);
            this.textBox2.TabIndex = 9;
            // 
            // tbLis
            // 
            this.tbLis.Location = new System.Drawing.Point(967, 265);
            this.tbLis.Name = "tbLis";
            this.tbLis.Size = new System.Drawing.Size(301, 47);
            this.tbLis.TabIndex = 8;
            // 
            // imageLis
            // 
            this.imageLis.Location = new System.Drawing.Point(834, 83);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(766, 635);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 89);
            this.label9.TabIndex = 15;
            this.label9.Text = "ON";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(1039, 635);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 89);
            this.label10.TabIndex = 15;
            this.label10.Text = "OFF";
            this.label10.Visible = false;
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
            this.tabParking.ResumeLayout(false);
            this.tabParking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbLis;
        private System.Windows.Forms.PictureBox imageLis;
        private Label label10;
        private Label label9;
    }
}

