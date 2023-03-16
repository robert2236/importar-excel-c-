namespace Excelmportacion
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
            this.DataDetalles = new System.Windows.Forms.DataGridView();
            this.btnImportarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // DataDetalles
            // 
            this.DataDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDetalles.Location = new System.Drawing.Point(26, 30);
            this.DataDetalles.Name = "DataDetalles";
            this.DataDetalles.Size = new System.Drawing.Size(740, 375);
            this.DataDetalles.TabIndex = 1;
            // 
            // btnImportarDatos
            // 
            this.btnImportarDatos.Location = new System.Drawing.Point(842, 59);
            this.btnImportarDatos.Name = "btnImportarDatos";
            this.btnImportarDatos.Size = new System.Drawing.Size(97, 48);
            this.btnImportarDatos.TabIndex = 2;
            this.btnImportarDatos.Text = "IMPORTAR";
            this.btnImportarDatos.UseVisualStyleBackColor = true;
            this.btnImportarDatos.Click += new System.EventHandler(this.btnImportarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.btnImportarDatos);
            this.Controls.Add(this.DataDetalles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataDetalles;
        private System.Windows.Forms.Button btnImportarDatos;
    }
}

