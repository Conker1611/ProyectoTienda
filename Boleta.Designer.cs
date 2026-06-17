namespace ProyectoTienda
{
    partial class Boleta
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
            txtNombreCliente = new TextBox();
            label1 = new Label();
            btnImprimir = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(45, 53);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(192, 23);
            txtNombreCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 25);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre del cliente";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(62, 99);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(91, 49);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(203, 99);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 49);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Boleta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 178);
            Controls.Add(btnCancelar);
            Controls.Add(btnImprimir);
            Controls.Add(label1);
            Controls.Add(txtNombreCliente);
            Name = "Boleta";
            Text = "Boleta";
            Load += Boleta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreCliente;
        private Label label1;
        private Button btnImprimir;
        private Button btnCancelar;
    }
}