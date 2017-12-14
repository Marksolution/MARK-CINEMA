using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form4 f1 = new Form4();
            Form4.name_m = "1";
            Form4.time = 00;
            f1.Show();
            this.Hide();
             
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            Form4.name_m = "2";
            Form4.time = 00;
            f2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 f3 = new Form4();
            Form4.name_m = "3";
            Form4.time = 00;
            f3.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            Form4.name_m = "4";
            Form4.time = 00;
            f4.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 f5 = new Form4();
            Form4.name_m = "5";
            Form4.time = 00;
            f5.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 f6 = new Form4();
            Form4.name_m = "6";
            Form4.time = 00;
            f6.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form4 f7 = new Form4();
            Form4.name_m = "7";
            Form4.time = 00;
            f7.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form4 f8 = new Form4();
            Form4.name_m = "8";
            Form4.time = 00;
            f8.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form4 f9 = new Form4();
            Form4.name_m = "9";
            Form4.time = 00;
            f9.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form4 f10 = new Form4();
            Form4.name_m = "10";
            Form4.time = 00;
            f10.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form4 f11 = new Form4();
            Form4.name_m = "11";
            Form4.time = 00;
            f11.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form4 f12 = new Form4();
            Form4.name_m = "12";
            Form4.time = 00;
            f12.Show();
            this.Hide();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //c1 = cinema1, c2 = cinema2, c3 = cinema3, c4 = cinema4
            DateTime m = DateTime.Now; //เวลาปัจจุบัน
            textBox5.Text = m.ToString("hh:mm:ss dd/MM/yyyy");//กำหนดเป็น วัน/เดือน/ปี
            TimeSpan c1_1 = new TimeSpan(22, 0, 0);//c1_1 = cinema1 รอบเวลาที่1 เวลาที่โชว์ 11:30 +-30นาที เป็น 12:00
            TimeSpan c1_2 = new TimeSpan(14, 0, 0);//c1_2 = cinema1 รอบเวลาที่2 เวลาที่โชว์ 13:30 +-30นาที เป็น 14:00
            TimeSpan c1_3 = new TimeSpan(18, 0, 0);//c1_3 = cinema1 รอบเวลาที่3 เวลาที่โชว์ 17:30 +-30นาที เป็น 18:00
            TimeSpan c2_1 = new TimeSpan(10, 30, 0);//c2_1 = cinema2 รอบเวลาที่1 เวลาที่โชว์ 10:00 +-30นาที เป็น 10:30
            TimeSpan c2_2 = new TimeSpan(13, 0, 0);//c2_2 = cinema2 รอบเวลาที่2 เวลาที่โชว์ 12:30 +-30นาที เป็น 13:00
            TimeSpan c2_3 = new TimeSpan(14, 45, 0);//c2_3 = cinema2 รอบเวลาที่3 เวลาที่โชว์ 14:15 +-30นาที เป็น 14:45
            TimeSpan c3_1 = new TimeSpan(13, 0, 0);//c3_1 = cinema3 รอบเวลาที่1 เวลาที่โชว์ 12:30 +-30นาที เป็น 13:00
            TimeSpan c3_2 = new TimeSpan(14, 30, 0);//c3_2 = cinema3 รอบเวลาที่2 เวลาที่โชว์ 14:00 +-30นาที เป็น 14:30
            TimeSpan c3_3 = new TimeSpan(19, 0, 0);//c3_3 = cinema3 รอบเวลาที่3 เวลาที่โชว์ 18:30 +-30นาที เป็น 19:00
            TimeSpan c4_1 = new TimeSpan(12, 0, 0);//c4_1 = cinema4 รอบเวลาที่1 เวลาที่โชว์ 11:30 +-30นาที เป็น 12:00
            TimeSpan c4_2 = new TimeSpan(14, 15, 0);//c4_2 = cinema4 รอบเวลาที่2 เวลาที่โชว์ 13:45 +-30นาที เป็น 14:15
            TimeSpan c4_3 = new TimeSpan(17, 0, 0);//c4_3 = cinema4 รอบเวลาที่3 เวลาที่โชว์ 16:30 +-30นาที เป็น 17:00
            TimeSpan now = DateTime.Now.TimeOfDay;

            if (now<c1_1)
            {

                button5.BackColor = Color.Red;//เมื่อถึงรอบเวลาของ c1_1 จะเปลี่ยนสี button5 เป็นสี แดง
            }
            else
            {
              
                button5.BackColor = Color.White;//เมื่อเลยเวลาที่+30นาทีไปแล้ว button5 จะเปลี่ยนเป็นสีขาว
                button5.Enabled = false;//คำสั่งล็อคปุ่มไม่สามารถกดได้
            }
            if(now < c1_2)
            {
                button6.BackColor = Color.Red;//เมื่อถึงรอบเวลาของ c1_2 จะเปลี่ยนสี button6 เป็นสี แดง
            }
            else
            {

                button6.BackColor = Color.White;//เมื่อเลยเวลาที่+30นาทีไปแล้ว button6 จะเปลี่ยนเป็นสีขาว
                button6.Enabled = false;//คำสั่งล็อคปุ่มไม่สามารถกดได้
            }
            if (now < c1_3)
            {
                button7.BackColor = Color.Red;//เมื่อถึงรอบเวลาของ c1_3 จะเปลี่ยนสี button7 เป็นสี แดง
            }
            else
            {

                button7.BackColor = Color.White;//เมื่อเลยเวลาที่+30นาทีไปแล้ว button7 จะเปลี่ยนเป็นสีขาว
                button7.Enabled = false;//คำสั่งล็อคปุ่มไม่สามารถกดได้
            }
            if (now < c2_1)
            {
                button8.BackColor = Color.Red;//เมื่อถึงรอบเวลาของ c2_1 จะเปลี่ยนสี button8 เป็นสี แดง
            }
            else
            {

                button8.BackColor = Color.White;//เมื่อเลยเวลาที่+30นาทีไปแล้ว button8 จะเปลี่ยนเป็นสีขาว
                button8.Enabled = false;//คำสั่งล็อคปุ่มไม่สามารถกดได้
            }
            if (now < c2_2)
            {
                button9.BackColor = Color.Red;//เมื่อถึงรอบเวลาของ c2_2 จะเปลี่ยนสี button9 เป็นสี แดง
            }
            else
            {

                button9.BackColor = Color.White;//เมื่อเลยเวลาที่+30นาทีไปแล้ว button9 จะเปลี่ยนเป็นสีขาว
                button9.Enabled = false;//คำสั่งล็อคปุ่มไม่สามารถกดได้
            }
            if (now < c2_3)
            {
                button10.BackColor = Color.Red;//เมื่อถึงรอบเวลาของ c2_3 จะเปลี่ยนสี button10 เป็นสี แดง
            }
            else
            {

                button10.BackColor = Color.White;//เมื่อเลยเวลาที่+30นาทีไปแล้ว button10 จะเปลี่ยนเป็นสีขาว
                button10.Enabled = false;//คำสั่งล็อคปุ่มไม่สามารถกดได้
            }
            if (now < c3_1)
            {
                button11.BackColor = Color.Red;//เมื่อถึงรอบเวลาของ c3_1 จะเปลี่ยนสี button11 เป็นสี แดง
            }
            else
            {

                button11.BackColor = Color.White;//เมื่อเลยเวลาที่+30นาทีไปแล้ว button11 จะเปลี่ยนเป็นสีขาว
                button11.Enabled = false;//คำสั่งล็อคปุ่มไม่สามารถกดได้
            }
            if (now < c3_2)
            {
                button12.BackColor = Color.Red;//เมื่อถึงรอบเวลาของ c3_2 จะเปลี่ยนสี button12 เป็นสี แดง
            }
            else
            {

                button12.BackColor = Color.White;//เมื่อเลยเวลาที่+30นาทีไปแล้ว button12 จะเปลี่ยนเป็นสีขาว
                button12.Enabled = false;//คำสั่งล็อคปุ่มไม่สามารถกดได้
            }
            if (now < c3_3)
            {
                button13.BackColor = Color.Red;//เมื่อถึงรอบเวลาของ c3_3 จะเปลี่ยนสี button13 เป็นสี แดง
            }
            else
            {

                button13.BackColor = Color.White;//เมื่อเลยเวลาที่+30นาทีไปแล้ว button13 จะเปลี่ยนเป็นสีขาว
                button13.Enabled = false;//คำสั่งล็อคปุ่มไม่สามารถกดได้
            }
            if (now < c4_1)
            {
                button14.BackColor = Color.Red;//เมื่อถึงรอบเวลาของ c4_1 จะเปลี่ยนสี button14 เป็นสี แดง
            }
            else
            {

                button14.BackColor = Color.White;//เมื่อเลยเวลาที่+30นาทีไปแล้ว button14 จะเปลี่ยนเป็นสีขาว
                button14.Enabled = false;//คำสั่งล็อคปุ่มไม่สามารถกดได้
            }
            if (now < c4_2)
            {
                button15.BackColor = Color.Red;//เมื่อถึงรอบเวลาของ c4_2 จะเปลี่ยนสี button15 เป็นสี แดง
            }
            else
            {

                button15.BackColor = Color.White;//เมื่อเลยเวลาที่+30นาทีไปแล้ว button15 จะเปลี่ยนเป็นสีขาว
                button15.Enabled = false;//คำสั่งล็อคปุ่มไม่สามารถกดได้
            }
            if (now < c4_3)
            {
                button16.BackColor = Color.Red;//เมื่อถึงรอบเวลาของ c4_3 จะเปลี่ยนสี button16 เป็นสี แดง
            }
            else
            {

                button16.BackColor = Color.White;//เมื่อเลยเวลาที่+30นาทีไปแล้ว button16 จะเปลี่ยนเป็นสีขาว
                button16.Enabled = false;//คำสั่งล็อคปุ่มไม่สามารถกดได้
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            DateTime m = DateTime.Now;
            textBox5.Text = m.ToString("hh:mm:ss dd/MM/yyyy");
            timer1.Start();
           int num = 1;
            string[] s = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "j", "k", "l" };
            string path;
            while (num <= 12)
            {
                string txt1 = "0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n0\r\n";
                int i = 0;
                while (i < s.Length)
                {
                    path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + s[i] + num + ".txt";
                    if (File.Exists(path)==false)
                        System.IO.File.WriteAllText(path, txt1);
                    i++;
                }
                num++;
               
            }

        }
    }
}
