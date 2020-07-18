namespace inventariosFS
{
    partial class FormVerInventario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_presentacion = new System.Windows.Forms.ComboBox();
            this.comboBox_proveedor = new System.Windows.Forms.ComboBox();
            this.comboBox_almacen = new System.Windows.Forms.ComboBox();
            this.comboBox_marca = new System.Windows.Forms.ComboBox();
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.textBox_modelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewInventario = new System.Windows.Forms.DataGridView();
            this._panelFechas = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalida = new System.Windows.Forms.Button();
            this.buttonEntrada = new System.Windows.Forms.Button();
            this.button_reporte_inventario = new System.Windows.Forms.Button();
            this.button_reporte_busqueda = new System.Windows.Forms.Button();
            this.button_registrar_producto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).BeginInit();
            this._panelFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_presentacion);
            this.groupBox1.Controls.Add(this.comboBox_proveedor);
            this.groupBox1.Controls.Add(this.comboBox_almacen);
            this.groupBox1.Controls.Add(this.comboBox_marca);
            this.groupBox1.Controls.Add(this.textBox_descripcion);
            this.groupBox1.Controls.Add(this.textBox_modelo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // comboBox_presentacion
            // 
            this.comboBox_presentacion.FormattingEnabled = true;
            this.comboBox_presentacion.Location = new System.Drawing.Point(108, 213);
            this.comboBox_presentacion.Name = "comboBox_presentacion";
            this.comboBox_presentacion.Size = new System.Drawing.Size(208, 28);
            this.comboBox_presentacion.TabIndex = 12;
            // 
            // comboBox_proveedor
            // 
            this.comboBox_proveedor.FormattingEnabled = true;
            this.comboBox_proveedor.Location = new System.Drawing.Point(108, 179);
            this.comboBox_proveedor.Name = "comboBox_proveedor";
            this.comboBox_proveedor.Size = new System.Drawing.Size(208, 28);
            this.comboBox_proveedor.TabIndex = 11;
            // 
            // comboBox_almacen
            // 
            this.comboBox_almacen.FormattingEnabled = true;
            this.comboBox_almacen.Location = new System.Drawing.Point(108, 145);
            this.comboBox_almacen.Name = "comboBox_almacen";
            this.comboBox_almacen.Size = new System.Drawing.Size(208, 28);
            this.comboBox_almacen.TabIndex = 10;
            this.comboBox_almacen.SelectedIndexChanged += new System.EventHandler(this.comboBox_almacen_SelectedIndexChanged);
            this.comboBox_almacen.TextChanged += new System.EventHandler(this.comboBox_almacen_TextChanged);
            // 
            // comboBox_marca
            // 
            this.comboBox_marca.FormattingEnabled = true;
            this.comboBox_marca.Location = new System.Drawing.Point(108, 78);
            this.comboBox_marca.Name = "comboBox_marca";
            this.comboBox_marca.Size = new System.Drawing.Size(208, 28);
            this.comboBox_marca.TabIndex = 9;
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Location = new System.Drawing.Point(108, 112);
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(208, 27);
            this.textBox_descripcion.TabIndex = 8;
            // 
            // textBox_modelo
            // 
            this.textBox_modelo.Location = new System.Drawing.Point(108, 45);
            this.textBox_modelo.Name = "textBox_modelo";
            this.textBox_modelo.Size = new System.Drawing.Size(208, 27);
            this.textBox_modelo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Almacén:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Presentación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            // 
            // dataGridViewInventario
            // 
            this.dataGridViewInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventario.Location = new System.Drawing.Point(341, 12);
            this.dataGridViewInventario.Name = "dataGridViewInventario";
            this.dataGridViewInventario.Size = new System.Drawing.Size(856, 565);
            this.dataGridViewInventario.TabIndex = 0;
            this.dataGridViewInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInventario_CellContentClick);
            this.dataGridViewInventario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInventario_CellDoubleClick);
            // 
            // _panelFechas
            // 
            this._panelFechas.Controls.Add(this.buttonCancelar);
            this._panelFechas.Controls.Add(this.buttonSalida);
            this._panelFechas.Controls.Add(this.buttonEntrada);
            this._panelFechas.Location = new System.Drawing.Point(607, 101);
            this._panelFechas.Name = "_panelFechas";
            this._panelFechas.Size = new System.Drawing.Size(426, 182);
            this._panelFechas.TabIndex = 7;
            this._panelFechas.Visible = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.LightGray;
            this.buttonCancelar.Location = new System.Drawing.Point(3, 148);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(416, 31);
            this.buttonCancelar.TabIndex = 0;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalida
            // 
            this.buttonSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSalida.Location = new System.Drawing.Point(218, 3);
            this.buttonSalida.Name = "buttonSalida";
            this.buttonSalida.Size = new System.Drawing.Size(205, 139);
            this.buttonSalida.TabIndex = 0;
            this.buttonSalida.Text = "Salida";
            this.buttonSalida.UseVisualStyleBackColor = false;
            this.buttonSalida.Click += new System.EventHandler(this.buttonSalida_Click);
            // 
            // buttonEntrada
            // 
            this.buttonEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEntrada.Location = new System.Drawing.Point(7, 3);
            this.buttonEntrada.Name = "buttonEntrada";
            this.buttonEntrada.Size = new System.Drawing.Size(205, 139);
            this.buttonEntrada.TabIndex = 0;
            this.buttonEntrada.Text = "Entrada";
            this.buttonEntrada.UseVisualStyleBackColor = false;
            this.buttonEntrada.Click += new System.EventHandler(this.buttonEntrada_Click);
            // 
            // button_reporte_inventario
            // 
            this.button_reporte_inventario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_reporte_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reporte_inventario.Location = new System.Drawing.Point(16, 484);
            this.button_reporte_inventario.Name = "button_reporte_inventario";
            this.button_reporte_inventario.Size = new System.Drawing.Size(316, 45);
            this.button_reporte_inventario.TabIndex = 8;
            this.button_reporte_inventario.Text = "Reporte Inventario Completo";
            this.button_reporte_inventario.UseVisualStyleBackColor = false;
            this.button_reporte_inventario.Click += new System.EventHandler(this.button_reporte_inventario_Click);
            // 
            // button_reporte_busqueda
            // 
            this.button_reporte_busqueda.BackColor = System.Drawing.SystemColors.Info;
            this.button_reporte_busqueda.Location = new System.Drawing.Point(16, 535);
            this.button_reporte_busqueda.Name = "button_reporte_busqueda";
            this.button_reporte_busqueda.Size = new System.Drawing.Size(316, 42);
            this.button_reporte_busqueda.TabIndex = 10;
            this.button_reporte_busqueda.Text = "Exportar Búsqueda";
            this.button_reporte_busqueda.UseVisualStyleBackColor = false;
            this.button_reporte_busqueda.Click += new System.EventHandler(this.button_reporte_busqueda_Click);
            // 
            // button_registrar_producto
            // 
            this.button_registrar_producto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_registrar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registrar_producto.Location = new System.Drawing.Point(16, 433);
            this.button_registrar_producto.Name = "button_registrar_producto";
            this.button_registrar_producto.Size = new System.Drawing.Size(316, 45);
            this.button_registrar_producto.TabIndex = 11;
            this.button_registrar_producto.Text = "Reporte Inventario Completo";
            this.button_registrar_producto.UseVisualStyleBackColor = false;
            this.button_registrar_producto.Click += new System.EventHandler(this.button_registrar_producto_Click);
            // 
            // FormVerInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1209, 589);
            this.Controls.Add(this.button_registrar_producto);
            this.Controls.Add(this.button_reporte_busqueda);
            this.Controls.Add(this.button_reporte_inventario);
            this.Controls.Add(this._panelFechas);
            this.Controls.Add(this.dataGridViewInventario);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVerInventario";
            this.Text = "FormVerInventario";
            this.Load += new System.EventHandler(this.FormVerInventario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).EndInit();
            this._panelFechas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewInventario;
        private System.Windows.Forms.ComboBox comboBox_presentacion;
        private System.Windows.Forms.ComboBox comboBox_proveedor;
        private System.Windows.Forms.ComboBox comboBox_almacen;
        private System.Windows.Forms.ComboBox comboBox_marca;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.TextBox textBox_modelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel _panelFechas;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalida;
        private System.Windows.Forms.Button buttonEntrada;
        private System.Windows.Forms.Button button_reporte_inventario;
        private System.Windows.Forms.Button button_reporte_busqueda;
        private System.Windows.Forms.Button button_registrar_producto;
    }
}