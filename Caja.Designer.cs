namespace ProyectoTienda
{
    partial class Caja
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
            btnatras = new Button();
            btnBoleta = new Button();
            btnFiado = new Button();
            label1 = new Label();
            txtMonto = new TextBox();
            btnCobrar = new Button();
            btnAgregar = new Button();
            dgvCaja = new DataGridView();
            lblTotal = new Label();
            lblVuelto = new Label();
            buscadorbox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCaja).BeginInit();
            SuspendLayout();
            // 
            // btnatras
            // 
            btnatras.Location = new Point(529, 497);
            btnatras.Name = "btnatras";
            btnatras.Size = new Size(178, 80);
            btnatras.TabIndex = 0;
            btnatras.Text = "Atrás";
            btnatras.UseVisualStyleBackColor = true;
            btnatras.Click += btnatras_Click;
            // 
            // btnBoleta
            // 
            btnBoleta.Location = new Point(529, 31);
            btnBoleta.Name = "btnBoleta";
            btnBoleta.Size = new Size(178, 80);
            btnBoleta.TabIndex = 1;
            btnBoleta.Text = "Boleta";
            btnBoleta.UseVisualStyleBackColor = true;
            btnBoleta.Click += btnImpresion_Click;
            // 
            // btnFiado
            // 
            btnFiado.Location = new Point(529, 127);
            btnFiado.Name = "btnFiado";
            btnFiado.Size = new Size(178, 80);
            btnFiado.TabIndex = 2;
            btnFiado.Text = "Fiado";
            btnFiado.UseVisualStyleBackColor = true;
            btnFiado.Click += btnFiado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(529, 225);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Monto recibido";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(529, 253);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(178, 23);
            txtMonto.TabIndex = 4;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(529, 359);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(178, 80);
            btnCobrar.TabIndex = 5;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(370, 31);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 39);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvCaja
            // 
            dgvCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaja.Location = new Point(48, 89);
            dgvCaja.Name = "dgvCaja";
            dgvCaja.Size = new Size(445, 407);
            dgvCaja.TabIndex = 8;
            dgvCaja.CellContentClick += dgvCaja_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(309, 530);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 15);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "TOTAL:";
            lblTotal.Click += lblTotal_Click;
            // 
            // lblVuelto
            // 
            lblVuelto.AutoSize = true;
            lblVuelto.Location = new Point(529, 300);
            lblVuelto.Name = "lblVuelto";
            lblVuelto.Size = new Size(44, 15);
            lblVuelto.TabIndex = 10;
            lblVuelto.Text = "Vuelto:";
            // 
            // buscadorbox
            // 
            buscadorbox.FormattingEnabled = true;
            buscadorbox.Location = new Point(57, 40);
            buscadorbox.Name = "buscadorbox";
            buscadorbox.Size = new Size(273, 23);
            buscadorbox.TabIndex = 11;
            buscadorbox.SelectedIndexChanged += buscadorbox_SelectedIndexChanged;
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 617);
            Controls.Add(buscadorbox);
            Controls.Add(lblVuelto);
            Controls.Add(lblTotal);
            Controls.Add(dgvCaja);
            Controls.Add(btnAgregar);
            Controls.Add(btnCobrar);
            Controls.Add(txtMonto);
            Controls.Add(label1);
            Controls.Add(btnFiado);
            Controls.Add(btnBoleta);
            Controls.Add(btnatras);
            Name = "Caja";
            Text = "Caja";
            Load += Caja_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCaja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnatras;
        private Button btnBoleta;
        private Button btnFiado;
        private Label label1;
        private TextBox txtMonto;
        private Button btnCobrar;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private DataGridView dgvCaja;
        private Label lblTotal;
        private Label lblVuelto;
        private ComboBox buscadorbox;
    }
}