using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuThuyen
{
    public partial class Form1 : Form
    {
        double tien;
        
        public Form1()
        {
            InitializeComponent();
            addData();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            exit();
        }
        private void exit()
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.H)
            {
                exit();
            }
            if (e.Alt == true && e.KeyCode == Keys.H)
            {
                addKhach();
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "200";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "100";
        }
        private void addData()
        {
            comboBox1.Items.Add("Coca cola");
            comboBox1.Items.Add("Pepsi");
            comboBox1.Items.Add("Seven up");
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox2.Items.Add("5");
            comboBox2.Items.Add("6");
            comboBox2.Items.Add("7");
            comboBox2.Items.Add("8");
            comboBox2.Items.Add("9");
            comboBox2.Items.Add("10");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Coca cola")
            {
                tien = 0.5;

            }
            if (comboBox1.Text == "Pepsi")
            {
                tien = 0.8;
            }
            if (comboBox1.Text == "Seven up")
            {
                tien = 1.0;
            }
            comboBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tongTien();
        }
        private void tongTien()
        {
            double tongtien;
            tongtien = tien * Convert.ToDouble(comboBox2.Text);
            textBox3.Text = tongtien.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            addKhach();
        }
        private void addKhach()
        {
            double sum = Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text);
            if (radioButton1.Checked)
            {
                listBox1.Items.Add(textBox1.Text + " | " + radioButton1.Text + " | " + textBox2.Text + "$ | " + "Đồ uống: " + textBox3.Text + "$ | "
                 + "Tổng tiền: " + sum + "$");
            }
            else
            {
                listBox1.Items.Add(textBox1.Text + " | " + radioButton2.Text + " | " + textBox2.Text + "$ | " + "Đồ uống: " + textBox3.Text + "$ | "
                + "Tổng tiền: " + sum + "$");
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox2.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            textBox3.Text = " ";
            textBox1.Focus();
        }
    }
}
