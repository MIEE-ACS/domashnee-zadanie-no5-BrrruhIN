using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        public class adress
        {
            public string strana;
            public string oblast;
            public string gorod;
            public string street;
            public string nomer;
            public string index;
        }
       
        public void Form1_Load(object sender, EventArgs e)
        {
            Text = "Домашнее задание №5 Брехин Михаил УТС-22";

            adress vkusno = new adress();
            vkusno.strana = "Россия";
            vkusno.oblast = "Московская область";
            vkusno.gorod = "Москва";
            vkusno.street = "Панфиловский проспект";
            vkusno.nomer = "2";
            vkusno.index = "124460";
            label2.Text = vkusno.strana;
            label3.Text = vkusno.oblast;
            label4.Text = vkusno.gorod;
            label5.Text = vkusno.street;
            label6.Text = vkusno.nomer;
            label7.Text = vkusno.index;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button7.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            button8.Visible = true;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            button9.Visible = true;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            button10.Visible = true;
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            button11.Visible = true;
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
            button12.Visible = true;
            button6.Visible = false;
        }

        public void Button7_Click(object sender, EventArgs e)
        {
            vkusno.strana = textBox1.Text;
            label2.Text = vkusno.strana;


        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
