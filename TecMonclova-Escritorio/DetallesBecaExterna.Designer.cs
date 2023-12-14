
namespace TecMonclova_Escritorio
{
    partial class DetallesBecaExterna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbExternalScholarship = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.MtlMajor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.MtlCampus = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.MtlInstitution = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbExternalScholarship
            // 
            this.cbExternalScholarship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbExternalScholarship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExternalScholarship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbExternalScholarship.FormattingEnabled = true;
            this.cbExternalScholarship.Location = new System.Drawing.Point(155, 17);
            this.cbExternalScholarship.Name = "cbExternalScholarship";
            this.cbExternalScholarship.Size = new System.Drawing.Size(345, 21);
            this.cbExternalScholarship.TabIndex = 258;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 257;
            this.label1.Text = "External Scholarship";
            // 
            // cbStudent
            // 
            this.cbStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(576, 17);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(151, 21);
            this.cbStudent.TabIndex = 254;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(518, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 253;
            this.label8.Text = "Student";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(213, 128);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(91, 30);
            this.btnEliminar.TabIndex = 252;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(114, 128);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(91, 30);
            this.btnModificar.TabIndex = 251;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(15, 128);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(91, 30);
            this.btnAgregar.TabIndex = 250;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 207);
            this.dataGridView1.TabIndex = 248;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 118);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(766, 51);
            this.materialDivider2.TabIndex = 249;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // MtlMajor
            // 
            this.MtlMajor.BackColor = System.Drawing.Color.White;
            this.MtlMajor.Depth = 0;
            this.MtlMajor.Hint = "";
            this.MtlMajor.Location = new System.Drawing.Point(192, 87);
            this.MtlMajor.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlMajor.Name = "MtlMajor";
            this.MtlMajor.PasswordChar = '\0';
            this.MtlMajor.SelectedText = "";
            this.MtlMajor.SelectionLength = 0;
            this.MtlMajor.SelectionStart = 0;
            this.MtlMajor.Size = new System.Drawing.Size(247, 23);
            this.MtlMajor.TabIndex = 270;
            this.MtlMajor.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 269;
            this.label2.Text = "Major";
            // 
            // MtlCampus
            // 
            this.MtlCampus.BackColor = System.Drawing.Color.White;
            this.MtlCampus.Depth = 0;
            this.MtlCampus.Hint = "";
            this.MtlCampus.Location = new System.Drawing.Point(548, 50);
            this.MtlCampus.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlCampus.Name = "MtlCampus";
            this.MtlCampus.PasswordChar = '\0';
            this.MtlCampus.SelectedText = "";
            this.MtlCampus.SelectionLength = 0;
            this.MtlCampus.SelectionStart = 0;
            this.MtlCampus.Size = new System.Drawing.Size(136, 23);
            this.MtlCampus.TabIndex = 268;
            this.MtlCampus.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 267;
            this.label3.Text = "Campus";
            // 
            // MtlInstitution
            // 
            this.MtlInstitution.BackColor = System.Drawing.Color.White;
            this.MtlInstitution.Depth = 0;
            this.MtlInstitution.Hint = "";
            this.MtlInstitution.Location = new System.Drawing.Point(143, 50);
            this.MtlInstitution.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlInstitution.Name = "MtlInstitution";
            this.MtlInstitution.PasswordChar = '\0';
            this.MtlInstitution.SelectedText = "";
            this.MtlInstitution.SelectionLength = 0;
            this.MtlInstitution.SelectionStart = 0;
            this.MtlInstitution.Size = new System.Drawing.Size(339, 23);
            this.MtlInstitution.TabIndex = 266;
            this.MtlInstitution.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 265;
            this.label4.Text = "Institution";
            // 
            // cbSemester
            // 
            this.cbSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbSemester.DisplayMember = "1";
            this.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbSemester.Location = new System.Drawing.Point(548, 89);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(54, 21);
            this.cbSemester.TabIndex = 272;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 271;
            this.label6.Text = "Semester";
            // 
            // DetallesBecaExterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 400);
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MtlMajor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MtlCampus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MtlInstitution);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbExternalScholarship);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStudent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialDivider2);
            this.Name = "DetallesBecaExterna";
            this.Text = "Detalles de Beca Externa";
            this.Load += new System.EventHandler(this.DetallesBecaExterna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbExternalScholarship;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlMajor;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlCampus;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlInstitution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.Label label6;
    }
}