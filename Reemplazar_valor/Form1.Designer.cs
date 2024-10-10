namespace ReemplazarValorEnPilaApp
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
            this.lstPila = new System.Windows.Forms.ListBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtValorViejo = new System.Windows.Forms.TextBox();
            this.txtValorNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(20, 20);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(150, 160);
            this.lstPila.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(200, 20);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // txtValorViejo
            // 
            this.txtValorViejo.Location = new System.Drawing.Point(200, 60);
            this.txtValorViejo.Name = "txtValorViejo";
            this.txtValorViejo.Size = new System.Drawing.Size(100, 20);
            this.txtValorViejo.TabIndex = 2;
            // 
            // txtValorNuevo
            // 
            this.txtValorNuevo.Location = new System.Drawing.Point(200, 100);
            this.txtValorNuevo.Name = "txtValorNuevo";
            this.txtValorNuevo.Size = new System.Drawing.Size(100, 20);
            this.txtValorNuevo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(320, 20);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar a la Pila";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Location = new System.Drawing.Point(320, 100);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(100, 23);
            this.btnReemplazar.TabIndex = 5;
            this.btnReemplazar.Text = "Reemplazar";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(20, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(67, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado: --";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtValorNuevo);
            this.Controls.Add(this.txtValorViejo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lstPila);
            this.Name = "Form1";
            this.Text = "Reemplazar Valor en Pila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtValorViejo;
        private System.Windows.Forms.TextBox txtValorNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.Label lblResultado;
    }
}
