namespace WebServiceClient
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
            this.BtnFind = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlanet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(161, 250);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(165, 58);
            this.BtnFind.TabIndex = 0;
            this.BtnFind.Text = "Introducir Rebelde";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(268, 73);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 26);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduzca Nombre del Rebelde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introduzca el planeta";
            // 
            // txtPlanet
            // 
            this.txtPlanet.Location = new System.Drawing.Point(268, 137);
            this.txtPlanet.MaxLength = 50;
            this.txtPlanet.Name = "txtPlanet";
            this.txtPlanet.Size = new System.Drawing.Size(183, 26);
            this.txtPlanet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registro Encontrado";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(268, 191);
            this.txtFind.MaxLength = 50;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(183, 26);
            this.txtFind.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 320);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlanet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.BtnFind);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlanet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFind;
    }
}

