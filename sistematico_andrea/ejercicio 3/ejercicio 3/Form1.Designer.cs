namespace ejercicio_3
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
            this.lblmatriz1 = new System.Windows.Forms.Label();
            this.lblmatriz2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmatriz1
            // 
            this.lblmatriz1.AutoSize = true;
            this.lblmatriz1.Location = new System.Drawing.Point(129, 119);
            this.lblmatriz1.Name = "lblmatriz1";
            this.lblmatriz1.Size = new System.Drawing.Size(41, 13);
            this.lblmatriz1.TabIndex = 0;
            this.lblmatriz1.Text = "Matriz1";
            // 
            // lblmatriz2
            // 
            this.lblmatriz2.AutoSize = true;
            this.lblmatriz2.Location = new System.Drawing.Point(132, 171);
            this.lblmatriz2.Name = "lblmatriz2";
            this.lblmatriz2.Size = new System.Drawing.Size(41, 13);
            this.lblmatriz2.TabIndex = 1;
            this.lblmatriz2.Text = "Matriz2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmatriz2);
            this.Controls.Add(this.lblmatriz1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmatriz1;
        private System.Windows.Forms.Label lblmatriz2;
    }
}

