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
    public partial class Periodo : Form
    {
        string consulta;
        public Periodo()
        {
            InitializeComponent();
        }

        private void Periodo_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Limpiar();
        }

        private void MostrarDatos()
        {
            DataTable tabla = Conn.ejecutaConsultaSelect("SELECT idPeriod, name, duration, startDate, endDate FROM Period WHERE status = 1");
            dataGridView1.DataSource = tabla;
        }

        private void Limpiar()
        {
            MtlName.Clear();
            MtlDuration.Clear();
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string name = MtlName.Text;
            string duration = MtlDuration.Text;
            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
            string idUserCreate = UserCache.IdUser.ToString();
            string creationDate = DateTime.Today.ToString("yyyy-MM-dd");
            consulta = "INSERT INTO Period (name, duration, startDate, endDate, idUserCreate, creationDate) VALUES ('" + name + "', " + duration + ", '" + startDate + "', '" + endDate + "', " + idUserCreate + ", '" + creationDate + "')";
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string name = MtlName.Text;
            string duration = MtlDuration.Text;
            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
            string idUserModify = UserCache.IdUser.ToString();
            string modifiedDate = DateTime.Today.ToString("yyyy-MM-dd");
            int a = dataGridView1.CurrentCell.RowIndex;
            int idPeriod = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE Period SET name = '" + name + "', duration = " + duration + ", startDate = '" + startDate + "', endDate = '" + endDate + "', idUserModify = " + idUserModify + ", modifiedDate = '" + modifiedDate + "' WHERE idPeriod =  " + idPeriod;
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            int idPeriod = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE Period SET status = 0 WHERE idPeriod =  " + idPeriod;
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
                MtlDuration.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
                dtpStartDate.Value = DateTime.Parse(dataGridView1.Rows[x].Cells[3].Value.ToString());
                dtpEndDate.Value = DateTime.Parse(dataGridView1.Rows[x].Cells[4].Value.ToString());
            }
            tru = true;
        }
    }
}
