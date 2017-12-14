using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
 
      
        private void Form3_Load(object sender, EventArgs e)
        {
            num1.Text = Form4.num.ToString();
            tb1.Text = Form4.num0.ToString();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            
           if((int.Parse(tb2.Text) - int.Parse(tb1.Text)) < 0) 
            {
                MessageBox.Show("เงินไม่พอ");
            }
            else
            {
                textBox3.Text = (int.Parse(tb2.Text) - int.Parse(tb1.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt1 = "จำนวน : " + num1.Text + " " + "คน" +  "\r\n" + "ราคารวม : " + tb1.Text + " " + "บาท" + "\r\n" + "เงินที่รับมา : " + tb2.Text + " " + "บาท" + "\r\n" + "เงินทอน : " + textBox3.Text +" "+ "บาท" +"\r\n"+ "\r\n" +"คุณต้องการปริ้นมั้ย?"+"\r\n" + DateTime.Now.ToString("hh:mm") +" "+ DateTime.Now.ToString("dd//MM/yyyy") + "\r\n"; 
            DialogResult dialogResult = MessageBox.Show(txt1, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string txt = txt1;
                System.IO.File.WriteAllText(@"E:\" + "print.txt", txt);
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(@"E:\" + "print.txt");
                psi.Verb = "PRINT";

                Process.Start(psi);
                
            }
            else if (dialogResult == DialogResult.No)
            {
                
                Environment.Exit(0);//คำสั่งปิดโปรแกรม
            }
            
        }
    }
}
