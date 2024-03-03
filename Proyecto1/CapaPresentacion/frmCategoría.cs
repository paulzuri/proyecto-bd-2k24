using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using Npgsql;

namespace CapaPresentacion
{
    public partial class frmCategoría : Form
    {
        public frmCategoría()
        {
            InitializeComponent();
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
        }

        private void frmCategoría_Load(object sender, EventArgs e)
        {
            // Se cargan valores en el objeto combo box para presentar opciones de busqueda
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

            // Se cargan las categorías en la tabla
            List<Category> listaCategorias = ListarCategorias();

            foreach (var categoria in listaCategorias)
            {
                dgvData.Rows.Add(new object[] {"", categoria.CategoryId.ToString(), categoria.Name});
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private List<Category> ListarCategorias()
        {
            List<Category> lista = new List<Category>();
            using (var oconexion = new NpgsqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();

                    string query = "SELECT category_id, name FROM category";

                    using (var cmd = new NpgsqlCommand(query, oconexion))
                    {
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lista.Add(new Category()
                            {
                                CategoryId = Convert.ToInt32(reader["category_id"]),
                                Name = reader["name"].ToString()
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return lista;
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.ColumnIndex >= 0) { 
                if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
                {
                    int indice = e.RowIndex;

                    if (indice >= 0)
                    {
                        txtId.Text = dgvData.Rows[indice].Cells["Codigo"].Value.ToString();
                        txtIndice.Text = indice.ToString();
                        txtCodigo.Text = dgvData.Rows[indice].Cells["Codigo"].Value.ToString();
                        txtCategoria.Text = dgvData.Rows[indice].Cells["Categoria"].Value.ToString();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "0";
            txtIndice.Text = "-1";
            txtCodigo.Text = "";
            txtCategoria.Text = "";
        }
    }
}
