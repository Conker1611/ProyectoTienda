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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
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
            // button3
            // 
            button3.Location = new Point(539, 32);
            button3.Name = "button3";
            button3.Size = new Size(232, 114);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(22, 236);
            button4.Name = "button4";
            button4.Size = new Size(227, 114);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(281, 236);
            button5.Name = "button5";
            button5.Size = new Size(227, 114);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(539, 236);
            button6.Name = "button6";
            button6.Size = new Size(227, 114);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
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
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}