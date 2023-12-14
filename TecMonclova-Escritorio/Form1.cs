using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace TecMonclova_Escritorio
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton ActualBoton;
        private Panel BordeIzquierdoBoton;
        private Form ActualFormHijo;
        public Form1()
        {
            InitializeComponent();
            BordeIzquierdoBoton = new Panel();
            BordeIzquierdoBoton.Size = new Size(7, 36);
            panelMenu.Controls.Add(BordeIzquierdoBoton);
            //Formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Estrucutura
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(37, 36, 81);
        }

        //Metodos
        private void ActivarBoton(object RemitenteBoton, Color color)
        {
            if (RemitenteBoton != null)
            {
                DeshabilitarBoton();
                //Boton
                ActualBoton = (IconButton)RemitenteBoton;
                ActualBoton.BackColor = Color.DarkGray;
                ActualBoton.ForeColor = color;
                ActualBoton.TextAlign = ContentAlignment.MiddleCenter;
                ActualBoton.IconColor = color;
                ActualBoton.TextImageRelation = TextImageRelation.TextBeforeImage;
                ActualBoton.ImageAlign = ContentAlignment.MiddleCenter;
                //Borde del boton izquierdo
                BordeIzquierdoBoton.BackColor = color;
                BordeIzquierdoBoton.Location = new Point(0, ActualBoton.Location.Y);
                BordeIzquierdoBoton.Visible = true;
                BordeIzquierdoBoton.BringToFront();
                //Icono Formulario Hijo Actual
                IconoFHijoActual.IconChar = ActualBoton.IconChar;
                IconoFHijoActual.IconColor = color;
            }
        }
        private void DeshabilitarBoton()
        { 
            if (ActualBoton != null)
            {
                ActualBoton.BackColor = Color.LightGray;
                ActualBoton.ForeColor = Color.DimGray;
                ActualBoton.TextAlign = ContentAlignment.MiddleLeft;
                ActualBoton.IconColor = Color.DimGray;
                ActualBoton.TextImageRelation = TextImageRelation.ImageBeforeText;
                ActualBoton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        
        }

        private void AbrirFormularioHijo(Form FormHijo)
        {
            if (ActualFormHijo != null)
            {
                ActualFormHijo.Close();
            }
            ActualFormHijo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(FormHijo);
            panelEscritorio.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
            lblInicio.Text = FormHijo.Text;
        }
        private void btnAlumno_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new Alumno());
        }

        private void btnBecaExterna_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new BecaExterna());
        }

        private void btnBecaInstitucional_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new BecaInstitucional());
        }

        private void btnDatoFamiliar_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new DatoFamiliar());
        }

        private void btnDetalleBecaExterna_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new DetallesBecaExterna());
        }

        private void btnDetalleBecaInterna_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new BecaInterna_Detalles());
        }

        private void btnEducacion_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new Educacion());
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new Inscripcion());
        }

        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new Periodo());
        }

        private void btnSeguroVida_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new Seguro_Vida());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new Usuario());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActualFormHijo.Close();
            Reiniciar();
        }

        private void Reiniciar()
        {
            DeshabilitarBoton();
            BordeIzquierdoBoton.Visible = false;
            IconoFHijoActual.IconChar = IconChar.Home;
            IconoFHijoActual.IconColor = Color.FromArgb(30, 29, 80);
            lblInicio.Text = "Home";
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnInicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            ActualFormHijo.Close();
            Reiniciar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
