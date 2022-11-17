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
        adress vkusno = new adress();
        
        public class adress
        {
            public string strana = "Россия";
            public string oblast = "Московская область";
            public string gorod =  "Москва";
            public string street = "Панфиловский проспект";
            public string nomer = "2";
            public string index = "124460";
        }
        
       
        public void Form1_Load(object sender, EventArgs e)
        {
            Text = "Домашнее задание №5 Брехин Михаил УТС-22";
            button1.Text = vkusno.strana + " " + vkusno.oblast + " " + vkusno.gorod + " " + vkusno.street + " " + vkusno.nomer + " " + vkusno.index;
            label2.Visible = false;
            label3.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = vkusno.strana;
            textBox2.Text = vkusno.oblast;
            textBox3.Text = vkusno.gorod;
            textBox4.Text = vkusno.street;
            textBox5.Text = vkusno.nomer;
            textBox6.Text = vkusno.index;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vkusno.strana = textBox1.Text;
            vkusno.oblast = textBox2.Text;
            vkusno.gorod = textBox3.Text;
            vkusno.street = textBox4.Text;
            string s = textBox5.Text;
            int n1 = 0;
            foreach (char item in s) //Цикл для поочередного обращения к элементам строки
            {
                if (item != ',')
                {
                    if (char.IsDigit(item) == false) // IsDigit функция определяет относится ли символ к категории чисел
                    {
                        n1++;
                    }
                }
            }
            if (n1 != 0)
            {
                label2.Visible = true;
                label2.Text = "Ошибка. Введите число!";
            }
            else
            {
                vkusno.nomer = textBox5.Text;
            }
            string s2 = textBox6.Text;
            int n2 = 0;
            foreach (char item in s2) //Цикл для поочередного обращения к элементам строки
            {
                if (item != ',')
                {
                    if (char.IsDigit(item) == false) // IsDigit функция определяет относится ли символ к категории чисел
                    {
                        n2++;
                    }
                }
            }
            if (n2 != 0 || s2.Length != 6)
            {
                label3.Visible = true;
                label3.Text = "Ошибка. Индекс должен состоять из 6 цифр!";
            }
            else
            {
                vkusno.index = textBox6.Text;
            }

            button1.Text = vkusno.strana + " " + vkusno.oblast + " " + vkusno.gorod +" " + vkusno.street + " " + vkusno.nomer + " " + vkusno.index;
        }

        
    }
}
