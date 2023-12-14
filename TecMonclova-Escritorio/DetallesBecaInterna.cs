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
    public partial class BecaInterna_Detalles : Form
    {
        string consulta;
        public BecaInterna_Detalles()
        {
            InitializeComponent();
        }

        private void BecaInterna_Detalles_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Limpiar();

            DataTable InstitutionalScholarshipTable = Conn.ejecutaConsultaSelect("SELECT idInstitutionalScholarship, name FROM [192.168.100.32].SchoolServicesMarisol.dbo.InstitutionalScholarship where status = 1");
            cbInstitutionalScholarship.Items.Clear();

            foreach (DataRow row in InstitutionalScholarshipTable.Rows)
            {
                string InstitutionalScholarshipInfo = $"{row["idInstitutionalScholarship"]}-{row["name"]}";
                cbInstitutionalScholarship.Items.Add(InstitutionalScholarshipInfo);
            }

            DataTable studentTable = Conn.ejecutaConsultaSelect("SELECT idStudent, name FROM [192.168.100.32].SchoolServicesMarisol.dbo.Student");
            cbStudent.Items.Clear();

            foreach (DataRow row in studentTable.Rows)
            {
                string studentInfo = $"{row["idStudent"]}-{row["name"]}";
                cbStudent.Items.Add(studentInfo);
            }
        }

        private void MostrarDatos()
        {
            DataTable tabla = Conn.ejecutaConsultaSelect("SELECT isd.idInternalScholarshipDetails, isp.name AS [Institutional Scholarship], s.name AS Student, isd.semester FROM [192.168.100.32].SchoolServicesMarisol.dbo.InternalScholarshipDetails isd INNER JOIN [192.168.100.32].SchoolServicesMarisol.dbo.Student s ON isd.idStudent = s.idStudent INNER JOIN [192.168.100.32].SchoolServicesMarisol.dbo.InstitutionalScholarship isp ON isd.idInstitutionalScholarship = isp.idInstitutionalScholarship WHERE isd.status = 1");
            dataGridView1.DataSource = tabla;
        }

        private void Limpiar()
        {
            cbInstitutionalScholarship.Text = "";
            cbSemester.Text = "";
            cbStudent.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idUserCreate = UserCache.IdUser.ToString();
            string creationDate = DateTime.Today.ToString("yyyy-MM-dd");
            string[] x = cbInstitutionalScholarship.Text.Split('-');
            string idInstitutionalScholarship = x[0];
            x = cbStudent.Text.Split('-');
            string idStudent = x[0];
            string semester = cbSemester.Text;
            consulta = "INSERT INTO [192.168.100.32].SchoolServicesMarisol.dbo.InternalScholarshipDetails  idInstitutionalScholarship, idStudent, semester, idUserCreate, creationDate) VALUES(" + idInstitutionalScholarship + ", " + idStudent + ", " + semester + ", " + idUserCreate + ", '" + creationDate + "')";
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string idUserModify = UserCache.IdUser.ToString();
            string modifiedDate = DateTime.Today.ToString("yyyy-MM-dd");
            string[] x = cbStudent.Text.Split('-');
            string idInstitutionalScholarship = x[0];
            x = cbStudent.Text.Split('-');
            string idStudent = x[0];
            string semester = cbSemester.Text;
            int a = dataGridView1.CurrentCell.RowIndex;
            int idInternalScholarshipDetails = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE [192.168.100.32].SchoolServicesMarisol.dbo.InternalScholarshipDetails SET idInstitutionalScholarship = " + idInstitutionalScholarship + ", idStudent = " + idStudent + ", semester = " + semester + ", idUserModify = " + idUserModify + ", modifiedDate = '" + modifiedDate + "' WHERE idInternalScholarshipDetails =  " + idInternalScholarshipDetails;
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            int idInternalScholarshipDetails = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE [192.168.100.32].SchoolServicesMarisol.dbo.InternalScholarshipDetails SET status = 0 WHERE idInternalScholarshipDetails =  " + idInternalScholarshipDetails;
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

                for (int i = 0; i < cbInstitutionalScholarship.Items.Count; i++)
                {
                    string[] a = cbInstitutionalScholarship.Items[i].ToString().Split('-');
                    if (dataGridView1.Rows[x].Cells[1].Value.ToString() == a[1])
                    {
                        cbInstitutionalScholarship.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cbStudent.Items.Count; i++)
                {
                    string[] a = cbStudent.Items[i].ToString().Split('-');
                    if (dataGridView1.Rows[x].Cells[2].Value.ToString() == a[1])
                    {
                        cbStudent.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cbSemester.Items.Count; i++)
                {
                    string[] a = cbSemester.Items[i].ToString().Split('-');
                    if (dataGridView1.Rows[x].Cells[3].Value.ToString() == a[0])
                    {
                        cbSemester.SelectedIndex = i;
                    }
                }
            }
            tru = true;
        }
    }
}
