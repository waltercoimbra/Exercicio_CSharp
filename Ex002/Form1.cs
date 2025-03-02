using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex002
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            lblMeu.Text = "MEU";
            lblMeu.Visible = true;
            await Task.Delay(1000);

            lblBrasil.Text = "BRASIL";
            lblBrasil.Visible = true;
            await Task.Delay(1000);

            lblBrasileiro.Text = "BRASILEIRO";
            lblBrasileiro.Visible = true;
            await Task.Delay(1000);
            
            lblMeu.BackColor = Color.Blue;
            lblMeu.ForeColor = Color.White;
            await Task.Delay(1000);
            lblBrasil.BackColor = Color.Yellow;
            lblBrasil.ForeColor = Color.Green;
            await Task.Delay(1000);
            lblBrasileiro.BackColor = Color.Green;
            lblBrasileiro.ForeColor = Color.White;
        }
    }
}
