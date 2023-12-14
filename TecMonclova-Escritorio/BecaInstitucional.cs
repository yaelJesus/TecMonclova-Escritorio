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
    public partial class BecaInstitucional : Form
    {
        string consulta;
        public BecaInstitucional()
        {
            InitializeComponent();
        }

        private void BecaInstitucional_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Limpiar();
        }

        private void MostrarDatos()
        {
            DataTable tabla = Conn.ejecutaConsultaSelect("SELECT idInstitutionalScholarship, name, percentage, requirements FROM [192.168.100.32].SchoolServicesMarisol.dbo.InstitutionalScholarship WHERE status = 1");
            dataGridView1.DataSource = tabla;
        }

        private void Limpiar()
        {
            MtlName.Clear();
            MtlPercentage.Clear();
            MtlRequirements.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string name = MtlName.Text;
            string percentage = MtlPercentage.Text;
            string requirements = MtlRequirements.Text;
            string idUserCreate = UserCache.IdUser.ToString();
            string creationDate = DateTime.Today.ToString("yyyy-MM-dd");
            consulta = "INSERT INTO [192.168.100.32].SchoolServicesMarisol.dbo.InstitutionalScholarship  name, percentage, requirements, idUserCreate, creationDate) VALUES('" + name + "', '" + percentage + "', '" + requirements + "', " + idUserCreate + ", '" + creationDate + "')";
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string name = MtlName.Text;
            string percentage = MtlPercentage.Text;
            string requirements = MtlRequirements.Text;
            string idUserModify = UserCache.IdUser.ToString();
            string modifiedDate = DateTime.Today.ToString("yyyy-MM-dd");
            int a = dataGridView1.CurrentCell.RowIndex;
            int idInstitutionalScholarship = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE [192.168.100.32].SchoolServicesMarisol.dbo.InstitutionalScholarship SET name = '" + name + "', percentage = '" + percentage + "', requirements = '" + requirements + "', idUserModify = " + idUserModify + ", modifiedDate = '" + modifiedDate + "' WHERE idInstitutionalScholarship =  " + idInstitutionalScholarship;
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            int idInstitutionalScholarship = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE [192.168.100.32].SchoolServicesMarisol.dbo.InstitutionalScholarship SET status = 0 WHERE idInstitutionalScholarship =  " + idInstitutionalScholarship;
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

                MtlName.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
                MtlPercentage.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
                MtlRequirements.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
            }
            tru = true;
        }
    }
}
