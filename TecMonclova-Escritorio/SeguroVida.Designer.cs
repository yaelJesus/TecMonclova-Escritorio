
namespace TecMonclova_Escritorio
{
    partial class Seguro_Vida
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
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.MtlInsuranceCompany = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MtlPolicyNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.MtlBeneficiary = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MtlDeathCoverage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MtlDisabilityCoverage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MtlInsurancePayment = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.MtlPaymentPeriod = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(116, 59);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(101, 20);
            this.dtpEndDate.TabIndex = 198;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(213, 133);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(91, 30);
            this.btnEliminar.TabIndex = 195;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(114, 133);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(91, 30);
            this.btnModificar.TabIndex = 194;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(15, 133);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(91, 30);
            this.btnAgregar.TabIndex = 193;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 191;
            this.label5.Text = "End Date";
            // 
            // MtlInsuranceCompany
            // 
            this.MtlInsuranceCompany.BackColor = System.Drawing.Color.White;
            this.MtlInsuranceCompany.Depth = 0;
            this.MtlInsuranceCompany.Hint = "";
            this.MtlInsuranceCompany.Location = new System.Drawing.Point(418, 19);
            this.MtlInsuranceCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlInsuranceCompany.Name = "MtlInsuranceCompany";
            this.MtlInsuranceCompany.PasswordChar = '\0';
            this.MtlInsuranceCompany.SelectedText = "";
            this.MtlInsuranceCompany.SelectionLength = 0;
            this.MtlInsuranceCompany.SelectionStart = 0;
            this.MtlInsuranceCompany.Size = new System.Drawing.Size(111, 23);
            this.MtlInsuranceCompany.TabIndex = 189;
            this.MtlInsuranceCompany.UseSystemPasswordChar = false;
            // 
            // MtlPolicyNumber
            // 
            this.MtlPolicyNumber.BackColor = System.Drawing.Color.White;
            this.MtlPolicyNumber.Depth = 0;
            this.MtlPolicyNumber.Hint = "";
            this.MtlPolicyNumber.Location = new System.Drawing.Point(146, 19);
            this.MtlPolicyNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlPolicyNumber.Name = "MtlPolicyNumber";
            this.MtlPolicyNumber.PasswordChar = '\0';
            this.MtlPolicyNumber.SelectedText = "";
            this.MtlPolicyNumber.SelectionLength = 0;
            this.MtlPolicyNumber.SelectionStart = 0;
            this.MtlPolicyNumber.Size = new System.Drawing.Size(139, 23);
            this.MtlPolicyNumber.TabIndex = 188;
            this.MtlPolicyNumber.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(484, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 187;
            this.label8.Text = "Death Coverage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 186;
            this.label6.Text = "Beneficiary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 185;
            this.label7.Text = "Disability Coverage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 184;
            this.label4.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 183;
            this.label3.Text = "Insurance Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 182;
            this.label2.Text = "Policy Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 207);
            this.dataGridView1.TabIndex = 180;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 123);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(766, 51);
            this.materialDivider2.TabIndex = 181;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(607, 22);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(101, 20);
            this.dtpStartDate.TabIndex = 199;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label9.Location = new System.Drawing.Point(518, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 201;
            this.label9.Text = "Payment Period";
            // 
            // MtlBeneficiary
            // 
            this.MtlBeneficiary.BackColor = System.Drawing.Color.White;
            this.MtlBeneficiary.Depth = 0;
            this.MtlBeneficiary.Hint = "";
            this.MtlBeneficiary.Location = new System.Drawing.Point(299, 56);
            this.MtlBeneficiary.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlBeneficiary.Name = "MtlBeneficiary";
            this.MtlBeneficiary.PasswordChar = '\0';
            this.MtlBeneficiary.SelectedText = "";
            this.MtlBeneficiary.SelectionLength = 0;
            this.MtlBeneficiary.SelectionStart = 0;
            this.MtlBeneficiary.Size = new System.Drawing.Size(179, 23);
            this.MtlBeneficiary.TabIndex = 202;
            this.MtlBeneficiary.UseSystemPasswordChar = false;
            // 
            // MtlDeathCoverage
            // 
            this.MtlDeathCoverage.BackColor = System.Drawing.Color.White;
            this.MtlDeathCoverage.Depth = 0;
            this.MtlDeathCoverage.Hint = "";
            this.MtlDeathCoverage.Location = new System.Drawing.Point(589, 56);
            this.MtlDeathCoverage.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlDeathCoverage.Name = "MtlDeathCoverage";
            this.MtlDeathCoverage.PasswordChar = '\0';
            this.MtlDeathCoverage.SelectedText = "";
            this.MtlDeathCoverage.SelectionLength = 0;
            this.MtlDeathCoverage.SelectionStart = 0;
            this.MtlDeathCoverage.Size = new System.Drawing.Size(119, 23);
            this.MtlDeathCoverage.TabIndex = 203;
            this.MtlDeathCoverage.UseSystemPasswordChar = false;
            // 
            // MtlDisabilityCoverage
            // 
            this.MtlDisabilityCoverage.BackColor = System.Drawing.Color.White;
            this.MtlDisabilityCoverage.Depth = 0;
            this.MtlDisabilityCoverage.Hint = "";
            this.MtlDisabilityCoverage.Location = new System.Drawing.Point(145, 94);
            this.MtlDisabilityCoverage.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlDisabilityCoverage.Name = "MtlDisabilityCoverage";
            this.MtlDisabilityCoverage.PasswordChar = '\0';
            this.MtlDisabilityCoverage.SelectedText = "";
            this.MtlDisabilityCoverage.SelectionLength = 0;
            this.MtlDisabilityCoverage.SelectionStart = 0;
            this.MtlDisabilityCoverage.Size = new System.Drawing.Size(119, 23);
            this.MtlDisabilityCoverage.TabIndex = 205;
            this.MtlDisabilityCoverage.UseSystemPasswordChar = false;
            // 
            // MtlInsurancePayment
            // 
            this.MtlInsurancePayment.BackColor = System.Drawing.Color.White;
            this.MtlInsurancePayment.Depth = 0;
            this.MtlInsurancePayment.Hint = "";
            this.MtlInsurancePayment.Location = new System.Drawing.Point(393, 94);
            this.MtlInsurancePayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlInsurancePayment.Name = "MtlInsurancePayment";
            this.MtlInsurancePayment.PasswordChar = '\0';
            this.MtlInsurancePayment.SelectedText = "";
            this.MtlInsurancePayment.SelectionLength = 0;
            this.MtlInsurancePayment.SelectionStart = 0;
            this.MtlInsurancePayment.Size = new System.Drawing.Size(119, 23);
            this.MtlInsurancePayment.TabIndex = 206;
            this.MtlInsurancePayment.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(270, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 200;
            this.label1.Text = "Insurance Payment";
            // 
            // MtlPaymentPeriod
            // 
            this.MtlPaymentPeriod.BackColor = System.Drawing.Color.White;
            this.MtlPaymentPeriod.Depth = 0;
            this.MtlPaymentPeriod.Hint = "";
            this.MtlPaymentPeriod.Location = new System.Drawing.Point(621, 94);
            this.MtlPaymentPeriod.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlPaymentPeriod.Name = "MtlPaymentPeriod";
            this.MtlPaymentPeriod.PasswordChar = '\0';
            this.MtlPaymentPeriod.SelectedText = "";
            this.MtlPaymentPeriod.SelectionLength = 0;
            this.MtlPaymentPeriod.SelectionStart = 0;
            this.MtlPaymentPeriod.Size = new System.Drawing.Size(119, 23);
            this.MtlPaymentPeriod.TabIndex = 207;
            this.MtlPaymentPeriod.UseSystemPasswordChar = false;
            // 
            // Seguro_Vida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 400);
            this.Controls.Add(this.MtlPaymentPeriod);
            this.Controls.Add(this.MtlInsurancePayment);
            this.Controls.Add(this.MtlDisabilityCoverage);
            this.Controls.Add(this.MtlDeathCoverage);
            this.Controls.Add(this.MtlBeneficiary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MtlInsuranceCompany);
            this.Controls.Add(this.MtlPolicyNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialDivider2);
            this.Name = "Seguro_Vida";
            this.Text = "Seguro de Vida";
            this.Load += new System.EventHandler(this.Seguro_Vida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlInsuranceCompany;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlPolicyNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlBeneficiary;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlDeathCoverage;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlDisabilityCoverage;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlInsurancePayment;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlPaymentPeriod;
    }
}