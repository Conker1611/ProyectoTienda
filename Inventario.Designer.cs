namespace ProyectoTienda
{
    partial class Inventario
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
            btnagregar = new Button();
            btnatras = new Button();
            txtBuscar = new TextBox();
            btneditar = new Button();
            dgvProductos = new DataGridView();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(782, 71);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(164, 67);
            btnagregar.TabIndex = 0;
            btnagregar.Text = "Agregar producto";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // btnatras
            // 
            btnatras.Location = new Point(782, 461);
            btnatras.Name = "btnatras";
            btnatras.Size = new Size(164, 69);
            btnatras.TabIndex = 1;
            btnatras.Text = "Atrás";
            btnatras.UseVisualStyleBackColor = true;
            btnatras.Click += btnatras_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(31, 27);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(432, 23);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += textBox1_TextChanged;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(782, 157);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(164, 70);
            btneditar.TabIndex = 3;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(31, 71);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(735, 459);
            dgvProductos.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(783, 246);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(163, 78);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 554);
            Controls.Add(btnGuardar);
            Controls.Add(dgvProductos);
            Controls.Add(btneditar);
            Controls.Add(txtBuscar);
            Controls.Add(btnatras);
            Controls.Add(btnagregar);
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnagregar;
        private Button btnatras;
        private TextBox txtBuscar;
        private Button btneditar;
        private DataGridView dgvProductos;
        private Button btnGuardar;
    }
}