using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization.Configuration;

namespace PryVectoresCruz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] Meses = new string[12] { "Enero","Febrero","Marzo", "Abril", "Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
        Decimal[] Importe = new Decimal[12];
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = cmbmes.SelectedIndex;
            Decimal importe = Convert.ToDecimal(txtImporte.Text);
            Importe[i] = importe;
            
            MessageBox.Show("Dato cargado correctamente");
            
        }

        private void cmbmes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Meses.Length; i++)
            {
                cmbmes.Items.Add(Meses[i]);
            }
            cmbmes.SelectedIndex = 0;
        }

        private void btnCargaFor_Click(object sender, EventArgs e)
        {
            int i = cmbmes.SelectedIndex;
            Importe[i] = Convert.ToDecimal(txtImporte.Text);
            DgvImporte.Rows.Add(Meses[i], Importe[i]);
            MessageBox.Show("Dato cargado correctamente");
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DgvImporte.Rows.Clear();
            for (int i = 0; i < Meses.Length; i++)
            {
                if (Importe[i] != 0)
                {
                    DgvImporte.Rows.Add(Meses[i], Importe[i]);
                } 
            }
        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImporte_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                int i = cmbmes.SelectedIndex;
                Importe[i] = Convert.ToDecimal(txtImporte.Text);
                DgvImporte.Rows.Add(Meses[i], Importe[i]);
                txtImporte.Clear();

                if (cmbmes.SelectedIndex != -1)
                {
                    DgvImporte.Rows.Add(Meses[cmbmes.SelectedIndex], Importe[cmbmes.SelectedIndex]);
                }
                else
                {
                    MessageBox.Show("Seleccione un mes");
                }
                 e.SuppressKeyPress = true;
            }
        }
    }
}
