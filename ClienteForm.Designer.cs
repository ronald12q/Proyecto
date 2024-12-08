namespace Tienda_Escritorio
{
    partial class ClienteForm
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
            panel1 = new Panel();
            btnFinalizarCompra = new Button();
            labelTotal = new Label();
            listBoxCarrito = new ListBox();
            panel2 = new Panel();
            Btn_Actualizar = new Button();
            Btn_Regresar = new Button();
            btnAgregarAlCarrito = new Button();
            dataGridViewProductos = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFinalizarCompra);
            panel1.Controls.Add(labelTotal);
            panel1.Controls.Add(listBoxCarrito);
            panel1.Location = new Point(12, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 551);
            panel1.TabIndex = 0;
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.Location = new Point(12, 501);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(75, 23);
            btnFinalizarCompra.TabIndex = 2;
            btnFinalizarCompra.Text = "Pagar";
            btnFinalizarCompra.UseVisualStyleBackColor = true;
            btnFinalizarCompra.Click += btnFinalizarCompra_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(12, 461);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(38, 15);
            labelTotal.TabIndex = 1;
            labelTotal.Text = "label1";
            // 
            // listBoxCarrito
            // 
            listBoxCarrito.FormattingEnabled = true;
            listBoxCarrito.ItemHeight = 15;
            listBoxCarrito.Location = new Point(12, 42);
            listBoxCarrito.Name = "listBoxCarrito";
            listBoxCarrito.Size = new Size(120, 394);
            listBoxCarrito.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(Btn_Actualizar);
            panel2.Controls.Add(Btn_Regresar);
            panel2.Controls.Add(btnAgregarAlCarrito);
            panel2.Location = new Point(12, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1243, 100);
            panel2.TabIndex = 1;
            // 
            // Btn_Actualizar
            // 
            Btn_Actualizar.Location = new Point(876, 23);
            Btn_Actualizar.Name = "Btn_Actualizar";
            Btn_Actualizar.Size = new Size(132, 52);
            Btn_Actualizar.TabIndex = 2;
            Btn_Actualizar.Text = "Actualizar";
            Btn_Actualizar.UseVisualStyleBackColor = true;
            Btn_Actualizar.Click += Btn_Actualizar_Click;
            // 
            // Btn_Regresar
            // 
            Btn_Regresar.Location = new Point(1062, 23);
            Btn_Regresar.Name = "Btn_Regresar";
            Btn_Regresar.Size = new Size(132, 52);
            Btn_Regresar.TabIndex = 1;
            Btn_Regresar.Text = "Regresar";
            Btn_Regresar.UseVisualStyleBackColor = true;
            Btn_Regresar.Click += Btn_Regresar_Click;
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.Location = new Point(666, 23);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(128, 52);
            btnAgregarAlCarrito.TabIndex = 0;
            btnAgregarAlCarrito.Text = "Agregar";
            btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            btnAgregarAlCarrito.Click += btnAgregarAlCarrito_Click;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(213, 122);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.Size = new Size(1042, 551);
            dataGridViewProductos.TabIndex = 2;
            dataGridViewProductos.CellContentClick += dataGridViewProductos_CellContentClick;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 685);
            Controls.Add(dataGridViewProductos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ClienteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClienteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnFinalizarCompra;
        private Label labelTotal;
        private ListBox listBoxCarrito;
        private Panel panel2;
        private DataGridView dataGridViewProductos;
        private Button btnAgregarAlCarrito;
        private Button Btn_Regresar;
        private Button Btn_Actualizar;
    }
}