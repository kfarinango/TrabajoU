namespace WindowsFormsClases2018.Ejercicios
{
    partial class fMantenimientoUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrcedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrapellidopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrapellidomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrnombrecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usridusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrclaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFDESCRIPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaDatos = new WindowsFormsClases2018.vistaDatos();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxPerfil = new System.Windows.Forms.ComboBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textIDUsuario = new System.Windows.Forms.TextBox();
            this.textEMail = new System.Windows.Forms.TextBox();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.textApellidoMaterno = new System.Windows.Forms.TextBox();
            this.textApelllidoPaterno = new System.Windows.Forms.TextBox();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.dataTable1TableAdapter = new WindowsFormsClases2018.vistaDatosTableAdapters.DataTable1TableAdapter();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDatos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(11, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(510, 154);
            this.panel4.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usridDataGridViewTextBoxColumn,
            this.usrcedulaDataGridViewTextBoxColumn,
            this.usrapellidopDataGridViewTextBoxColumn,
            this.usrapellidomDataGridViewTextBoxColumn,
            this.usrnombrecDataGridViewTextBoxColumn,
            this.usrmailDataGridViewTextBoxColumn,
            this.usridusuarioDataGridViewTextBoxColumn,
            this.usrclaveDataGridViewTextBoxColumn,
            this.pRFDESCRIPCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(510, 154);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // usridDataGridViewTextBoxColumn
            // 
            this.usridDataGridViewTextBoxColumn.DataPropertyName = "usrid";
            this.usridDataGridViewTextBoxColumn.HeaderText = "usrid";
            this.usridDataGridViewTextBoxColumn.Name = "usridDataGridViewTextBoxColumn";
            this.usridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usrcedulaDataGridViewTextBoxColumn
            // 
            this.usrcedulaDataGridViewTextBoxColumn.DataPropertyName = "usrcedula";
            this.usrcedulaDataGridViewTextBoxColumn.HeaderText = "usrcedula";
            this.usrcedulaDataGridViewTextBoxColumn.Name = "usrcedulaDataGridViewTextBoxColumn";
            // 
            // usrapellidopDataGridViewTextBoxColumn
            // 
            this.usrapellidopDataGridViewTextBoxColumn.DataPropertyName = "usrapellidop";
            this.usrapellidopDataGridViewTextBoxColumn.HeaderText = "usrapellidop";
            this.usrapellidopDataGridViewTextBoxColumn.Name = "usrapellidopDataGridViewTextBoxColumn";
            // 
            // usrapellidomDataGridViewTextBoxColumn
            // 
            this.usrapellidomDataGridViewTextBoxColumn.DataPropertyName = "usrapellidom";
            this.usrapellidomDataGridViewTextBoxColumn.HeaderText = "usrapellidom";
            this.usrapellidomDataGridViewTextBoxColumn.Name = "usrapellidomDataGridViewTextBoxColumn";
            // 
            // usrnombrecDataGridViewTextBoxColumn
            // 
            this.usrnombrecDataGridViewTextBoxColumn.DataPropertyName = "usrnombrec";
            this.usrnombrecDataGridViewTextBoxColumn.HeaderText = "usrnombrec";
            this.usrnombrecDataGridViewTextBoxColumn.Name = "usrnombrecDataGridViewTextBoxColumn";
            // 
            // usrmailDataGridViewTextBoxColumn
            // 
            this.usrmailDataGridViewTextBoxColumn.DataPropertyName = "usrmail";
            this.usrmailDataGridViewTextBoxColumn.HeaderText = "usrmail";
            this.usrmailDataGridViewTextBoxColumn.Name = "usrmailDataGridViewTextBoxColumn";
            // 
            // usridusuarioDataGridViewTextBoxColumn
            // 
            this.usridusuarioDataGridViewTextBoxColumn.DataPropertyName = "usridusuario";
            this.usridusuarioDataGridViewTextBoxColumn.HeaderText = "usridusuario";
            this.usridusuarioDataGridViewTextBoxColumn.Name = "usridusuarioDataGridViewTextBoxColumn";
            // 
            // usrclaveDataGridViewTextBoxColumn
            // 
            this.usrclaveDataGridViewTextBoxColumn.DataPropertyName = "usrclave";
            this.usrclaveDataGridViewTextBoxColumn.HeaderText = "usrclave";
            this.usrclaveDataGridViewTextBoxColumn.Name = "usrclaveDataGridViewTextBoxColumn";
            // 
            // pRFDESCRIPCDataGridViewTextBoxColumn
            // 
            this.pRFDESCRIPCDataGridViewTextBoxColumn.DataPropertyName = "PRFDESCRIPC";
            this.pRFDESCRIPCDataGridViewTextBoxColumn.HeaderText = "PRFDESCRIPC";
            this.pRFDESCRIPCDataGridViewTextBoxColumn.Name = "pRFDESCRIPCDataGridViewTextBoxColumn";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.vistaDatos;
            // 
            // vistaDatos
            // 
            this.vistaDatos.DataSetName = "vistaDatos";
            this.vistaDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnModificar);
            this.panel3.Controls.Add(this.btnGrabar);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Location = new System.Drawing.Point(403, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 272);
            this.panel3.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(23, 208);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(23, 166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnModificar.Location = new System.Drawing.Point(23, 127);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Location = new System.Drawing.Point(23, 85);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(23, 43);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExaminar);
            this.panel2.Location = new System.Drawing.Point(232, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 87);
            this.panel2.TabIndex = 7;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Location = new System.Drawing.Point(36, 26);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 0;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(232, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 140);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxPerfil);
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Controls.Add(this.textIDUsuario);
            this.panel1.Controls.Add(this.textEMail);
            this.panel1.Controls.Add(this.textNombres);
            this.panel1.Controls.Add(this.textApellidoMaterno);
            this.panel1.Controls.Add(this.textApelllidoPaterno);
            this.panel1.Controls.Add(this.textCedula);
            this.panel1.Controls.Add(this.lblPerfil);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblIDUsuario);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.lblNombres);
            this.panel1.Controls.Add(this.lblApellidoMaterno);
            this.panel1.Controls.Add(this.lblApellidoPaterno);
            this.panel1.Controls.Add(this.lblCedula);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 272);
            this.panel1.TabIndex = 5;
            // 
            // comboBoxPerfil
            // 
            this.comboBoxPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPerfil.FormattingEnabled = true;
            this.comboBoxPerfil.Location = new System.Drawing.Point(103, 229);
            this.comboBoxPerfil.Name = "comboBoxPerfil";
            this.comboBoxPerfil.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPerfil.TabIndex = 15;
            this.comboBoxPerfil.SelectedIndexChanged += new System.EventHandler(this.comboBoxPerfil_SelectedIndexChanged);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(103, 203);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(100, 20);
            this.textPassword.TabIndex = 14;
            // 
            // textIDUsuario
            // 
            this.textIDUsuario.Location = new System.Drawing.Point(103, 175);
            this.textIDUsuario.Name = "textIDUsuario";
            this.textIDUsuario.Size = new System.Drawing.Size(100, 20);
            this.textIDUsuario.TabIndex = 13;
            // 
            // textEMail
            // 
            this.textEMail.Location = new System.Drawing.Point(103, 146);
            this.textEMail.Name = "textEMail";
            this.textEMail.Size = new System.Drawing.Size(100, 20);
            this.textEMail.TabIndex = 12;
            // 
            // textNombres
            // 
            this.textNombres.Location = new System.Drawing.Point(103, 116);
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(100, 20);
            this.textNombres.TabIndex = 11;
            // 
            // textApellidoMaterno
            // 
            this.textApellidoMaterno.Location = new System.Drawing.Point(103, 88);
            this.textApellidoMaterno.Name = "textApellidoMaterno";
            this.textApellidoMaterno.Size = new System.Drawing.Size(100, 20);
            this.textApellidoMaterno.TabIndex = 10;
            // 
            // textApelllidoPaterno
            // 
            this.textApelllidoPaterno.Location = new System.Drawing.Point(103, 56);
            this.textApelllidoPaterno.Name = "textApelllidoPaterno";
            this.textApelllidoPaterno.Size = new System.Drawing.Size(100, 20);
            this.textApelllidoPaterno.TabIndex = 9;
            // 
            // textCedula
            // 
            this.textCedula.Location = new System.Drawing.Point(103, 21);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(100, 20);
            this.textCedula.TabIndex = 8;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(66, 234);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(30, 13);
            this.lblPerfil.TabIndex = 7;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(35, 206);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Location = new System.Drawing.Point(38, 178);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(58, 13);
            this.lblIDUsuario.TabIndex = 5;
            this.lblIDUsuario.Text = "Id. Usuario";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(60, 149);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 13);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "E-Mail";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(47, 119);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 3;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(12, 88);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(86, 13);
            this.lblApellidoMaterno.TabIndex = 2;
            this.lblApellidoMaterno.Text = "Apellido Materno";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(12, 56);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblApellidoPaterno.TabIndex = 1;
            this.lblApellidoPaterno.Text = "Apellido Paterno";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(56, 24);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cédula";
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // fMantenimientoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 479);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "fMantenimientoUsuario";
            this.Text = "fMantenimientoUsuario";
            this.Load += new System.EventHandler(this.fMantenimientoUsuario_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDatos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxPerfil;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textIDUsuario;
        private System.Windows.Forms.TextBox textEMail;
        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.TextBox textApellidoMaterno;
        private System.Windows.Forms.TextBox textApelllidoPaterno;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblCedula;
        private vistaDatos vistaDatos;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private vistaDatosTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrcedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrapellidopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrapellidomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrnombrecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usridusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrclaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFDESCRIPCDataGridViewTextBoxColumn;
    }
}