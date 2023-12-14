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
    public partial class DetallesBecaExterna : Form
    {
        string consulta;
        public DetallesBecaExterna()
        {
            InitializeComponent();
        }

        private void DetallesBecaExterna_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Limpiar();

            DataTable ExternalScholarshipTable = Conn.ejecutaConsultaSelect("SELECT idExternalScholarship, scholarshipName FROM ExternalScholarship where status = 1");
            cbExternalScholarship.Items.Clear();

            foreach (DataRow row in ExternalScholarshipTable.Rows)
            {
                string ExternalScholarshipInfo = $"{row["idExternalScholarship"]}-{row["scholarshipName"]}";
                cbExternalScholarship.Items.Add(ExternalScholarshipInfo);
            }

            DataTable studentTable = Conn.ejecutaConsultaSelect("SELECT idStudent, name FROM dbo.Student");
            cbStudent.Items.Clear();

            foreach (DataRow row in studentTable.Rows)
            {
                string studentInfo = $"{row["idStudent"]}-{row["name"]}";
                cbStudent.Items.Add(studentInfo);
            }
        }

        private void MostrarDatos()
        {
            DataTable tabla = Conn.ejecutaConsultaSelect("SELECT idExternalScholarshipDetails, idStudent, idExternalScholarship, institution, campus, major, semester FROM [192.168.100.32].SchoolServicesMarisol.dbo.ExternalScholarshipDetails WHERE status = 1");
            dataGridView1.DataSource = tabla;
        }

        private void Limpiar()
        {
            MtlInstitution.Clear();
            MtlCampus.Clear();
            MtlMajor.Clear();
            cbExternalScholarship.Text = "";
            cbSemester.Text = "";
            cbStudent.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string institution = MtlInstitution.Text;
            string campus = MtlCampus.Text;
            string major = MtlMajor.Text;
            string idUserCreate = UserCache.IdUser.ToString();
            string creationDate = DateTime.Today.ToString("yyyy-MM-dd");
            string[] x = cbExternalScholarship.Text.Split('-');
            string idExternalScholarship = x[0];
            x = cbStudent.Text.Split('-');
            string idStudent = x[0];
            string semester = cbSemester.Text;
            consulta = "INSERT INTO [192.168.100.32].SchoolServicesMarisol.dbo.ExternalScholarshipDetails (idStudent, idExternalScholarship, institution, campus, major, semester, idUserCreate, creationDate) VALUES(" + idStudent + ", " + idExternalScholarship + ", '" + institution + "', '" + campus + "', '" + major + "', " + semester + ", " + idUserCreate + ", '" + creationDate + "')";
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string institution = MtlInstitution.Text;
            string campus = MtlCampus.Text;
            string major = MtlMajor.Text;
            string idUserModify = UserCache.IdUser.ToString();
            string modifiedDate = DateTime.Today.ToString("yyyy-MM-dd");
            string[] x = cbExternalScholarship.Text.Split('-');
            string idExternalScholarship = x[0];
            x = cbStudent.Text.Split('-');
            string idStudent = x[0];
            string semester = cbSemester.Text;
            int a = dataGridView1.CurrentCell.RowIndex;
            int idExternalScholarshipDetails = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE [192.168.100.32].SchoolServicesMarisol.dbo.ExternalScholarshipDetails SET idStudent = " + idStudent + ", idExternalScholarship = " + idExternalScholarship + ", institution = '" + institution + "', campus = '" + campus + "', major = '" + major + "', semester = " + semester + ", idUserModify = " + idUserModify + ", modifiedDate = '" + modifiedDate + "' WHERE idExternalScholarshipDetails =  " + idExternalScholarshipDetails;
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            int idExternalScholarshipDetails = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE [192.168.100.32].SchoolServicesMarisol.dbo.ExternalScholarshipDetails SET status = 0 WHERE idExternalScholarshipDetails =  " + idExternalScholarshipDetails;
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

                MtlInstitution.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
                MtlCampus.Text = dataGridView1.Rows[x].Cells[4].Value.ToString();
                MtlMajor.Text = dataGridView1.Rows[x].Cells[5].Value.ToString();
                for (int i = 0; i < cbStudent.Items.Count; i++)
                {
                    string[] a = cbStudent.Items[i].ToString().Split('-');
                    if (dataGridView1.Rows[x].Cells[1].Value.ToString() == a[1])
                    {
                        cbStudent.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cbExternalScholarship.Items.Count; i++)
                {
                    string[] a = cbExternalScholarship.Items[i].ToString().Split('-');
                    if (dataGridView1.Rows[x].Cells[2].Value.ToString() == a[1])
                    {
                        cbExternalScholarship.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cbSemester.Items.Count; i++)
                {
                    string[] a = cbSemester.Items[i].ToString().Split('-');
                    if (dataGridView1.Rows[x].Cells[6].Value.ToString() == a[1])
                    {
                        cbSemester.SelectedIndex = i;
                    }
                }
            }
            tru = true;
        }
    }
}
