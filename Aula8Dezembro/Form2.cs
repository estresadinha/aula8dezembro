﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8Dezembro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        

        

        
private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            tela.AppendText ("\r\n" + "Pressionei a tecla: " + e.KeyCode);
            tela.AppendText("\r\n" + "\t" + "codigo da tecla: " + ((int)e.KeyCode));

        }

        private void click(object sender, EventArgs e)
        {

        }
    }
    }

