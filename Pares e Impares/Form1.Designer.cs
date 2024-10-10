namespace ParesImparesApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lstPares = new System.Windows.Forms.ListBox();
            this.lstImpares = new System.Windows.Forms.ListBox();
            this.lblPares = new System.Windows.Forms.Label();
            this.lblImpares = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(6, 19);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(6, 45);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar Números";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lstPares
            // 
            this.lstPares.FormattingEnabled = true;
            this.lstPares.Location = new System.Drawing.Point(163, 12);
            this.lstPares.Name = "lstPares";
            this.lstPares.Size = new System.Drawing.Size(120, 160);
            this.lstPares.TabIndex = 2;
            // 
            // lstImpares
            // 
            this.lstImpares.FormattingEnabled = true;
            this.lstImpares.Location = new System.Drawing.Point(310, 12);
            this.lstImpares.Name = "lstImpares";
            this.lstImpares.Size = new System.Drawing.Size(120, 160);
            this.lstImpares.TabIndex = 3;
            // 
            // lblPares
            // 
            this.lblPares.AutoSize = true;
            this.lblPares.Location = new System.Drawing.Point(163, 175);
            this.lblPares.Name = "lblPares";
            this.lblPares.Size = new System.Drawing.Size(84, 13);
            this.lblPares.TabIndex = 4;
            this.lblPares.Text = "Números Pares:";
            // 
            // lblImpares
            // 
            this.lblImpares.AutoSize = true;
            this.lblImpares.Location = new System.Drawing.Point(310, 175);
            this.lblImpares.Name = "lblImpares";
            this.lblImpares.Size = new System.Drawing.Size(91, 13);
            this.lblImpares.TabIndex = 5;
            this.lblImpares.Text = "Números Impares:";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtCantidad);
            this.groupBox.Controls.Add(this.btnGenerar);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(128, 160);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Generar Números";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(454, 211);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lblImpares);
            this.Controls.Add(this.lblPares);
            this.Controls.Add(this.lstImpares);
            this.Controls.Add(this.lstPares);
            this.Name = "Form1";
            this.Text = "Pares e Impares";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListBox lstPares;
        private System.Windows.Forms.ListBox lstImpares;
        private System.Windows.Forms.Label lblPares;
        private System.Windows.Forms.Label lblImpares;
        private System.Windows.Forms.GroupBox groupBox;
    }
}
