namespace Ejemplo_Multilenguaje
{
    partial class frmPrincipal
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
            this.lblLenguaje = new System.Windows.Forms.Label();
            this.cmbLenguaje = new System.Windows.Forms.ComboBox();
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.rdbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rdbOpcion1 = new System.Windows.Forms.RadioButton();
            this.btnMensaje = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSelector = new System.Windows.Forms.CheckBox();
            this.grpOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLenguaje
            // 
            this.lblLenguaje.AutoSize = true;
            this.lblLenguaje.Location = new System.Drawing.Point(13, 13);
            this.lblLenguaje.Name = "lblLenguaje";
            this.lblLenguaje.Size = new System.Drawing.Size(35, 13);
            this.lblLenguaje.TabIndex = 0;
            this.lblLenguaje.Text = "label1";
            // 
            // cmbLenguaje
            // 
            this.cmbLenguaje.FormattingEnabled = true;
            this.cmbLenguaje.Location = new System.Drawing.Point(140, 10);
            this.cmbLenguaje.Name = "cmbLenguaje";
            this.cmbLenguaje.Size = new System.Drawing.Size(121, 21);
            this.cmbLenguaje.TabIndex = 1;
            this.cmbLenguaje.SelectionChangeCommitted += new System.EventHandler(this.cmbLenguaje_SelectionChangeCommitted);
            // 
            // grpOpciones
            // 
            this.grpOpciones.Controls.Add(this.rdbOpcion2);
            this.grpOpciones.Controls.Add(this.rdbOpcion1);
            this.grpOpciones.Location = new System.Drawing.Point(140, 49);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(121, 71);
            this.grpOpciones.TabIndex = 3;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "groupBox1";
            // 
            // rdbOpcion2
            // 
            this.rdbOpcion2.AutoSize = true;
            this.rdbOpcion2.Location = new System.Drawing.Point(7, 43);
            this.rdbOpcion2.Name = "rdbOpcion2";
            this.rdbOpcion2.Size = new System.Drawing.Size(85, 17);
            this.rdbOpcion2.TabIndex = 1;
            this.rdbOpcion2.TabStop = true;
            this.rdbOpcion2.Text = "radioButton2";
            this.rdbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rdbOpcion1
            // 
            this.rdbOpcion1.AutoSize = true;
            this.rdbOpcion1.Location = new System.Drawing.Point(7, 20);
            this.rdbOpcion1.Name = "rdbOpcion1";
            this.rdbOpcion1.Size = new System.Drawing.Size(85, 17);
            this.rdbOpcion1.TabIndex = 0;
            this.rdbOpcion1.TabStop = true;
            this.rdbOpcion1.Text = "radioButton1";
            this.rdbOpcion1.UseVisualStyleBackColor = true;
            // 
            // btnMensaje
            // 
            this.btnMensaje.Location = new System.Drawing.Point(16, 130);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(75, 23);
            this.btnMensaje.TabIndex = 4;
            this.btnMensaje.Text = "button1";
            this.btnMensaje.UseVisualStyleBackColor = true;
            this.btnMensaje.Click += new System.EventHandler(this.btnMensaje_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(186, 130);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "button2";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(186, 180);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "button3";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkSelector);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 47);
            this.panel1.TabIndex = 7;
            // 
            // chkSelector
            // 
            this.chkSelector.AutoSize = true;
            this.chkSelector.Location = new System.Drawing.Point(11, 15);
            this.chkSelector.Name = "chkSelector";
            this.chkSelector.Size = new System.Drawing.Size(80, 17);
            this.chkSelector.TabIndex = 3;
            this.chkSelector.Text = "checkBox1";
            this.chkSelector.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 213);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnMensaje);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.cmbLenguaje);
            this.Controls.Add(this.lblLenguaje);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grpOpciones.ResumeLayout(false);
            this.grpOpciones.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLenguaje;
        private System.Windows.Forms.ComboBox cmbLenguaje;
        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.RadioButton rdbOpcion2;
        private System.Windows.Forms.RadioButton rdbOpcion1;
        private System.Windows.Forms.Button btnMensaje;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkSelector;
    }
}

