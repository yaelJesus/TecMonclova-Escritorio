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
    public partial class Educacion : Form
    {
        string consulta;
        public Educacion()
        {
            InitializeComponent();
        }

        private void Educacion_Load(object sender, EventArgs e)
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
            DataTable tabla = Conn.ejecutaConsultaSelect("SELECT e.idEducation, e.educationLevel, e.startDate, e.endDate, s.name AS Student FROM Education e INNER JOIN [192.168.100.32].SchoolServicesMarisol.dbo.Student s ON e.idStudent = s.idStudent WHERE e.status = 1");
            dataGridView1.DataSource = tabla;
        }

        private void Limpiar()
        {
            MtlEducationLevel.Clear();
            cbStudent.Text = "";
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string educationLevel = MtlEducationLevel.Text;
            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
            string[] x = cbStudent.Text.Split('-');
            string idStudent = x[0];
            consulta = "INSERT INTO Period (educationLevel, startDate, endDate, idStudent, idUserCreate, creationDate) VALUES ('" + educationLevel + "', '" + startDate + "', '" + endDate + "', " + idStudent + ", 1, '2023-10-23')";
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string educationLevel = MtlEducationLevel.Text;
            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
            string[] x = cbStudent.Text.Split('-');
            string idStudent = x[0];
            int a = dataGridView1.CurrentCell.RowIndex;
            int idEducation = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE Education SET educationLevel = '" + educationLevel + "', startDate = '" + startDate + "', endDate = '" + endDate + "', idStudent = " + idStudent + " WHERE idEducation = " + idEducation;
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            int idEducation = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE Education SET status = 0 WHERE idEducation = " + idEducation;
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

                MtlEducationLevel.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
                dtpStartDate.Value = DateTime.Parse(dataGridView1.Rows[x].Cells[2].Value.ToString());
                dtpEndDate.Value = DateTime.Parse(dataGridView1.Rows[x].Cells[3].Value.ToString());
                for (int i = 0; i < cbStudent.Items.Count; i++)
                {
                    string[] a = cbStudent.Items[i].ToString().Split('-');
                    if (dataGridView1.Rows[x].Cells[4].Value.ToString() == a[1])
                    {
                        cbStudent.SelectedIndex = i;
                    }
                }
            }
            tru = true;
        }
    }
}
