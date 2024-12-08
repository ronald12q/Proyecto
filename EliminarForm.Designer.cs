namespace Tienda_Escritorio
{
    partial class EliminarForm
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
            txtNombreProducto = new TextBox();
            btnEliminar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(127, 34);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 0;
            txtNombreProducto.TextChanged += txtNombreProducto_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(80, 119);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(192, 85);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombreProducto);
            panel1.Controls.Add(btnEliminar);
            panel1.Location = new Point(192, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 241);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Eliminar";
            // 
            // EliminarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "EliminarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EliminarForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombreProducto;
        private Button btnEliminar;
        private Panel panel1;
        private Label label1;
    }
}