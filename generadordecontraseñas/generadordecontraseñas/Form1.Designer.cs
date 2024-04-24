
namespace generadordecontraseñas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Generarbuton = new System.Windows.Forms.Button();
            this.PasswordTexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Generarbuton
            // 
            this.Generarbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generarbuton.Location = new System.Drawing.Point(220, 149);
            this.Generarbuton.Name = "Generarbuton";
            this.Generarbuton.Size = new System.Drawing.Size(256, 36);
            this.Generarbuton.TabIndex = 0;
            this.Generarbuton.Text = "Generar Contraseña ";
            this.Generarbuton.UseVisualStyleBackColor = true;
            this.Generarbuton.Click += new System.EventHandler(this.Generarbuton_Click);
            // 
            // PasswordTexBox
            // 
            this.PasswordTexBox.Location = new System.Drawing.Point(170, 99);
            this.PasswordTexBox.Name = "PasswordTexBox";
            this.PasswordTexBox.Size = new System.Drawing.Size(376, 26);
            this.PasswordTexBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generador de Contraseñas ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTexBox);
            this.Controls.Add(this.Generarbuton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generarbuton;
        private System.Windows.Forms.TextBox PasswordTexBox;
        private System.Windows.Forms.Label label1;
    }
}

