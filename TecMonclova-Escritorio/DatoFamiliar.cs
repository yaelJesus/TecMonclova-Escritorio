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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string name = MaterialName.Text;
            string lastName = MaterialLastName.Text;
            string relationship = MaterialRelationship.Text;
            string phoneNumber = MaterialPhone.Text;
            string email = MaterialEmail.Text;
            string address = MaterialAddress.Text;
            string[] x = cbStudent.Text.Split('-');
            string idStudent = x[0];
            consulta = "INSERT INTO FamilyData(name, lastName, relationship, phoneNumber, email, address, idStudent) values('" + name + "', '" + lastName + "', '" + relationship + "', '" + phoneNumber + "', '" + email + "', '" + address + "', '" + idStudent + "')";
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();

            MaterialName.Clear();
            MaterialLastName.Clear();
            MaterialRelationship.Clear();
            MaterialPhone.Clear();
            MaterialEmail.Clear();
            MaterialAddress.Clear();
            cbStudent.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string name = MaterialName.Text;
            string lastName = MaterialLastName.Text;
            string relationship = MaterialRelationship.Text;
            string phoneNumber = MaterialPhone.Text;
            string email = MaterialEmail.Text;
            string address = MaterialAddress.Text;
            string[] x = cbStudent.Text.Split('-');
            string idStudent = x[0];
            int a = dataGridView1.CurrentCell.RowIndex;
            int idFamilyData = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE FamilyData SET name = '" + name + "', lastName = '" + lastName + "',relationship = '" + relationship + "' ,phoneNumber = '" + phoneNumber + "',email = '" + email + "', address = '" + address + "', idStudent = '" + idStudent + "' WHERE idFamilyData = " + idFamilyData.ToString();
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();

            MaterialName.Clear();
            MaterialLastName.Clear();
            MaterialRelationship.Clear();
            MaterialPhone.Clear();
            MaterialEmail.Clear();
            MaterialAddress.Clear();
            cbStudent.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            int idFamilyData = (int)dataGridView1.Rows[a].Cells[0].Value;
            consulta = "UPDATE FamilyData SET Status = 0 WHERE idFamilyData =  " + idFamilyData.ToString(); ;
            Conn.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        bool tru = false;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (tru)
            {
                int x = dataGridView1.CurrentCell.RowIndex;

                MaterialName.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
                MaterialLastName.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
                MaterialRelationship.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
                MaterialPhone.Text = dataGridView1.Rows[x].Cells[5].Value.ToString();
                MaterialEmail.Text = dataGridView1.Rows[x].Cells[6].Value.ToString();
                MaterialAddress.Text = dataGridView1.Rows[x].Cells[7].Value.ToString();
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
