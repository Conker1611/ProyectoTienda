namespace ProyectoTienda
{
    partial class Fiado
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
            dgvFiados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFiados).BeginInit();
            SuspendLayout();
            // 
            // dgvFiados
            // 
            dgvFiados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFiados.Location = new Point(50, 28);
            dgvFiados.Name = "dgvFiados";
            dgvFiados.Size = new Size(694, 396);
            dgvFiados.TabIndex = 0;
            dgvFiados.CellClick += dgvFiados_CellClick;
            // 
            // Fiado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvFiados);
            Name = "Fiado";
            Text = "Fiado";
            Load += Fiado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFiados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFiados;
    }
}