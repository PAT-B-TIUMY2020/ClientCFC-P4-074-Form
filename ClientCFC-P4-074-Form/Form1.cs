using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_074;

namespace ClientCFC_P4_074_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasicHttpBinding bind = new BasicHttpBinding();
            ChannelFactory<IMatematika> objChannel = new ChannelFactory<IMatematika>(bind, "http://localhost:1907");
            IMatematika obj = objChannel.CreateChannel();
            double hasilTambah = obj.Tambah(1, 2);
            label1.Text = "1 + 2";
            label6.Text = hasilTambah.ToString();
            double hasilKurang = obj.Kurang(3, 2);
            label2.Text = "3 - 2";
            label7.Text = hasilKurang.ToString();
            double hasilKali = obj.Kali(2, 2);
            label3.Text = "2 x 2";
            label8.Text = hasilKali.ToString();
            double hasilBagi = obj.Bagi(2, 2);
            label4.Text = "2 : 2";
            label9.Text = hasilBagi.ToString();
        }
    }
}
