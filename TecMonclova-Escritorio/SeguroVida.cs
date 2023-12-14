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
    public partial class Seguro_Vida : Form
    {
        string consulta;
        public Seguro_Vida()
        {
            InitializeComponent();
        }

        private void Seguro_Vida_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Limpiar();
        }

        private void MostrarDatos()
        {
            DataTable tabla = Conn.ejecutaConsultaSelect("SELECT idLifeInsurance, policyNumber, insuranceCompany, startDate, endDate, beneficiary, deathCoverage, disabilityCoverage, insurancePayment, paymentPeriod FROM LifeInsurance WHERE status = 1");
            dataGridView1.DataSource = tabla;
        }

        private void Limpiar()
        {
            MtlPolicyNumber.Clear();
            MtlInsuranceCompany.Clear();
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            MtlBeneficiary.Clear();
            MtlDeathCoverage.Clear();
            MtlDisabilityCoverage.Clear();
            MtlInsurancePayment.Clear();
            MtlPaymentPeriod.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string policyNumber = MtlPolicyNumber.Text;
            string insuranceCompany = MtlInsuranceCompany.Text;
            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
            string beneficiary = MtlBeneficiary.Text;
            string deathCoverage = MtlDeathCoverage.Text;
            string disabilityCoverage = MtlDisabilityCoverage.Text;
            string insurancePayment = MtlInsurancePayment.Text;
            string paymentPeriod = MtlPaymentPeriod.Text;
            string idUserCreate = UserCache.IdUser.ToString();
            string creationDate = DateTime.Today.ToString("yyyy-MM-dd");
            consulta = "INSERT INTO LifeInsurance (idLifeInsurance, policyNumber, insuranceCompany, startDate, endDate, beneficiary, deathCoverage, disabilityCoverage, insurancePayment, paymentPeriod, idUserCreate, creationDate) VALUES('" + policyNumber + "', '" + insuranceCompany + "', '" + startDate + "', '" + endDate + "', '" + beneficiary + "', " + deathCoverage + ", " + disabilityCoverage + ", " + insurancePayment + ", " + paymentPeriod + ", " + idUserCreate + ", '" + creationDate + "')";
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string policyNumber = MtlPolicyNumber.Text;
            string insuranceCompany = MtlInsuranceCompany.Text;
            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
            string beneficiary = MtlBeneficiary.Text;
            string deathCoverage = MtlDeathCoverage.Text;
            string disabilityCoverage = MtlDisabilityCoverage.Text;
            string insurancePayment = MtlInsurancePayment.Text;
            string paymentPeriod = MtlPaymentPeriod.Text;
            string idUserModify = UserCache.IdUser.ToString();
            string modifiedDate = DateTime.Today.ToString("yyyy-MM-dd");
            int a = dataGridView1.CurrentCell.RowIndex;
            int idLifeInsurance = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE LifeInsurance SET policyNumber = '" + policyNumber + "', insuranceCompany = '" + insuranceCompany + "', startDate = '" + startDate + "', endDate = '" + endDate + "', beneficiary = '" + beneficiary + "', deathCoverage = " + deathCoverage + ", disabilityCoverage = " + disabilityCoverage + ", insurancePayment = " + insurancePayment + ", paymentPeriod = " + paymentPeriod + ", idUserModify = " + idUserModify + ", modifiedDate = '" + modifiedDate + "' WHERE idLifeInsurance = " + idLifeInsurance;
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            int idLifeInsurance = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE LifeInsurance SET status = 0 WHERE idLifeInsurance = " + idLifeInsurance;
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

                MtlPolicyNumber.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
                MtlInsuranceCompany.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
                dtpStartDate.Value = DateTime.Parse(dataGridView1.Rows[x].Cells[3].Value.ToString());
                dtpEndDate.Value = DateTime.Parse(dataGridView1.Rows[x].Cells[4].Value.ToString());
                MtlBeneficiary.Text = dataGridView1.Rows[x].Cells[5].Value.ToString();
                MtlDeathCoverage.Text = dataGridView1.Rows[x].Cells[6].Value.ToString();
                MtlDisabilityCoverage.Text = dataGridView1.Rows[x].Cells[7].Value.ToString();
                MtlInsurancePayment.Text = dataGridView1.Rows[x].Cells[5].Value.ToString();
                MtlPaymentPeriod.Text = dataGridView1.Rows[x].Cells[5].Value.ToString();
            }
            tru = true;
        }
    }
}
