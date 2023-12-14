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
    public partial class BecaExterna : Form
    {
        string consulta;
        public BecaExterna()
        {
            InitializeComponent();
        }

        private void BecaExterna_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Limpiar();
        }

        private void MostrarDatos()
        {
            DataTable tabla = Conn.ejecutaConsultaSelect("SELECT idExternalScholarship, scholarshipName, amount, paymentDate FROM [192.168.100.32].SchoolServicesMarisol.dbo.ExternalScholarship WHERE status = 1");
            dataGridView1.DataSource = tabla;
        }

        private void Limpiar()
        {
            MtlScholarshipName.Clear();
            MtlAmount.Clear();
            dtpPaymentDate.Value = DateTime.Today;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string scholarshipName = MtlScholarshipName.Text;
            string amount = MtlAmount.Text;
            string paymentDate = dtpPaymentDate.Value.ToString("yyyy-MM-dd");
            consulta = "INSERT INTO [192.168.100.32].SchoolServicesMarisol.dbo.ExternalScholarship  scholarshipName, amount, paymentDate, idUserCreate, creationDate) VALUES('" + scholarshipName + "', " + amount + ", '" + paymentDate + "' 1, '2023-12-13')";
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string scholarshipName = MtlScholarshipName.Text;
            string amount = MtlAmount.Text;
            string paymentDate = dtpPaymentDate.Value.ToString("yyyy-MM-dd");
            int a = dataGridView1.CurrentCell.RowIndex;
            int idExternalScholarship = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE [192.168.100.32].SchoolServicesMarisol.dbo.ExternalScholarship SET scholarshipName = '" + scholarshipName + "', amount = " + amount + ", paymentDate = '" + paymentDate + "' WHERE idExternalScholarship =  " + idExternalScholarship;
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            int idExternalScholarship = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE [192.168.100.32].SchoolServicesMarisol.dbo.ExternalScholarship SET status = 0 WHERE idExternalScholarship =  " + idExternalScholarship;
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

                MtlScholarshipName.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
                MtlAmount.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
                dtpPaymentDate.Value = DateTime.Parse(dataGridView1.Rows[x].Cells[3].Value.ToString());
            }
            tru = true;
        }
    }
}
