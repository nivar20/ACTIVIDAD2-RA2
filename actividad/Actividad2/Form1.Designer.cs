namespace Actividad2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTitulo = new TextBox();
            cboGenero = new ComboBox();
            txtDirector = new TextBox();
            txtDuraccion = new TextBox();
            txtProductora = new TextBox();
            dgvPelicula = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            btnSalir = new Button();
            btnGenerar = new Button();
            txtContenidoArchivo = new TextBox();
            btnVerArchivo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 1;
            label2.Text = "Genero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 167);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 2;
            label3.Text = "Director";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 231);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 3;
            label4.Text = "Productora";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 124);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 4;
            label5.Text = "Duracion";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(89, 18);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(106, 23);
            txtTitulo.TabIndex = 5;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Items.AddRange(new object[] { "Acción", "Comedia  ", "Drama", "Ciencia ficción", "Terror  ", "Romance" });
            cboGenero.Location = new Point(89, 67);
            cboGenero.Margin = new Padding(2);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(129, 23);
            cboGenero.TabIndex = 6;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(112, 163);
            txtDirector.Margin = new Padding(2);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(106, 23);
            txtDirector.TabIndex = 7;
            // 
            // txtDuraccion
            // 
            txtDuraccion.Location = new Point(112, 120);
            txtDuraccion.Margin = new Padding(2);
            txtDuraccion.Name = "txtDuraccion";
            txtDuraccion.Size = new Size(106, 23);
            txtDuraccion.TabIndex = 8;
            // 
            // txtProductora
            // 
            txtProductora.Location = new Point(112, 227);
            txtProductora.Margin = new Padding(2);
            txtProductora.Name = "txtProductora";
            txtProductora.Size = new Size(106, 23);
            txtProductora.TabIndex = 9;
            // 
            // dgvPelicula
            // 
            dgvPelicula.BackgroundColor = Color.FromArgb(128, 128, 255);
            dgvPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelicula.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvPelicula.Location = new Point(253, 91);
            dgvPelicula.Margin = new Padding(2);
            dgvPelicula.Name = "dgvPelicula";
            dgvPelicula.RowHeadersWidth = 62;
            dgvPelicula.RowTemplate.Height = 33;
            dgvPelicula.Size = new Size(530, 159);
            dgvPelicula.TabIndex = 10;
            dgvPelicula.CellContentClick += dgvPelicula_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Titulo";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Genero";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Duracion";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Director";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Productora";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 192, 192);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(249, 18);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(84, 33);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(857, 7);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 34);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(255, 192, 192);
            btnGenerar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerar.Location = new Point(372, 18);
            btnGenerar.Margin = new Padding(2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(84, 33);
            btnGenerar.TabIndex = 13;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtContenidoArchivo
            // 
            txtContenidoArchivo.Location = new Point(372, 275);
            txtContenidoArchivo.Margin = new Padding(2);
            txtContenidoArchivo.Name = "txtContenidoArchivo";
            txtContenidoArchivo.Size = new Size(411, 23);
            txtContenidoArchivo.TabIndex = 14;
            // 
            // btnVerArchivo
            // 
            btnVerArchivo.BackColor = Color.FromArgb(255, 192, 192);
            btnVerArchivo.ForeColor = SystemColors.ActiveCaptionText;
            btnVerArchivo.Location = new Point(249, 275);
            btnVerArchivo.Margin = new Padding(2);
            btnVerArchivo.Name = "btnVerArchivo";
            btnVerArchivo.Size = new Size(99, 33);
            btnVerArchivo.TabIndex = 15;
            btnVerArchivo.Text = "Ver Archivo";
            btnVerArchivo.UseVisualStyleBackColor = false;
            btnVerArchivo.Click += btnVerArchivo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(957, 412);
            Controls.Add(btnVerArchivo);
            Controls.Add(txtContenidoArchivo);
            Controls.Add(btnGenerar);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(dgvPelicula);
            Controls.Add(txtProductora);
            Controls.Add(txtDuraccion);
            Controls.Add(txtDirector);
            Controls.Add(cboGenero);
            Controls.Add(txtTitulo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Registro de Peliculas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTitulo;
        private ComboBox cboGenero;
        private TextBox txtDirector;
        private TextBox txtDuraccion;
        private TextBox txtProductora;
        private DataGridView dgvPelicula;
        private Button btnGuardar;
        private Button btnSalir;
        private Button btnGenerar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtContenidoArchivo;
        private Button btnVerArchivo;
    }
}
