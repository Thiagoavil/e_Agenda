﻿using E_Agenda.WinForms.Compromisso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinForms
{
    public partial class CompromissoForm : Form
    {
        public CompromissoForm()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Compromisso_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdicionarCompromisso_Click(object sender, EventArgs e)
        {
            CriandoCompromissoForm tela = new CriandoCompromissoForm();
            DialogResult result = tela.ShowDialog();

            if(result == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}