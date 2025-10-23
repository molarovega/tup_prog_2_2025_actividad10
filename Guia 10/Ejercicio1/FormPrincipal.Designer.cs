namespace Ejercicio1
{
    partial class FormPrincipal
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lsbVerSolicitudesImportadas = new System.Windows.Forms.ListBox();
            this.btnImportarSolicitudes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirmarAtencion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lsbVerSolicitudesImportadas
            // 
            this.lsbVerSolicitudesImportadas.FormattingEnabled = true;
            this.lsbVerSolicitudesImportadas.Location = new System.Drawing.Point(15, 168);
            this.lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            this.lsbVerSolicitudesImportadas.Size = new System.Drawing.Size(156, 225);
            this.lsbVerSolicitudesImportadas.TabIndex = 0;
            // 
            // btnImportarSolicitudes
            // 
            this.btnImportarSolicitudes.Location = new System.Drawing.Point(15, 81);
            this.btnImportarSolicitudes.Name = "btnImportarSolicitudes";
            this.btnImportarSolicitudes.Size = new System.Drawing.Size(86, 44);
            this.btnImportarSolicitudes.TabIndex = 1;
            this.btnImportarSolicitudes.Text = "Importar Solicitudes";
            this.btnImportarSolicitudes.UseVisualStyleBackColor = true;
            this.btnImportarSolicitudes.Click += new System.EventHandler(this.btnImportarSolicitudes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnConfirmarAtencion);
            this.groupBox1.Controls.Add(this.btnImportarSolicitudes);
            this.groupBox1.Controls.Add(this.lsbVerSolicitudesImportadas);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 419);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atencion de Solucitudes";
            // 
            // btnConfirmarAtencion
            // 
            this.btnConfirmarAtencion.Location = new System.Drawing.Point(203, 226);
            this.btnConfirmarAtencion.Name = "btnConfirmarAtencion";
            this.btnConfirmarAtencion.Size = new System.Drawing.Size(101, 43);
            this.btnConfirmarAtencion.TabIndex = 3;
            this.btnConfirmarAtencion.Text = "button2";
            this.btnConfirmarAtencion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de solicitudes Entrantes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lsbVerSolicitudesImportadas;
        private System.Windows.Forms.Button btnImportarSolicitudes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirmarAtencion;
        private System.Windows.Forms.Label label2;
    }
}

