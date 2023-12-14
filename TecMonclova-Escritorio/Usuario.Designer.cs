
namespace TecMonclova_Escritorio
{
    partial class Usuario
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
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.MtlName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MtlUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.MtlPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MtlEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MtlConfirmPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(213, 130);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(91, 30);
            this.btnEliminar.TabIndex = 234;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(114, 130);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(91, 30);
            this.btnModificar.TabIndex = 233;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(15, 130);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(91, 30);
            this.btnAgregar.TabIndex = 232;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(502, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 231;
            this.label5.Text = "Email";
            // 
            // MtlName
            // 
            this.MtlName.BackColor = System.Drawing.Color.White;
            this.MtlName.Depth = 0;
            this.MtlName.Hint = "";
            this.MtlName.Location = new System.Drawing.Point(143, 23);
            this.MtlName.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlName.Name = "MtlName";
            this.MtlName.PasswordChar = '\0';
            this.MtlName.SelectedText = "";
            this.MtlName.SelectionLength = 0;
            this.MtlName.SelectionStart = 0;
            this.MtlName.Size = new System.Drawing.Size(136, 23);
            this.MtlName.TabIndex = 230;
            this.MtlName.UseSystemPasswordChar = false;
            // 
            // MtlUserName
            // 
            this.MtlUserName.BackColor = System.Drawing.Color.White;
            this.MtlUserName.Depth = 0;
            this.MtlUserName.Hint = "";
            this.MtlUserName.Location = new System.Drawing.Point(357, 23);
            this.MtlUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlUserName.Name = "MtlUserName";
            this.MtlUserName.PasswordChar = '\0';
            this.MtlUserName.SelectedText = "";
            this.MtlUserName.SelectionLength = 0;
            this.MtlUserName.SelectionStart = 0;
            this.MtlUserName.Size = new System.Drawing.Size(139, 23);
            this.MtlUserName.TabIndex = 229;
            this.MtlUserName.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 228;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 227;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 226;
            this.label2.Text = "Username";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 207);
            this.dataGridView1.TabIndex = 224;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 120);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(766, 51);
            this.materialDivider2.TabIndex = 225;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // MtlPass
            // 
            this.MtlPass.BackColor = System.Drawing.Color.White;
            this.MtlPass.Depth = 0;
            this.MtlPass.Hint = "";
            this.MtlPass.Location = new System.Drawing.Point(198, 72);
            this.MtlPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlPass.Name = "MtlPass";
            this.MtlPass.PasswordChar = '*';
            this.MtlPass.SelectedText = "";
            this.MtlPass.SelectionLength = 0;
            this.MtlPass.SelectionStart = 0;
            this.MtlPass.Size = new System.Drawing.Size(150, 23);
            this.MtlPass.TabIndex = 235;
            this.MtlPass.UseSystemPasswordChar = false;
            // 
            // MtlEmail
            // 
            this.MtlEmail.BackColor = System.Drawing.Color.White;
            this.MtlEmail.Depth = 0;
            this.MtlEmail.Hint = "";
            this.MtlEmail.Location = new System.Drawing.Point(547, 23);
            this.MtlEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlEmail.Name = "MtlEmail";
            this.MtlEmail.PasswordChar = '\0';
            this.MtlEmail.SelectedText = "";
            this.MtlEmail.SelectionLength = 0;
            this.MtlEmail.SelectionStart = 0;
            this.MtlEmail.Size = new System.Drawing.Size(139, 23);
            this.MtlEmail.TabIndex = 236;
            this.MtlEmail.UseSystemPasswordChar = false;
            // 
            // MtlConfirmPass
            // 
            this.MtlConfirmPass.BackColor = System.Drawing.Color.White;
            this.MtlConfirmPass.Depth = 0;
            this.MtlConfirmPass.Hint = "";
            this.MtlConfirmPass.Location = new System.Drawing.Point(472, 72);
            this.MtlConfirmPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtlConfirmPass.Name = "MtlConfirmPass";
            this.MtlConfirmPass.PasswordChar = '*';
            this.MtlConfirmPass.SelectedText = "";
            this.MtlConfirmPass.SelectionLength = 0;
            this.MtlConfirmPass.SelectionStart = 0;
            this.MtlConfirmPass.Size = new System.Drawing.Size(150, 23);
            this.MtlConfirmPass.TabIndex = 238;
            this.MtlConfirmPass.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 237;
            this.label1.Text = "Confirm Password";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 400);
            this.Controls.Add(this.MtlConfirmPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MtlEmail);
            this.Controls.Add(this.MtlPass);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MtlName);
            this.Controls.Add(this.MtlUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialDivider2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlName;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField MtlConfirmPass;
        private System.Windows.Forms.Label label1;
    }
}