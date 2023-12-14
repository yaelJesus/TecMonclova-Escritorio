using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecMonclova_Escritorio
{
    public partial class Usuario : Form
    {
        string consulta;
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Limpiar();
        }

        private void MostrarDatos()
        {
            DataTable tabla = Conn.ejecutaConsultaSelect("SELECT userName, name, CONCAT('********', SUBSTRING(password, 0, 1)) AS password, email FROM [User] WHERE status = 1");
            dataGridView1.DataSource = tabla;
        }

        private void Limpiar()
        {
            MtlUserName.Clear();
            MtlName.Clear();
            MtlEmail.Clear();
            MtlPass.Clear();
            MtlConfirmPass.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string userName = MtlUserName.Text;
            string name = MtlName.Text;
            string email = MtlEmail.Text;
            string password = "";
            string idUserCreate = UserCache.IdUser.ToString();
            string creationDate = DateTime.Today.ToString("yyyy-MM-dd");
            if (MtlPass.Text == MtlConfirmPass.Text)
                password = MtlPass.Text;
            else
            {
                MessageBox.Show("Las contraseñas no cinciden, por favor vuelva a intentar", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            consulta = "INSERT INTO [User] (userName, name, password, email, idUserCreate, creationDate) VALUES ('" + userName + "', '" + name + "', '" + password + "', '" + email + "', " + idUserCreate + ", '" + creationDate + "')";
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string userName = MtlUserName.Text;
            string name = MtlName.Text;
            string email = MtlEmail.Text;
            string password = "";
            string idUserModify = UserCache.IdUser.ToString();
            string modifiedDate = DateTime.Today.ToString("yyyy-MM-dd");
            if (MtlPass.Text == MtlConfirmPass.Text)
                password = MtlPass.Text;
            else
            {
                MessageBox.Show("Las contraseñas no cinciden, por favor vuelva a intentar", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int a = dataGridView1.CurrentCell.RowIndex;
            int idUser = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE [User] SET userName = '" + userName + "', name = '" + name + "', password = '" + password + "', email = '" + email + "', idUserModify = " + idUserModify + ", modifiedDate = '" + modifiedDate + "' WHERE idUser = " + idUser;
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            int idUser = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE [User] SET status = 0 WHERE idUser = " + idUser;
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        bool tru = false;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (tru)
            {
                int x = dataGridView1.CurrentCell.RowIndex;

                MtlUserName.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
                MtlName.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
                MtlPass.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
                MtlConfirmPass.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
                MtlEmail.Text = dataGridView1.Rows[x].Cells[4].Value.ToString();
            }
            tru = true;
        }
    }
}
