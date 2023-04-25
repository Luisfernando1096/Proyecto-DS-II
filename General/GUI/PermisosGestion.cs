using System;
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
    public partial class PermisosGestion : Form
    {
        BindingSource datos = new BindingSource();

        private void CargarRoles()
        {
            DataTable roles = new DataTable();
            try
            {
                roles = DataManager.DBConsultas.Roles();
                cmbRoles.DataSource = roles;
                cmbRoles.DisplayMember = "rol";
                cmbRoles.ValueMember = "idRol";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarPermisos()
        {
            DataTable permisos = new DataTable();
            String idRol = cmbRoles.SelectedValue.ToString();
            try
            {
                permisos = DataManager.DBConsultas.Permisos(idRol);
                dgvPermisos.AutoGenerateColumns = false;
                dgvPermisos.DataSource = permisos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public PermisosGestion()
        {
            InitializeComponent();
        }

        private void PermisosGestion_Load(object sender, EventArgs e)
        {
            CargarRoles(); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbRoles_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarPermisos();
        }

        private void dgvPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    String valorActual;
                    valorActual = dgvPermisos.CurrentRow.Cells["asignado"].Value.ToString();
                    if (valorActual == "0")
                    {
                        CLS.Permisos oPermiso = new CLS.Permisos();
                        oPermiso.IdOpcion = dgvPermisos.CurrentRow.Cells["id"].Value.ToString();
                        oPermiso.IdRol = cmbRoles.SelectedValue.ToString();
                        if (oPermiso.Insertar())
                        {
                            CargarPermisos();
                        }

                    }
                    else
                    {
                        CLS.Permisos oPermiso = new CLS.Permisos();
                        oPermiso.IdPermiso = dgvPermisos.CurrentRow.Cells["idPermiso"].Value.ToString();
                        if (oPermiso.Eliminar())
                        {
                            CargarPermisos();
                        }
                    }
                    dgvPermisos.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
