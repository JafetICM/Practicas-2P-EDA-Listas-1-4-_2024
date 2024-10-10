namespace AprobadosReprobadosApp
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarResultados = new System.Windows.Forms.Button();
            this.lstAprobados = new System.Windows.Forms.ListBox();
            this.lstReprobados = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblAprobados = new System.Windows.Forms.Label();
            this.lblReprobados = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(6, 75);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 20);
            this.txtCalificacion.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 111);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Alumno";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarResultados
            // 
            this.btnMostrarResultados.Location = new System.Drawing.Point(6, 149);
            this.btnMostrarResultados.Name = "btnMostrarResultados";
            this.btnMostrarResultados.Size = new System.Drawing.Size(100, 23);
            this.btnMostrarResultados.TabIndex = 3;
            this.btnMostrarResultados.Text = "Mostrar Resultados";
            this.btnMostrarResultados.UseVisualStyleBackColor = true;
            this.btnMostrarResultados.Click += new System.EventHandler(this.btnMostrarResultados_Click);
            // 
            // lstAprobados
            // 
            this.lstAprobados.FormattingEnabled = true;
            this.lstAprobados.Location = new System.Drawing.Point(172, 28);
            this.lstAprobados.Name = "lstAprobados";
            this.lstAprobados.Size = new System.Drawing.Size(120, 147);
            this.lstAprobados.TabIndex = 4;
            // 
            // lstReprobados
            // 
            this.lstReprobados.FormattingEnabled = true;
            this.lstReprobados.Location = new System.Drawing.Point(319, 28);
            this.lstReprobados.Name = "lstReprobados";
            this.lstReprobados.Size = new System.Drawing.Size(120, 147);
            this.lstReprobados.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(6, 59);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(61, 13);
            this.lblCalificacion.TabIndex = 7;
            this.lblCalificacion.Text = "Calificación";
            // 
            // lblAprobados
            // 
            this.lblAprobados.AutoSize = true;
            this.lblAprobados.Location = new System.Drawing.Point(172, 12);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(60, 13);
            this.lblAprobados.TabIndex = 8;
            this.lblAprobados.Text = "Aprobados";
            // 
            // lblReprobados
            // 
            this.lblReprobados.AutoSize = true;
            this.lblReprobados.Location = new System.Drawing.Point(316, 12);
            this.lblReprobados.Name = "lblReprobados";
            this.lblReprobados.Size = new System.Drawing.Size(67, 13);
            this.lblReprobados.TabIndex = 9;
            this.lblReprobados.Text = "Reprobados";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtNombre);
            this.groupBox.Controls.Add(this.txtCalificacion);
            this.groupBox.Controls.Add(this.btnAgregar);
            this.groupBox.Controls.Add(this.btnMostrarResultados);
            this.groupBox.Controls.Add(this.lblNombre);
            this.groupBox.Controls.Add(this.lblCalificacion);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(140, 190);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Datos del Alumno";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(457, 214);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lblReprobados);
            this.Controls.Add(this.lblAprobados);
            this.Controls.Add(this.lstReprobados);
            this.Controls.Add(this.lstAprobados);
            this.Name = "Form1";
            this.Text = "Aprobados y Reprobados";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarResultados;
        private System.Windows.Forms.ListBox lstAprobados;
        private System.Windows.Forms.ListBox lstReprobados;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblAprobados;
        private System.Windows.Forms.Label lblReprobados;
        private System.Windows.Forms.GroupBox groupBox;
    }
}
