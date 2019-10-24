namespace WFR_File
{
    partial class FrmParte
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
            this.txtFolders = new System.Windows.Forms.TextBox();
            this.txtRoutes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExcludes = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFolders
            // 
            this.txtFolders.Location = new System.Drawing.Point(20, 50);
            this.txtFolders.Multiline = true;
            this.txtFolders.Name = "txtFolders";
            this.txtFolders.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFolders.Size = new System.Drawing.Size(350, 150);
            this.txtFolders.TabIndex = 0;
            // 
            // txtRoutes
            // 
            this.txtRoutes.Location = new System.Drawing.Point(410, 50);
            this.txtRoutes.Multiline = true;
            this.txtRoutes.Name = "txtRoutes";
            this.txtRoutes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRoutes.Size = new System.Drawing.Size(350, 150);
            this.txtRoutes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carpetas locales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rutas FTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Extensiones excluidas";
            // 
            // txtExcludes
            // 
            this.txtExcludes.Location = new System.Drawing.Point(20, 237);
            this.txtExcludes.Name = "txtExcludes";
            this.txtExcludes.Size = new System.Drawing.Size(740, 20);
            this.txtExcludes.TabIndex = 5;
            this.txtExcludes.Text = ".config;.datasource";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(327, 272);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(137, 39);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copiar a Portapapeles";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.Copy);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(82, 309);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(16, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "...";
            // 
            // FrmParte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 334);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtExcludes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoutes);
            this.Controls.Add(this.txtFolders);
            this.Name = "FrmParte";
            this.Text = "Parte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolders;
        private System.Windows.Forms.TextBox txtRoutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExcludes;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
    }
}

