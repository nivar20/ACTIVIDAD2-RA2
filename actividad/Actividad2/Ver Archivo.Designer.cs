namespace Actividad2
{
    partial class Ver_Archivo
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
            txtContenidoArchivo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtContenidoArchivo
            // 
            txtContenidoArchivo.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            txtContenidoArchivo.Location = new Point(39, 115);
            txtContenidoArchivo.Name = "txtContenidoArchivo";
            txtContenidoArchivo.Size = new Size(671, 77);
            txtContenidoArchivo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(222, 30);
            label1.Name = "label1";
            label1.Size = new Size(244, 34);
            label1.TabIndex = 1;
            label1.Text = "Archivo de texto";
            // 
            // Ver_Archivo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtContenidoArchivo);
            Name = "Ver_Archivo";
            Text = "Ver_Archivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContenidoArchivo;
        private Label label1;
    }
}