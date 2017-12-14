using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();//เมื่อคลิ๊ก button6 จะโชว์ฟอร์ม2
            f2.Show();//โชว์ฟอร์ม2
            this.Hide(); //ซ่อนไว้
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);//คำสั่งปิดโปรแกรม
        }
    }
}
