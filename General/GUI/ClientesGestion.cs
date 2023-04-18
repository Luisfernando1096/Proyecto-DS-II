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
    public partial class ClientesGestion : Form
    {
        BindingSource datos = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Clientes();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado
                                                     //Codigo para insertar los datos en el datagrid
                                                     //Codigo para mostrar cuantas filas se 
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";

            }
            catch (Exception)
            {

                throw;
            }
        }
        public ClientesGestion()
        {
            InitializeComponent();
        }

        private void ClientesGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClientesEdicion f = new ClientesEdicion();
            f.ShowDialog();
            CargarDatos();
        }
    }
}
