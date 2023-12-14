
namespace TecMonclova_Escritorio
{
    partial class Alumno
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbLifeInsurance = new System.Windows.Forms.ComboBox();
            this.MtlPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.MtlEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MtlAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MtlRegistrationNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MtlLastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MtlName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.MtlCURP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.MtlRFC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label9 = new System.Windows.Forms.Label();
            this.MtlNSS = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label10 = new System.Windows.Forms.Label();
            this.cbStudyPlan = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 207);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(213, 140);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(91, 30);
            this.btnEliminar.TabIndex = 175;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(114, 140);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(91, 30);
            this.btnModificar.TabIndex = 174;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(15, 140);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(91, 30);
            this.btnAgregar.TabIndex = 173;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbLifeInsurance
            // 
            this.cbLifeInsurance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbLifeInsurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLifeInsurance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLifeInsurance.FormattingEnabled = true;
            this.cbLifeInsurance.Location = new System.Drawing.Point(543, 70);
            this.cbLifeInsurance.Name = "cbLifeInsurance";
            this.cbLifeInsurance.Size = new System.Drawing.Size(151, 21);
            this.cbLifeInsurance.TabIndex = 172;
            // 
            // MtlPhone
            // 
            this.MtlPhone.BackColor = System.Drawing.Color.White;
            this.MtlPhone.Depth = 0;
            this.MtlPhone.Hint = "";
            this.MtlPhone.Location = new System.Drawing.Point(87, 41);
            this.MtlPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlPhone.Name = "MtlPhone";
            this.MtlPhone.PasswordChar = '\0';
            this.MtlPhone.SelectedText = "";
            this.MtlPhone.SelectionLength = 0;
            this.MtlPhone.SelectionStart = 0;
            this.MtlPhone.Size = new System.Drawing.Size(151, 23);
            this.MtlPhone.TabIndex = 171;
            this.MtlPhone.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 170;
            this.label5.Text = "Phone";
            // 
            // MtlEmail
            // 
            this.MtlEmail.BackColor = System.Drawing.Color.White;
            this.MtlEmail.Depth = 0;
            this.MtlEmail.Hint = "";
            this.MtlEmail.Location = new System.Drawing.Point(295, 41);
            this.MtlEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlEmail.Name = "MtlEmail";
            this.MtlEmail.PasswordChar = '\0';
            this.MtlEmail.SelectedText = "";
            this.MtlEmail.SelectionLength = 0;
            this.MtlEmail.SelectionStart = 0;
            this.MtlEmail.Size = new System.Drawing.Size(185, 23);
            this.MtlEmail.TabIndex = 169;
            this.MtlEmail.UseSystemPasswordChar = false;
            // 
            // MtlAddress
            // 
            this.MtlAddress.BackColor = System.Drawing.Color.White;
            this.MtlAddress.Depth = 0;
            this.MtlAddress.Hint = "";
            this.MtlAddress.Location = new System.Drawing.Point(79, 97);
            this.MtlAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlAddress.Name = "MtlAddress";
            this.MtlAddress.PasswordChar = '\0';
            this.MtlAddress.SelectedText = "";
            this.MtlAddress.SelectionLength = 0;
            this.MtlAddress.SelectionStart = 0;
            this.MtlAddress.Size = new System.Drawing.Size(458, 23);
            this.MtlAddress.TabIndex = 168;
            this.MtlAddress.UseSystemPasswordChar = false;
            // 
            // MtlRegistrationNumber
            // 
            this.MtlRegistrationNumber.BackColor = System.Drawing.Color.White;
            this.MtlRegistrationNumber.Depth = 0;
            this.MtlRegistrationNumber.Hint = "";
            this.MtlRegistrationNumber.Location = new System.Drawing.Point(138, 12);
            this.MtlRegistrationNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlRegistrationNumber.Name = "MtlRegistrationNumber";
            this.MtlRegistrationNumber.PasswordChar = '\0';
            this.MtlRegistrationNumber.SelectedText = "";
            this.MtlRegistrationNumber.SelectionLength = 0;
            this.MtlRegistrationNumber.SelectionStart = 0;
            this.MtlRegistrationNumber.Size = new System.Drawing.Size(116, 23);
            this.MtlRegistrationNumber.TabIndex = 167;
            this.MtlRegistrationNumber.UseSystemPasswordChar = false;
            // 
            // MtlLastName
            // 
            this.MtlLastName.BackColor = System.Drawing.Color.White;
            this.MtlLastName.Depth = 0;
            this.MtlLastName.Hint = "";
            this.MtlLastName.Location = new System.Drawing.Point(576, 12);
            this.MtlLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlLastName.Name = "MtlLastName";
            this.MtlLastName.PasswordChar = '\0';
            this.MtlLastName.SelectedText = "";
            this.MtlLastName.SelectionLength = 0;
            this.MtlLastName.SelectionStart = 0;
            this.MtlLastName.Size = new System.Drawing.Size(179, 23);
            this.MtlLastName.TabIndex = 166;
            this.MtlLastName.UseSystemPasswordChar = false;
            // 
            // MtlName
            // 
            this.MtlName.BackColor = System.Drawing.Color.White;
            this.MtlName.Depth = 0;
            this.MtlName.Hint = "";
            this.MtlName.Location = new System.Drawing.Point(310, 12);
            this.MtlName.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlName.Name = "MtlName";
            this.MtlName.PasswordChar = '\0';
            this.MtlName.SelectedText = "";
            this.MtlName.SelectionLength = 0;
            this.MtlName.SelectionStart = 0;
            this.MtlName.Size = new System.Drawing.Size(186, 23);
            this.MtlName.TabIndex = 165;
            this.MtlName.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 164;
            this.label8.Text = "Life Insurance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 163;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 162;
            this.label7.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 161;
            this.label4.Text = "Registration Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 160;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 159;
            this.label2.Text = "Name";
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 130);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(766, 51);
            this.materialDivider2.TabIndex = 158;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // MtlCURP
            // 
            this.MtlCURP.BackColor = System.Drawing.Color.White;
            this.MtlCURP.Depth = 0;
            this.MtlCURP.Hint = "";
            this.MtlCURP.Location = new System.Drawing.Point(531, 41);
            this.MtlCURP.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlCURP.Name = "MtlCURP";
            this.MtlCURP.PasswordChar = '\0';
            this.MtlCURP.SelectedText = "";
            this.MtlCURP.SelectionLength = 0;
            this.MtlCURP.SelectionStart = 0;
            this.MtlCURP.Size = new System.Drawing.Size(194, 23);
            this.MtlCURP.TabIndex = 179;
            this.MtlCURP.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 178;
            this.label1.Text = "CURP";
            // 
            // MtlRFC
            // 
            this.MtlRFC.BackColor = System.Drawing.Color.White;
            this.MtlRFC.Depth = 0;
            this.MtlRFC.Hint = "";
            this.MtlRFC.Location = new System.Drawing.Point(124, 68);
            this.MtlRFC.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlRFC.Name = "MtlRFC";
            this.MtlRFC.PasswordChar = '\0';
            this.MtlRFC.SelectedText = "";
            this.MtlRFC.SelectionLength = 0;
            this.MtlRFC.SelectionStart = 0;
            this.MtlRFC.Size = new System.Drawing.Size(136, 23);
            this.MtlRFC.TabIndex = 177;
            this.MtlRFC.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(87, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 176;
            this.label9.Text = "RFC";
            // 
            // MtlNSS
            // 
            this.MtlNSS.BackColor = System.Drawing.Color.White;
            this.MtlNSS.Depth = 0;
            this.MtlNSS.Hint = "";
            this.MtlNSS.Location = new System.Drawing.Point(307, 68);
            this.MtlNSS.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlNSS.Name = "MtlNSS";
            this.MtlNSS.PasswordChar = '\0';
            this.MtlNSS.SelectedText = "";
            this.MtlNSS.SelectionLength = 0;
            this.MtlNSS.SelectionStart = 0;
            this.MtlNSS.Size = new System.Drawing.Size(136, 23);
            this.MtlNSS.TabIndex = 181;
            this.MtlNSS.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(269, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 16);
            this.label10.TabIndex = 180;
            this.label10.Text = "NSS";
            // 
            // cbStudyPlan
            // 
            this.cbStudyPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbStudyPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudyPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStudyPlan.FormattingEnabled = true;
            this.cbStudyPlan.Location = new System.Drawing.Point(596, 99);
            this.cbStudyPlan.Name = "cbStudyPlan";
            this.cbStudyPlan.Size = new System.Drawing.Size(151, 21);
            this.cbStudyPlan.TabIndex = 183;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(543, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 182;
            this.label11.Text = "Career";
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 400);
            this.Controls.Add(this.cbStudyPlan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MtlNSS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MtlCURP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MtlRFC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbLifeInsurance);
            this.Controls.Add(this.MtlPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MtlEmail);
            this.Controls.Add(this.MtlAddress);
            this.Controls.Add(this.MtlRegistrationNumber);
            this.Controls.Add(this.MtlLastName);
            this.Controls.Add(this.MtlName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Alumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private System.Windows.Forms.ComboBox cbLifeInsurance;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlPhone;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlRegistrationNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlLastName;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlCURP;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlRFC;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlNSS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbStudyPlan;
        private System.Windows.Forms.Label label11;
    }
}