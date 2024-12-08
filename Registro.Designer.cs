namespace Tienda_Escritorio
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            BtnRegistro_EnRegistro = new Button();
            TxtContraseña_Re = new TextBox();
            TxtNombre_RE = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(BtnRegistro_EnRegistro);
            panel1.Controls.Add(TxtContraseña_Re);
            panel1.Controls.Add(TxtNombre_RE);
            panel1.Controls.Add(label1);
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(371, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 398);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(351, 224);
            button1.Name = "button1";
            button1.Size = new Size(36, 37);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(578, 267);
            button2.Name = "button2";
            button2.Size = new Size(75, 62);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BtnRegistro_EnRegistro
            // 
            BtnRegistro_EnRegistro.FlatStyle = FlatStyle.Flat;
            BtnRegistro_EnRegistro.ForeColor = SystemColors.ActiveCaption;
            BtnRegistro_EnRegistro.Image = (Image)resources.GetObject("BtnRegistro_EnRegistro.Image");
            BtnRegistro_EnRegistro.Location = new Point(351, 267);
            BtnRegistro_EnRegistro.Name = "BtnRegistro_EnRegistro";
            BtnRegistro_EnRegistro.Size = new Size(75, 65);
            BtnRegistro_EnRegistro.TabIndex = 4;
            BtnRegistro_EnRegistro.UseVisualStyleBackColor = true;
            BtnRegistro_EnRegistro.Click += BtnRegistro_EnRegistro_Click;
            // 
            // TxtContraseña_Re
            // 
            TxtContraseña_Re.Location = new Point(351, 195);
            TxtContraseña_Re.Name = "TxtContraseña_Re";
            TxtContraseña_Re.PlaceholderText = "Contraseña";
            TxtContraseña_Re.Size = new Size(302, 23);
            TxtContraseña_Re.TabIndex = 3;
            TxtContraseña_Re.UseSystemPasswordChar = true;
            // 
            // TxtNombre_RE
            // 
            TxtNombre_RE.Location = new Point(351, 123);
            TxtNombre_RE.Name = "TxtNombre_RE";
            TxtNombre_RE.PlaceholderText = "Nombre ";
            TxtNombre_RE.Size = new Size(302, 23);
            TxtNombre_RE.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 55);
            label1.TabIndex = 0;
            label1.Text = "Registro";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1375, 850);
            Controls.Add(panel1);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button BtnRegistro_EnRegistro;
        private TextBox TxtContraseña_Re;
        private TextBox TxtNombre_RE;
        private Label label1;
        private Button button1;
    }
}