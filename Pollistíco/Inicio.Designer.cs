namespace Pollistíco
{
    partial class Inicio
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
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_IniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(60, 148);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(109, 23);
            this.btn_registrar.TabIndex = 0;
            this.btn_registrar.Text = "Registrarte";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.Location = new System.Drawing.Point(60, 81);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(109, 23);
            this.btn_IniciarSesion.TabIndex = 1;
            this.btn_IniciarSesion.Text = "Iniciar Sesión";
            this.btn_IniciarSesion.UseVisualStyleBackColor = true;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qué quieres hacer?";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(237, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.btn_registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_IniciarSesion;
        private System.Windows.Forms.Label label1;
    }
}