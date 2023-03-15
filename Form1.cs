using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace коллекции
{
    public partial class Form1 : Form
    { int age;
        public Form1()
        {

            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("люди.txt"))
            {
                StreamReader s = File.OpenText("люди.txt");
                while (!s.EndOfStream)
                {
                    label2.Text = s.ReadToEnd();
                }
                s.Close();
            }
            else
                MessageBox.Show("Файл не найден");
        }
        private void Numb(string x,Hashtable c) {
            StringBuilder s = new StringBuilder();
            ICollection collect = c.Keys;
            s.AppendLine(x);
            foreach(string i in collect)
            {
                s.AppendLine(i + " " + c[i]);

            }
            MessageBox.Show(s.ToString(), "СООБЩЕНИЕ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hashtable people = new Hashtable();
            age = Convert.ToInt32(textBox1.Text);
            StreamReader sr = File.OpenText("люди.txt");
            string lud;
            while((lud=sr.ReadLine()) != null)
            {
                string[] st = lud.Split(' ');
                string name=st[0]+" "+st[1] + " " + st[2];
                string i = st[3] + " " + st[4];
                int a = int.Parse(st[3]);
                if (a < age)
                {
                    people.Add(name, i);
                    label2.Text = i;
                }
               
            }
            Numb($"Меньше {age}", people);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
