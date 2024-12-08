namespace Tienda_Escritorio
{
    partial class Contraseña_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contraseña_Form));
            TxtNombre = new TextBox();
            TxtContraseña = new TextBox();
            Btn_Restablecer = new Button();
            Btn_Regresar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(115, 49);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.PlaceholderText = "Usuario";
            TxtNombre.Size = new Size(160, 23);
            TxtNombre.TabIndex = 0;
            // 
            // TxtContraseña
            // 
            TxtContraseña.Location = new Point(115, 105);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PlaceholderText = "Nueva Contraseña";
            TxtContraseña.Size = new Size(160, 23);
            TxtContraseña.TabIndex = 1;
            TxtContraseña.UseSystemPasswordChar = true;
            // 
            // Btn_Restablecer
            // 
            Btn_Restablecer.Location = new Point(115, 149);
            Btn_Restablecer.Name = "Btn_Restablecer";
            Btn_Restablecer.Size = new Size(75, 23);
            Btn_Restablecer.TabIndex = 2;
            Btn_Restablecer.Text = "Restablecer";
            Btn_Restablecer.UseVisualStyleBackColor = true;
            Btn_Restablecer.Click += Btn_Restablecer_Click_1;
            // 
            // Btn_Regresar
            // 
            Btn_Regresar.Location = new Point(200, 149);
            Btn_Regresar.Name = "Btn_Regresar";
            Btn_Regresar.Size = new Size(75, 23);
            Btn_Regresar.TabIndex = 3;
            Btn_Regresar.Text = "Regresar";
            Btn_Regresar.UseVisualStyleBackColor = true;
            Btn_Regresar.Click += Btn_Regresar_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(78, 105);
            button1.Name = "button1";
            button1.Size = new Size(31, 32);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Contraseña_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 222);
            Controls.Add(button1);
            Controls.Add(Btn_Regresar);
            Controls.Add(Btn_Restablecer);
            Controls.Add(TxtContraseña);
            Controls.Add(TxtNombre);
            Name = "Contraseña_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contraseña_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNombre;
        private TextBox TxtContraseña;
        private Button Btn_Restablecer;
        private Button Btn_Regresar;
        private Button button1;
    }
}