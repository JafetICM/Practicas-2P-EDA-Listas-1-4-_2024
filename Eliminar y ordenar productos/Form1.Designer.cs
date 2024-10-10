namespace EliminarOrdenarProductosApp
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
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtClaveProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnMostrarOrdenados = new System.Windows.Forms.Button();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblTotalCosto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(20, 50); // Posición ajustada
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(180, 20);  // Ancho ajustado
            this.txtNombreProducto.TabIndex = 0;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(20, 100);  // Posición ajustada
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(180, 20);  // Ancho ajustado
            this.txtPrecioProducto.TabIndex = 1;
            // 
            // txtClaveProducto
            // 
            this.txtClaveProducto.Location = new System.Drawing.Point(20, 150);  // Posición ajustada
            this.txtClaveProducto.Name = "txtClaveProducto";
            this.txtClaveProducto.Size = new System.Drawing.Size(180, 20);  // Ancho ajustado
            this.txtClaveProducto.TabIndex = 2;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(220, 50);  // Posición ajustada
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(120, 23);  // Tamaño ajustado
            this.btnAgregarProducto.TabIndex = 3;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(220, 150);  // Posición ajustada
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(120, 23);  // Tamaño ajustado
            this.btnEliminarProducto.TabIndex = 4;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnMostrarOrdenados
            // 
            this.btnMostrarOrdenados.Location = new System.Drawing.Point(220, 200);  // Posición ajustada
            this.btnMostrarOrdenados.Name = "btnMostrarOrdenados";
            this.btnMostrarOrdenados.Size = new System.Drawing.Size(120, 23);  // Tamaño ajustado
            this.btnMostrarOrdenados.TabIndex = 5;
            this.btnMostrarOrdenados.Text = "Ordenar Productos";
            this.btnMostrarOrdenados.UseVisualStyleBackColor = true;
            this.btnMostrarOrdenados.Click += new System.EventHandler(this.btnMostrarOrdenados_Click);
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.Location = new System.Drawing.Point(220, 250);  // Posición ajustada
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(120, 23);  // Tamaño ajustado
            this.btnCalcularTotal.TabIndex = 6;
            this.btnCalcularTotal.Text = "Calcular Total";
            this.btnCalcularTotal.UseVisualStyleBackColor = true;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(380, 50);  // Posición ajustada
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(250, 160);  // Ancho ajustado
            this.lstProductos.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 30);  // Posición ajustada
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre Producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 80);  // Posición ajustada
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(79, 13);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio Producto";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(20, 130);  // Posición ajustada
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(77, 13);
            this.lblClave.TabIndex = 10;
            this.lblClave.Text = "Clave Producto";
            // 
            // lblTotalCosto
            // 
            this.lblTotalCosto.AutoSize = true;
            this.lblTotalCosto.Location = new System.Drawing.Point(380, 250);  // Posición ajustada
            this.lblTotalCosto.Name = "lblTotalCosto";
            this.lblTotalCosto.Size = new System.Drawing.Size(76, 13);
            this.lblTotalCosto.TabIndex = 11;
            this.lblTotalCosto.Text = "Costo Total: $0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(700, 350);  // Tamaño de formulario ajustado
            this.Controls.Add(this.lblTotalCosto);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnCalcularTotal);
            this.Controls.Add(this.btnMostrarOrdenados);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtClaveProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Name = "Form1";
            this.Text = "Eliminar y Ordenar Productos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtClaveProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnMostrarOrdenados;
        private System.Windows.Forms.Button btnCalcularTotal;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblTotalCosto;
    }
}
