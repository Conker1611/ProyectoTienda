namespace ProyectoTienda
{
    partial class Menu
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
            button1 = new Button();
            btninventario = new Button();
            btnFiado = new Button();
            btnVentas = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 32);
            button1.Name = "button1";
            button1.Size = new Size(227, 114);
            button1.TabIndex = 0;
            button1.Text = "Caja";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btninventario
            // 
            btninventario.Location = new Point(281, 32);
            btninventario.Name = "btninventario";
            btninventario.Size = new Size(232, 114);
            btninventario.TabIndex = 1;
            btninventario.Text = "Inventario";
            btninventario.UseVisualStyleBackColor = true;
            btninventario.Click += button2_Click;
            // 
            // btnFiado
            // 
            btnFiado.Location = new Point(281, 215);
            btnFiado.Name = "btnFiado";
            btnFiado.Size = new Size(232, 114);
            btnFiado.TabIndex = 2;
            btnFiado.Text = "Fiado";
            btnFiado.UseVisualStyleBackColor = true;
            btnFiado.Click += button3_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(22, 215);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(227, 114);
            btnVentas.TabIndex = 4;
            btnVentas.Text = "Historial de ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 388);
            Controls.Add(btnVentas);
            Controls.Add(btnFiado);
            Controls.Add(btninventario);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btninventario;
        private Button btnFiado;
        private Button button4;
        private Button btnVentas;
        private Button button6;
    }
}