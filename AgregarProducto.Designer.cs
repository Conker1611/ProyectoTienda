namespace ProyectoTienda
{
    partial class AgregarProducto
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
            btnGuardar = new Button();
            btncancelar1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(155, 135);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 51);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // btncancelar1
            // 
            btncancelar1.Location = new Point(300, 135);
            btncancelar1.Name = "btncancelar1";
            btncancelar1.Size = new Size(106, 51);
            btncancelar1.TabIndex = 1;
            btncancelar1.Text = "Cancelar";
            btncancelar1.UseVisualStyleBackColor = true;
            btncancelar1.Click += btncancelar1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 48);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 48);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 48);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 48);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Stock";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(28, 75);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(99, 23);
            txtCodigo.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(99, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(300, 75);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(99, 23);
            txtPrecio.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(439, 75);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(99, 23);
            txtStock.TabIndex = 9;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 216);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btncancelar1);
            Controls.Add(btnGuardar);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            Load += AgregarProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btncancelar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
    }
}