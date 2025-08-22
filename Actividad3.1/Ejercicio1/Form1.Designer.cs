namespace Ejercicio1
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
            tbResultado = new TextBox();
            btnCorrerRutina = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(12, 12);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(375, 387);
            tbResultado.TabIndex = 0;
            // 
            // btnCorrerRutina
            // 
            btnCorrerRutina.Location = new Point(409, 12);
            btnCorrerRutina.Name = "btnCorrerRutina";
            btnCorrerRutina.Size = new Size(96, 70);
            btnCorrerRutina.TabIndex = 1;
            btnCorrerRutina.Text = "Correr Rutina";
            btnCorrerRutina.UseVisualStyleBackColor = true;
            btnCorrerRutina.Click += btnCorrerRutina_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(409, 365);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 34);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 419);
            Controls.Add(btnSalir);
            Controls.Add(btnCorrerRutina);
            Controls.Add(tbResultado);
            Name = "Form1";
            Text = "Actividad 3.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbResultado;
        private Button btnCorrerRutina;
        private Button btnSalir;
    }
}
