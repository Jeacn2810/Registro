namespace ProyectoFinalDiseño
{
    partial class REGISTROS
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.datagridPersona = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevo.Location = new System.Drawing.Point(68, 70);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(105, 38);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // datagridPersona
            // 
            this.datagridPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPersona.Location = new System.Drawing.Point(68, 136);
            this.datagridPersona.Name = "datagridPersona";
            this.datagridPersona.RowHeadersWidth = 62;
            this.datagridPersona.RowTemplate.Height = 28;
            this.datagridPersona.Size = new System.Drawing.Size(991, 286);
            this.datagridPersona.TabIndex = 1;
            // 
            // REGISTROS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1170, 448);
            this.Controls.Add(this.datagridPersona);
            this.Controls.Add(this.btnNuevo);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "REGISTROS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTROS";
            this.Load += new System.EventHandler(this.REGISTROS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView datagridPersona;
    }
}

