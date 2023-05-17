﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class ProveedoresEdicion : Form
    {
        public ProveedoresEdicion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DireccionesGestion f = new DireccionesGestion();
            f.btnSeleccionar.Visible = true;
            var result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDireccion.Text = f.direccionEnviar;
                txtIdDireccion.Text = f.idEnviar;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear el objeto entidad
            CLS.Proveedores c = new CLS.Proveedores();
            //Sincronizar la entidad con la interfaz
            c.Nombre = txtnombre.Text;
            DataTable doc = DataManager.DBConsultas.DocumentoProveedor();
            int aux = 0;
            string aux2 = "";
            if (doc.Rows.Count>0)
            {
                aux = Int32.Parse(doc.Rows[0][0].ToString()) + 1;
            }
            else
            {
                aux = 1;
            }
            if (aux<10)
            {
                aux2 = "0000" + aux.ToString();
            }else if (aux>=10 && aux<100)
            {
                aux2 = "000" + aux.ToString();
            }
            else if (aux >= 100 && aux < 1000)
            {
                aux2 = "00" + aux.ToString();
            }
            else if (aux >= 1000 && aux < 10000)
            {
                aux2 = "0" + aux.ToString();
            }
            else if (aux >= 10000 && aux < 100000)
            {
                aux2 = aux.ToString();
            }
            c.Documento = aux2;
            c.Telefono = txtTelefono.Text;
            c.IdDireccion = Int32.Parse(txtIdDireccion.Text);
            //Realizar la operacion necesaria

            if (txtIdProveedor.TextLength > 0)
            {
                c.IdProveedor = Int32.Parse(txtIdProveedor.Text);
                if (c.Actualizar())
                {
                    MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no se actualizo correctamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (c.Insertar())
                {
                    MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Se genero Numero de documento: " + aux2, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue insertado correctamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
