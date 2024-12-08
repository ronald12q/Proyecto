namespace Tienda_Escritorio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            TxtUsuario = new TextBox();
            TxtContraseña = new TextBox();
            BtnRegistro = new Button();
            btnIniciarSesion = new Button();
            BtnOlvide_Contraseña = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            button4 = new Button();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 865);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(1, 362);
            label2.Name = "label2";
            label2.Size = new Size(638, 84);
            label2.TabIndex = 1;
            label2.Text = "Bienvenido a CyberHive: Tu Portal de Innovación Tecnológica\r\n\r\n\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Californian FB", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 89);
            label1.Name = "label1";
            label1.Size = new Size(241, 55);
            label1.TabIndex = 0;
            label1.Text = "CyberHive";
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(62, 32);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.PlaceholderText = "Usuario";
            TxtUsuario.Size = new Size(309, 23);
            TxtUsuario.TabIndex = 1;
            // 
            // TxtContraseña
            // 
            TxtContraseña.Location = new Point(62, 118);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PlaceholderText = "Contraseña";
            TxtContraseña.Size = new Size(309, 23);
            TxtContraseña.TabIndex = 2;
            TxtContraseña.UseSystemPasswordChar = true;
            // 
            // BtnRegistro
            // 
            BtnRegistro.BackColor = SystemColors.ActiveCaption;
            BtnRegistro.FlatStyle = FlatStyle.Flat;
            BtnRegistro.Location = new Point(296, 209);
            BtnRegistro.Name = "BtnRegistro";
            BtnRegistro.Size = new Size(75, 23);
            BtnRegistro.TabIndex = 3;
            BtnRegistro.Text = "Registrarse";
            BtnRegistro.UseVisualStyleBackColor = false;
            BtnRegistro.Click += BtnRegistro_Click;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = SystemColors.ActiveCaption;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.ForeColor = SystemColors.ActiveCaptionText;
            btnIniciarSesion.Location = new Point(154, 209);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(106, 23);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // BtnOlvide_Contraseña
            // 
            BtnOlvide_Contraseña.BackColor = SystemColors.ActiveCaption;
            BtnOlvide_Contraseña.BackgroundImageLayout = ImageLayout.None;
            BtnOlvide_Contraseña.FlatStyle = FlatStyle.Flat;
            BtnOlvide_Contraseña.Location = new Point(154, 154);
            BtnOlvide_Contraseña.Name = "BtnOlvide_Contraseña";
            BtnOlvide_Contraseña.RightToLeft = RightToLeft.No;
            BtnOlvide_Contraseña.Size = new Size(217, 23);
            BtnOlvide_Contraseña.TabIndex = 5;
            BtnOlvide_Contraseña.Text = "Olvide mi Contraseña";
            BtnOlvide_Contraseña.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnOlvide_Contraseña.UseVisualStyleBackColor = false;
            BtnOlvide_Contraseña.Click += BtnOlvide_Contraseña_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.ForeColor = SystemColors.ButtonHighlight;
            panel2.ImeMode = ImeMode.Hiragana;
            panel2.Location = new Point(33, 118);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(21, 24);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Location = new Point(33, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(23, 27);
            panel3.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(62, 147);
            button4.Name = "button4";
            button4.Size = new Size(28, 30);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(TxtUsuario);
            panel4.Controls.Add(BtnRegistro);
            panel4.Controls.Add(btnIniciarSesion);
            panel4.Controls.Add(BtnOlvide_Contraseña);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(TxtContraseña);
            panel4.Location = new Point(825, 297);
            panel4.Name = "panel4";
            panel4.Size = new Size(392, 276);
            panel4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 15);
            label4.TabIndex = 11;
            label4.Text = "Usuarios y Administradores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poor Richard", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(858, 136);
            label3.Name = "label3";
            label3.Size = new Size(324, 73);
            label3.TabIndex = 10;
            label3.Text = "Menu Inicio\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1398, 869);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox TxtUsuario;
        private TextBox TxtContraseña;
        private Button BtnRegistro;
        private Button btnIniciarSesion;
        private Panel panel2;
        private Panel panel3;
        private Button button4;
        public Button BtnOlvide_Contraseña;
        private Panel panel4;
        private Label label4;
        private Label label3;
    }
}
