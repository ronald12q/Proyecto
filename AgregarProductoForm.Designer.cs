namespace Tienda_Escritorio
{
    partial class AgregarProductoForm
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
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtCategoria = new TextBox();
            btnGuardar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(124, 84);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(124, 137);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PlaceholderText = "Categoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(85, 193);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(174, 67);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtCategoria);
            panel1.Location = new Point(237, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 286);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 5;
            label1.Text = "Producto";
            // 
            // AgregarProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 519);
            Controls.Add(panel1);
            Name = "AgregarProductoForm";
            Text = "AgregarProductoForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtCategoria;
        private Button btnGuardar;
        private Panel panel1;
        private Label label1;
    }
}