namespace WFGit
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
            this.btAceptar = new System.Windows.Forms.Button();
            this.btSegundo = new System.Windows.Forms.Button();
            this.lblJuanito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(157, 138);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(115, 56);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btSegundo
            // 
            this.btSegundo.Location = new System.Drawing.Point(418, 146);
            this.btSegundo.Name = "btSegundo";
            this.btSegundo.Size = new System.Drawing.Size(104, 40);
            this.btSegundo.TabIndex = 1;
            this.btSegundo.Text = "NUEVO";
            this.btSegundo.UseVisualStyleBackColor = true;
            // 
            // lblJuanito
            // 
            this.lblJuanito.AutoSize = true;
            this.lblJuanito.Location = new System.Drawing.Point(75, 358);
            this.lblJuanito.Name = "lblJuanito";
            this.lblJuanito.Size = new System.Drawing.Size(96, 20);
            this.lblJuanito.TabIndex = 2;
            this.lblJuanito.Text = "Soy Juanito";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblJuanito);
            this.Controls.Add(this.btSegundo);
            this.Controls.Add(this.btAceptar);
            this.Name = "Form1";
            this.Text = "Formulario de ejemplo 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btSegundo;
        private System.Windows.Forms.Label lblJuanito;
    }
}

