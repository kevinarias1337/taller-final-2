using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerFinal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int horas = int.Parse(txthoras.Text);
            int valor = int.Parse(txtvalor.Text);

            double total = horas * valor;           

            if (total< 700000)
            {
                total = total + total *0.010;
                lbltotal.Text = "Salario total:" + total.ToString();
                lbltotal.Visible = true;
                MessageBox.Show("Descuento de 0% e incremento de 10%");
            }
            if (total >= 700000 && total<= 1000000)
            {
                total = total - total * 0.02;
                lbltotal.Text = "Salario total:" + total.ToString();
                lbltotal.Visible = true;
                MessageBox.Show("Descuento de 2% e incremento de 0%");
            }
            if (total > 1000001)
            {
                total = total - total * 0.05;
                total = total + total * 0.02;
                lbltotal.Text = "Salario total:"+total.ToString();
                lbltotal.Visible = true;
                MessageBox.Show("Decuento de 5% e incremento de 2%");
            }
            
        }
    }
}
