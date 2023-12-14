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
    public partial class Inscripcion : Form
    {
        string consulta;
        public Inscripcion()
        {
            InitializeComponent();
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Limpiar();

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
            DataTable tabla = Conn.ejecutaConsultaSelect("SELECT e.idEnrollment, e.numericalReference, e.totalPayment, e.matriculation, e.dueDate, e.semester, s.name AS Student, p.name AS Period FROM Enrollment e INNER JOIN [192.168.100.32].SchoolServicesMarisol.dbo.Student s ON e.idStudent = s.idStudent INNER JOIN Period p ON e.idPeriod = p.idPeriod WHERE e.status = 1");
            dataGridView1.DataSource = tabla;
        }

        private void Limpiar()
        {
            MtlNumericalReference.Clear();
            MtlTotalPayment.Clear();
            MtlMatriculation.Clear();
            dtpDueDate.Value = DateTime.Today;
            cbSemester.Text = "";
            cbStudent.Text = "";
            cbPeriod.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string numericalReference = MtlNumericalReference.Text;
            string totalPayment = MtlTotalPayment.Text;
            string matriculation = MtlMatriculation.Text;
            string dueDate = dtpDueDate.Value.ToString("yyyy-MM-dd");
            string semester = cbSemester.Text;
            string idUserCreate = UserCache.IdUser.ToString();
            string creationDate = DateTime.Today.ToString("yyyy-MM-dd");
            string[] x = cbStudent.Text.Split('-');
            string idStudent = x[0];
            x = cbPeriod.Text.Split('-');
            string idPeriod = x[0];
            consulta = "INSERT INTO Enrollment (numericalReference, totalPayment, matriculation, dueDate, semester, idStudent, idPeriod, idUserCreate, creationDate) VALUES (" + numericalReference + ", " + totalPayment + ", '" + matriculation + "', '" + dueDate + "', " + semester + ", " + idStudent + ", " + idUserCreate + ", '" + creationDate + "')";
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string numericalReference = MtlNumericalReference.Text;
            string totalPayment = MtlTotalPayment.Text;
            string matriculation = MtlMatriculation.Text;
            string dueDate = dtpDueDate.Value.ToString("yyyy-MM-dd");
            string semester = cbSemester.Text;
            string idUserModify = UserCache.IdUser.ToString();
            string modifiedDate = DateTime.Today.ToString("yyyy-MM-dd");
            string[] x = cbStudent.Text.Split('-');
            string idStudent = x[0];
            x = cbPeriod.Text.Split('-');
            string idPeriod = x[0];
            int a = dataGridView1.CurrentCell.RowIndex;
            int idEnrollment = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE Enrollment SET numericalReference = " + numericalReference + ", totalPayment = " + totalPayment + ", matriculation = '" + matriculation + "', dueDate = '" + dueDate + "', semester = " + semester + ", idStudent = " + idStudent + ", idPeriod = " + idPeriod + ", idUserModify = " + idUserModify + ", modifiedDate = '" + modifiedDate + "' WHERE idEnrollment = " + idEnrollment;
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            int idEnrollment = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE Enrollment SET status = 0 WHERE idEnrollment = " + idEnrollment;
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

                MtlNumericalReference.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
                MtlTotalPayment.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
                MtlMatriculation.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
                dtpDueDate.Value = DateTime.Parse(dataGridView1.Rows[x].Cells[4].Value.ToString());
                for (int i = 0; i < cbSemester.Items.Count; i++)
                {
                    string[] a = cbSemester.Items[i].ToString().Split('-');
                    if (dataGridView1.Rows[x].Cells[5].Value.ToString() == a[1])
                    {
                        cbSemester.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cbStudent.Items.Count; i++)
                {
                    string[] a = cbStudent.Items[i].ToString().Split('-');
                    if (dataGridView1.Rows[x].Cells[6].Value.ToString() == a[1])
                    {
                        cbStudent.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cbPeriod.Items.Count; i++)
                {
                    string[] a = cbPeriod.Items[i].ToString().Split('-');
                    if (dataGridView1.Rows[x].Cells[7].Value.ToString() == a[1])
                    {
                        cbPeriod.SelectedIndex = i;
                    }
                }
            }
            tru = true;
        }
    }
}
