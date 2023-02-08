namespace Ejemplo_Multilenguaje
{
    partial class frmSecundario
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
            this.lblMensaje2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Location = new System.Drawing.Point(26, 13);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje2.TabIndex = 0;
            this.lblMensaje2.Text = "label1";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(29, 65);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "button1";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(176, 65);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "button2";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 110);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblMensaje2);
            this.Name = "frmSecundario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSecundario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCerrar;
    }
}