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
    public partial class Alumno : Form
    {
        string consulta;
        public Alumno()
        {
            InitializeComponent();
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Limpiar();

            DataTable lifeInsuranceTable = Conn.ejecutaConsultaSelect("SELECT idLifeInsurance, insuranceCompany FROM LifeInsurance where status = 1");
            cbLifeInsurance.Items.Clear();

            foreach (DataRow row in lifeInsuranceTable.Rows)
            {
                string lifeInsuranceInfo = $"{row["idLifeInsurance"]}-{row["insuranceCompany"]}";
                cbLifeInsurance.Items.Add(lifeInsuranceInfo);
            }
            
            DataTable studyPlanTable = Conn.ejecutaConsultaSelect("SELECT idStudyPlan, name FROM [192.168.100.32].SchoolServicesMarisol.dbo.StudyPlan where status = 1");
            cbStudyPlan.Items.Clear();

            foreach (DataRow row in studyPlanTable.Rows)
            {
                string studyPlanInfo = $"{row["idStudyPlan"]}-{row["name"]}";
                cbStudyPlan.Items.Add(studyPlanInfo);
            }
        }

        private void MostrarDatos()
        {
            DataTable tabla = Conn.ejecutaConsultaSelect("SELECT s.idStudent, c.name As Career, s.registrationNumber, s.name, s.lastName, s.phoneNumber, s.email, s.address, s.curp, s.rfc, s.nss, l.insuranceCompany As [Life Insurance] FROM [192.168.100.32].SchoolServicesMarisol.dbo.Student s INNER JOIN [192.168.100.32].SchoolServicesMarisol.dbo.StudyPlan sp ON s.idStudyPlan = sp.idStudyPlan INNER JOIN [192.168.100.32].SchoolServicesMarisol.dbo.Career c ON sp.idCareer = c.idCareer INNER JOIN LifeInsurance l ON s.idLifeInsurance = l.idLifeInsurance WHERE s.status = 1");
            dataGridView1.DataSource = tabla;
        }

        private void Limpiar()
        {
            MtlRegistrationNumber.Clear();
            MtlName.Clear();
            MtlLastName.Clear();
            MtlPhone.Clear();
            MtlEmail.Clear();
            MtlAddress.Clear();
            MtlCURP.Clear();
            MtlRFC.Clear();
            MtlNSS.Clear();
            cbStudyPlan.Text = "";
            cbLifeInsurance.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string registrationNumber = MtlRegistrationNumber.Text;
            string name = MtlName.Text;
            string lastName = MtlLastName.Text;
            string phoneNumber = MtlPhone.Text;
            string email = MtlEmail.Text;
            string address = MtlAddress.Text;
            string curp = MtlCURP.Text;
            string rfc = MtlRFC.Text;
            string nss = MtlNSS.Text;
            string idUserCreate = UserCache.IdUser.ToString();
            string creationDate = DateTime.Today.ToString("yyyy-MM-dd");
            string[] x = cbStudyPlan.Text.Split('-');
            string idStudyPlan = x[0];
            x = cbLifeInsurance.Text.Split('-');
            string idLifeInsurance = x[0];
            consulta = "INSERT INTO [192.168.100.32].SchoolServicesMarisol.dbo.Student (idStudyPlan, registrationNumber, name, lastName, phoneNumber, email, address, curp, rfc, nss, idLifeInsurance, idUserCreate, creationDate) values(" + idStudyPlan + ", '" + registrationNumber + "', '" + name + "', '" + lastName + "', '" + phoneNumber + "', '" + email + "', '" + address + "', '" + curp + "', '" + rfc + "', '" + nss + "', " + idLifeInsurance + ", " + idUserCreate + ", '" + creationDate + "')";
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string registrationNumber = MtlRegistrationNumber.Text;
            string name = MtlName.Text;
            string lastName = MtlLastName.Text;
            string phoneNumber = MtlPhone.Text;
            string email = MtlEmail.Text;
            string address = MtlAddress.Text;
            string curp = MtlCURP.Text;
            string rfc = MtlRFC.Text;
            string nss = MtlNSS.Text;
            string idUserModify = UserCache.IdUser.ToString();
            string modifiedDate = DateTime.Today.ToString("yyyy-MM-dd");
            string[] x = cbStudyPlan.Text.Split('-');
            string idStudyPlan = x[0];
            x = cbStudyPlan.Text.Split('-');
            string idLifeInsurance = x[0];
            int a = dataGridView1.CurrentCell.RowIndex;
            int idStudent = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE [192.168.100.32].SchoolServicesMarisol.dbo.Student SET idStudyPlan = " + idStudyPlan + ", registrationNumber = '" + registrationNumber + "', name = '" + name + "', lastName = '" + lastName + "', phoneNumber = '" + phoneNumber + "', email ='" + email + "', address = '" + address + "', curp = '" + curp + "', rfc = '" + rfc + "', nss = '" + nss + "', idLifeInsurance = " + idLifeInsurance + ", idUserModify = " + idUserModify + ", modifiedDate = '" + modifiedDate + "' WHERE idStudent =  " + idStudent;
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            int idStudent = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE [192.168.100.32].SchoolServicesMarisol.dbo.Student SET Status = 0 WHERE idStudent =  " + idStudent; ;
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

                MtlRegistrationNumber.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
                MtlName.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
                MtlLastName.Text = dataGridView1.Rows[x].Cells[4].Value.ToString();
                MtlPhone.Text = dataGridView1.Rows[x].Cells[5].Value.ToString();
                MtlEmail.Text = dataGridView1.Rows[x].Cells[6].Value.ToString();
                MtlAddress.Text = dataGridView1.Rows[x].Cells[7].Value.ToString();
                MtlCURP.Text = dataGridView1.Rows[x].Cells[8].Value.ToString();
                MtlRFC.Text = dataGridView1.Rows[x].Cells[9].Value.ToString();
                MtlNSS.Text = dataGridView1.Rows[x].Cells[10].Value.ToString();
                for (int i = 0; i < cbStudyPlan.Items.Count; i++)
                {
                    string[] a = cbStudyPlan.Items[i].ToString().Split('-');
                    if (dataGridView1.Rows[x].Cells[1].Value.ToString() == a[1])
                    {
                        cbStudyPlan.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cbLifeInsurance.Items.Count; i++)
                {
                    string[] a = cbLifeInsurance.Items[i].ToString().Split('-');
                    if (dataGridView1.Rows[x].Cells[11].Value.ToString() == a[1])
                    {
                        cbLifeInsurance.SelectedIndex = i;
                    }
                }
            }
            tru = true;
        }
    }
}
