namespace Tienda_Escritorio
{
    partial class AdminForm
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
            btnCerrarSesion = new Button();
            btnEditarProducto = new Button();
            btnEliminarProducto = new Button();
            btnAgregarProducto = new Button();
            dataGridViewProductos = new DataGridView();
            panel1 = new Panel();
            Btn_Regresar = new Button();
            Btn_Actualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(828, 63);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(165, 74);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Salir";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(421, 63);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(153, 74);
            btnEditarProducto.TabIndex = 1;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(221, 63);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(153, 74);
            btnEliminarProducto.TabIndex = 2;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(22, 63);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(153, 74);
            btnAgregarProducto.TabIndex = 3;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(250, 458);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.Size = new Size(618, 150);
            dataGridViewProductos.TabIndex = 4;
            dataGridViewProductos.CellContentClick += dataGridViewProductos_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(Btn_Regresar);
            panel1.Controls.Add(btnAgregarProducto);
            panel1.Controls.Add(btnEliminarProducto);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(btnEditarProducto);
            panel1.Location = new Point(39, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 217);
            panel1.TabIndex = 5;
            // 
            // Btn_Regresar
            // 
            Btn_Regresar.Location = new Point(615, 63);
            Btn_Regresar.Name = "Btn_Regresar";
            Btn_Regresar.Size = new Size(153, 74);
            Btn_Regresar.TabIndex = 4;
            Btn_Regresar.Text = "Regresar";
            Btn_Regresar.UseVisualStyleBackColor = true;
            Btn_Regresar.Click += Btn_Regresar_Click;
            // 
            // Btn_Actualizar
            // 
            Btn_Actualizar.Location = new Point(793, 429);
            Btn_Actualizar.Name = "Btn_Actualizar";
            Btn_Actualizar.Size = new Size(75, 23);
            Btn_Actualizar.TabIndex = 5;
            Btn_Actualizar.Text = "Actualizar";
            Btn_Actualizar.UseVisualStyleBackColor = true;
            Btn_Actualizar.Click += Btn_Actualizar_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 793);
            Controls.Add(Btn_Actualizar);
            Controls.Add(panel1);
            Controls.Add(dataGridViewProductos);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrarSesion;
        private Button btnEditarProducto;
        private Button btnEliminarProducto;
        private Button btnAgregarProducto;
        private DataGridView dataGridViewProductos;
        private Panel panel1;
        private Button Btn_Regresar;
        private Button Btn_Actualizar;
    }
}