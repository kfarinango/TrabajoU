namespace WindowsFormsClases2018.Ejercicios
{
    partial class fAmortizacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboPlazo = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblmontoprestamo = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtmontoPrestamo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridPrestamoCalcular = new System.Windows.Forms.DataGridView();
            this.colCuetas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmeses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrestamoCalcular)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboPlazo);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.lblInteres);
            this.panel1.Controls.Add(this.lblmontoprestamo);
            this.panel1.Controls.Add(this.comboTipo);
            this.panel1.Controls.Add(this.txtInteres);
            this.panel1.Controls.Add(this.txtmontoPrestamo);
            this.panel1.Location = new System.Drawing.Point(8, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 107);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboPlazo
            // 
            this.comboPlazo.FormattingEnabled = true;
            this.comboPlazo.Items.AddRange(new object[] {
            "12",
            "18",
            "24",
            "36",
            "60",
            "240"});
            this.comboPlazo.Location = new System.Drawing.Point(214, 16);
            this.comboPlazo.Name = "comboPlazo";
            this.comboPlazo.Size = new System.Drawing.Size(192, 21);
            this.comboPlazo.TabIndex = 8;
            this.comboPlazo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboPlazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboPlazo_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(264, 75);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(109, 24);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(11, 51);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(39, 13);
            this.lblInteres.TabIndex = 6;
            this.lblInteres.Text = "Interés";
            // 
            // lblmontoprestamo
            // 
            this.lblmontoprestamo.AutoSize = true;
            this.lblmontoprestamo.Location = new System.Drawing.Point(11, 16);
            this.lblmontoprestamo.Name = "lblmontoprestamo";
            this.lblmontoprestamo.Size = new System.Drawing.Size(84, 13);
            this.lblmontoprestamo.TabIndex = 4;
            this.lblmontoprestamo.Text = "Monto Préstamo";
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Consumo",
            "Autos",
            "Hipotecarios"});
            this.comboTipo.Location = new System.Drawing.Point(214, 48);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(192, 21);
            this.comboTipo.TabIndex = 3;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.combotipo_SelectedIndexChanged);
            this.comboTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combotipo_KeyDown);
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(91, 50);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(92, 20);
            this.txtInteres.TabIndex = 2;
            this.txtInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInteres_KeyPress);
            // 
            // txtmontoPrestamo
            // 
            this.txtmontoPrestamo.Location = new System.Drawing.Point(95, 13);
            this.txtmontoPrestamo.Name = "txtmontoPrestamo";
            this.txtmontoPrestamo.Size = new System.Drawing.Size(89, 20);
            this.txtmontoPrestamo.TabIndex = 0;
            this.txtmontoPrestamo.TextChanged += new System.EventHandler(this.txtmontoPrestamo_TextChanged);
            this.txtmontoPrestamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmontoPrestamo_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridPrestamoCalcular);
            this.panel2.Location = new System.Drawing.Point(7, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 196);
            this.panel2.TabIndex = 1;
            // 
            // gridPrestamoCalcular
            // 
            this.gridPrestamoCalcular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrestamoCalcular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCuetas,
            this.colmeses,
            this.colTotal,
            this.colNumero});
            this.gridPrestamoCalcular.Location = new System.Drawing.Point(3, 5);
            this.gridPrestamoCalcular.Name = "gridPrestamoCalcular";
            this.gridPrestamoCalcular.Size = new System.Drawing.Size(447, 190);
            this.gridPrestamoCalcular.TabIndex = 0;
            this.gridPrestamoCalcular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colCuetas
            // 
            this.colCuetas.HeaderText = "Cuenta";
            this.colCuetas.Name = "colCuetas";
            // 
            // colmeses
            // 
            this.colmeses.HeaderText = "Meses";
            this.colmeses.Name = "colmeses";
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Número";
            this.colNumero.Name = "colNumero";
            // 
            // fAmortizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fAmortizacion";
            this.Text = "Amortización";
            this.Load += new System.EventHandler(this.fAmortizacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrestamoCalcular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblmontoprestamo;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtmontoPrestamo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridPrestamoCalcular;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmeses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.ComboBox comboPlazo;
    }
}