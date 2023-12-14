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
    public partial class DatoFamiliar : Form
    {
        String consulta;
        public DatoFamiliar()
        {
            InitializeComponent();
        }

        private void DatoFamiliar_Load(object sender, EventArgs e)
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
            DataTable tabla = Conn.ejecutaConsultaSelect("SELECT f.idFamilyData, f.name, f.lastName, f.relationship, s.name as Student, f.phoneNumber, f.email, f.address from FamilyData f inner join Student s on f.idStudent = s.idStudent WHERE f.status = 1");
            dataGridView1.DataSource = tabla;
        }

        private void Limpiar()
        {
            MtlName.Clear();
            MtlLastName.Clear();
            MtlRelationship.Clear();
            MtlPhone.Clear();
            MtlEmail.Clear();
            MtlAddress.Clear();
            cbStudent.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string name = MtlName.Text;
            string lastName = MtlLastName.Text;
            string relationship = MtlRelationship.Text;
            string phoneNumber = MtlPhone.Text;
            string email = MtlEmail.Text;
            string address = MtlAddress.Text;
            string idUserCreate = UserCache.IdUser.ToString();
            string creationDate = DateTime.Today.ToString("yyyy-MM-dd");
            string[] x = cbStudent.Text.Split('-');
            string idStudent = x[0];
            consulta = "INSERT INTO FamilyData(name, lastName, relationship, phoneNumber, email, address, idStudent, idUserCreate, creationDate) values('" + name + "', '" + lastName + "', '" + relationship + "', '" + phoneNumber + "', '" + email + "', '" + address + "', " + idStudent + ", " + idUserCreate + ", '" + creationDate + "')";
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string name = MtlName.Text;
            string lastName = MtlLastName.Text;
            string relationship = MtlRelationship.Text;
            string phoneNumber = MtlPhone.Text;
            string email = MtlEmail.Text;
            string address = MtlAddress.Text;
            string idUserModify = UserCache.IdUser.ToString();
            string modifiedDate = DateTime.Today.ToString("yyyy-MM-dd");
            string[] x = cbStudent.Text.Split('-');
            string idStudent = x[0];
            int a = dataGridView1.CurrentCell.RowIndex;
            int idFamilyData = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE FamilyData SET name = '" + name + "', lastName = '" + lastName + "',relationship = '" + relationship + "' ,phoneNumber = '" + phoneNumber + "',email = '" + email + "', address = '" + address + "', idStudent = " + idStudent + ", idUserModify = " + idUserModify + ", modifiedDate = '" + modifiedDate + "' WHERE idFamilyData = " + idFamilyData;
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            int idFamilyData = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE FamilyData SET Status = 0 WHERE idFamilyData =  " + idFamilyData;
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
                MtlLastName.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
                MtlRelationship.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
                MtlPhone.Text = dataGridView1.Rows[x].Cells[5].Value.ToString();
                MtlEmail.Text = dataGridView1.Rows[x].Cells[6].Value.ToString();
                MtlAddress.Text = dataGridView1.Rows[x].Cells[7].Value.ToString();
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
