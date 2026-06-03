namespace ProyectoTienda
{
    partial class Acceso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textusuario = new TextBox();
            label3 = new Label();
            textcontraseña = new TextBox();
            btniniciar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 31);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Acceso";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 62);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // textusuario
            // 
            textusuario.Location = new Point(46, 90);
            textusuario.Name = "textusuario";
            textusuario.Size = new Size(189, 23);
            textusuario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 133);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // textcontraseña
            // 
            textcontraseña.Location = new Point(46, 164);
            textcontraseña.Name = "textcontraseña";
            textcontraseña.PasswordChar = '*';
            textcontraseña.Size = new Size(189, 23);
            textcontraseña.TabIndex = 4;
            textcontraseña.TextChanged += textcontraseña_TextChanged;
            // 
            // btniniciar
            // 
            btniniciar.Location = new Point(91, 206);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(113, 43);
            btniniciar.TabIndex = 5;
            btniniciar.Text = "Iniciar Sesión";
            btniniciar.UseVisualStyleBackColor = true;
            btniniciar.Click += btniniciar_Click;
            // 
            // Acceso
            // 
            AcceptButton = btniniciar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 295);
            Controls.Add(btniniciar);
            Controls.Add(textcontraseña);
            Controls.Add(label3);
            Controls.Add(textusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Acceso";
            Text = "Acceso";
            Load += Acceso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textusuario;
        private Label label3;
        private TextBox textcontraseña;
        private Button btniniciar;
    }
}
