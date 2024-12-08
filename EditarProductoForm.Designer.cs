namespace Tienda_Escritorio
{
    partial class EditarProductoForm
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
            btnGuardar = new Button();
            txtcategoria = new TextBox();
            txtprecio = new TextBox();
            txtnombre = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(99, 202);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(187, 92);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtcategoria
            // 
            txtcategoria.Location = new Point(142, 131);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.PlaceholderText = "Categoria";
            txtcategoria.Size = new Size(100, 23);
            txtcategoria.TabIndex = 1;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(142, 78);
            txtprecio.Name = "txtprecio";
            txtprecio.PlaceholderText = "Precio";
            txtprecio.Size = new Size(100, 23);
            txtprecio.TabIndex = 2;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(142, 26);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Nombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtnombre);
            panel1.Controls.Add(txtprecio);
            panel1.Controls.Add(txtcategoria);
            panel1.Location = new Point(224, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 297);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Editar";
            // 
            // EditarProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(868, 445);
            Controls.Add(panel1);
            Name = "EditarProductoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarProductoForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtcategoria;
        private TextBox txtprecio;
        private TextBox txtnombre;
        private Panel panel1;
        private Label label1;
    }
}