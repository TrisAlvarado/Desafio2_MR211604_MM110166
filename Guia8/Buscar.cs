using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2_MR211604_MM110166
{
    public partial class Buscar : Form
    {   
        public bool control; 
        public string dato;
        public int estado;

        public Buscar(int x)
        {
            InitializeComponent();
            control = false;
            dato = " ";
            estado = x;

        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string valor =  txtorigen.Text.Trim();
            string valor2= txtdestino.Text.Trim();
            if ((valor == "") || (valor == " "))
            {
                MessageBox.Show("Es necesario ingresar un valor", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                
            }
            if (estado == 2 && (valor2 == "" || valor2 == " "))
            {
                MessageBox.Show("Es necesario ingresar un valor", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                control = true;
                this.Hide();
            }

        }

        private void txteliminar_TextChanged(object sender, EventArgs e)
        {
            txtorigen.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            control = false;
            this.Hide();
        }

        private void Eliminarcs_Load(object sender, EventArgs e)
        {
            txtorigen.Focus();
            this.Text = "Algoritmo Warshall";
            label1.Text = "Ruta de nodos:";
            label2.Text = "Nodo origen";
            label3.Text = "Nodo destino";
        }

        private void txteliminar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(null, null);
            }
        }

        private void Eliminarcs_Shown(object sender, EventArgs e)
        {
            txtorigen.Clear();
            txtorigen.Focus();
        }

        private void Eliminarcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
