using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex004
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            float num;
            float.TryParse(txtNum.Text, out num);
            int n1 = (int) num;
            int n2 = Convert.ToInt16(num);
            lbl1.Text = $"Você digitou o valor: {num:N}";
            
            lbl2.Text = $"A parte inteira é: {n1:D} ";
            
            lbl3.Text = $"Arredondando temos: {n2:D} ";

            panResultado.Visible = true;
        }
    }
}
