namespace ProyectoTienda
{
    partial class Ventas
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
            label1 = new Label();
            label2 = new Label();
            dgvVentas = new DataGridView();
            dgvStockBajo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Ventas del día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 230);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Stock bajo";
            label2.Click += label2_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(26, 45);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(739, 164);
            dgvVentas.TabIndex = 2;
            // 
            // dgvStockBajo
            // 
            dgvStockBajo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockBajo.Location = new Point(30, 260);
            dgvStockBajo.Name = "dgvStockBajo";
            dgvStockBajo.Size = new Size(737, 177);
            dgvStockBajo.TabIndex = 3;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStockBajo);
            Controls.Add(dgvVentas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvVentas;
        private DataGridView dgvStockBajo;
    }
}