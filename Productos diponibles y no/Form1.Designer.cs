namespace SupermercadoApp
{
    partial class Form1
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnRetirarProducto = new System.Windows.Forms.Button();
            this.btnMostrarDisponibles = new System.Windows.Forms.Button();
            this.btnMostrarRetirados = new System.Windows.Forms.Button();
            this.lstDisponibles = new System.Windows.Forms.ListBox();
            this.lstRetirados = new System.Windows.Forms.ListBox();
            this.lblDisponibles = new System.Windows.Forms.Label();
            this.lblRetirados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(150, 23);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnRetirarProducto
            // 
            this.btnRetirarProducto.Location = new System.Drawing.Point(12, 41);
            this.btnRetirarProducto.Name = "btnRetirarProducto";
            this.btnRetirarProducto.Size = new System.Drawing.Size(150, 23);
            this.btnRetirarProducto.TabIndex = 1;
            this.btnRetirarProducto.Text = "Retirar Producto";
            this.btnRetirarProducto.UseVisualStyleBackColor = true;
            this.btnRetirarProducto.Click += new System.EventHandler(this.btnRetirarProducto_Click);
            // 
            // btnMostrarDisponibles
            // 
            this.btnMostrarDisponibles.Location = new System.Drawing.Point(12, 70);
            this.btnMostrarDisponibles.Name = "btnMostrarDisponibles";
            this.btnMostrarDisponibles.Size = new System.Drawing.Size(150, 23);
            this.btnMostrarDisponibles.TabIndex = 2;
            this.btnMostrarDisponibles.Text = "Mostrar Disponibles";
            this.btnMostrarDisponibles.UseVisualStyleBackColor = true;
            this.btnMostrarDisponibles.Click += new System.EventHandler(this.btnMostrarDisponibles_Click);
            // 
            // btnMostrarRetirados
            // 
            this.btnMostrarRetirados.Location = new System.Drawing.Point(12, 99);
            this.btnMostrarRetirados.Name = "btnMostrarRetirados";
            this.btnMostrarRetirados.Size = new System.Drawing.Size(150, 23);
            this.btnMostrarRetirados.TabIndex = 3;
            this.btnMostrarRetirados.Text = "Mostrar Retirados";
            this.btnMostrarRetirados.UseVisualStyleBackColor = true;
            this.btnMostrarRetirados.Click += new System.EventHandler(this.btnMostrarRetirados_Click);
            // 
            // lstDisponibles
            // 
            this.lstDisponibles.FormattingEnabled = true;
            this.lstDisponibles.Location = new System.Drawing.Point(200, 12);
            this.lstDisponibles.Name = "lstDisponibles";
            this.lstDisponibles.Size = new System.Drawing.Size(150, 186);
            this.lstDisponibles.TabIndex = 4;
            // 
            // lstRetirados
            // 
            this.lstRetirados.FormattingEnabled = true;
            this.lstRetirados.Location = new System.Drawing.Point(370, 12);
            this.lstRetirados.Name = "lstRetirados";
            this.lstRetirados.Size = new System.Drawing.Size(150, 186);
            this.lstRetirados.TabIndex = 5;
            // 
            // lblDisponibles
            // 
            this.lblDisponibles.AutoSize = true;
            this.lblDisponibles.Location = new System.Drawing.Point(200, 200);
            this.lblDisponibles.Name = "lblDisponibles";
            this.lblDisponibles.Size = new System.Drawing.Size(104, 13);
            this.lblDisponibles.TabIndex = 6;
            this.lblDisponibles.Text = "Productos Disponibles";
            // 
            // lblRetirados
            // 
            this.lblRetirados.AutoSize = true;
            this.lblRetirados.Location = new System.Drawing.Point(370, 200);
            this.lblRetirados.Name = "lblRetirados";
            this.lblRetirados.Size = new System.Drawing.Size(97, 13);
            this.lblRetirados.TabIndex = 7;
            this.lblRetirados.Text = "Productos Retirados";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(534, 221);
            this.Controls.Add(this.lblRetirados);
            this.Controls.Add(this.lblDisponibles);
            this.Controls.Add(this.lstRetirados);
            this.Controls.Add(this.lstDisponibles);
            this.Controls.Add(this.btnMostrarRetirados);
            this.Controls.Add(this.btnMostrarDisponibles);
            this.Controls.Add(this.btnRetirarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Name = "Form1";
            this.Text = "Supermercado - Productos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnRetirarProducto;
        private System.Windows.Forms.Button btnMostrarDisponibles;
        private System.Windows.Forms.Button btnMostrarRetirados;
        private System.Windows.Forms.ListBox lstDisponibles;
        private System.Windows.Forms.ListBox lstRetirados;
        private System.Windows.Forms.Label lblDisponibles;
        private System.Windows.Forms.Label lblRetirados;

        #endregion
    }
}
