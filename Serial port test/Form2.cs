using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Serial_port_test
{
    public partial class Form2 : Form
    {
        public TextBox col;
        public TextBox col2;

        
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            co.Text = col.Text;
            
            if(col.Text == col2.Text)
            {               
                StreamWriter file = new StreamWriter("C:\\for\\rap.txt", true);
                file.WriteLine("Успех тестирования. Посланная информация: " + col2.Text + "Принятая информация: " + co.Text + " " + DateTime.Now + "\n");
                file.Close();
            }
        }

        private void co_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
