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
using Npgsql;
using CapaPresentacion;

namespace Interfaces
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

            // Se cargan las categorías en la tabla
            List<Staff> listaEmpleados = ListarEmpleados();

            foreach (var empleado in listaEmpleados)
            {
                dgvData.Rows.Add(new object[] { "", empleado.StaffId.ToString(), $"{empleado.Username} {empleado.LastName}", empleado.Email, empleado.StoreId.ToString() , empleado.Active, empleado.Password });
            }
        }
        private List<Staff> ListarEmpleados()
        {
            List<Staff> lista = new List<Staff>();
            using (var oconexion = new NpgsqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();

                    string query = "SELECT staff_id, first_name, last_name, email, store_id, active FROM staff";

                    using (var cmd = new NpgsqlCommand(query, oconexion))
                    {
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lista.Add(new Staff()
                            {
                                StaffId = Convert.ToInt32(reader["staff_id"]),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                Email = reader["email"].ToString(),
                                StoreId = Convert.ToInt32(reader["store_id"]),
                                Active = Convert.ToBoolean(reader["active"])
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




    }
}
