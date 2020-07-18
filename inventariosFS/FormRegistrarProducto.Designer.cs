namespace inventariosFS
{
    partial class FormRegistrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarProducto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_costo = new System.Windows.Forms.ComboBox();
            this.comboBox_precio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_proveedor = new System.Windows.Forms.ComboBox();
            this.comboBox_marca = new System.Windows.Forms.ComboBox();
            this.richTextBox_descripcion = new System.Windows.Forms.RichTextBox();
            this.textBox_modelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_registrar_producto = new System.Windows.Forms.Button();
            this.button_agregar_entrada = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_costo);
            this.groupBox1.Controls.Add(this.comboBox_precio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_proveedor);
            this.groupBox1.Controls.Add(this.comboBox_marca);
            this.groupBox1.Controls.Add(this.richTextBox_descripcion);
            this.groupBox1.Controls.Add(this.textBox_modelo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(876, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Producto";
            // 
            // comboBox_costo
            // 
            this.comboBox_costo.FormattingEnabled = true;
            this.comboBox_costo.Location = new System.Drawing.Point(110, 84);
            this.comboBox_costo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_costo.Name = "comboBox_costo";
            this.comboBox_costo.Size = new System.Drawing.Size(303, 28);
            this.comboBox_costo.TabIndex = 18;
            this.comboBox_costo.SelectedIndexChanged += new System.EventHandler(this.comboBox_costo_SelectedIndexChanged);
            this.comboBox_costo.TextChanged += new System.EventHandler(this.comboBox_costo_TextChanged);
            // 
            // comboBox_precio
            // 
            this.comboBox_precio.FormattingEnabled = true;
            this.comboBox_precio.Location = new System.Drawing.Point(110, 120);
            this.comboBox_precio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_precio.Name = "comboBox_precio";
            this.comboBox_precio.Size = new System.Drawing.Size(303, 28);
            this.comboBox_precio.TabIndex = 17;
            this.comboBox_precio.SelectedIndexChanged += new System.EventHandler(this.comboBox_precio_SelectedIndexChanged);
            this.comboBox_precio.TextChanged += new System.EventHandler(this.comboBox_precio_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Costo:";
            // 
            // comboBox_proveedor
            // 
            this.comboBox_proveedor.FormattingEnabled = true;
            this.comboBox_proveedor.Location = new System.Drawing.Point(552, 87);
            this.comboBox_proveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_proveedor.Name = "comboBox_proveedor";
            this.comboBox_proveedor.Size = new System.Drawing.Size(299, 28);
            this.comboBox_proveedor.TabIndex = 14;
            this.comboBox_proveedor.SelectedIndexChanged += new System.EventHandler(this.comboBox_proveedor_SelectedIndexChanged);
            this.comboBox_proveedor.TextChanged += new System.EventHandler(this.comboBox_proveedor_TextChanged);
            // 
            // comboBox_marca
            // 
            this.comboBox_marca.FormattingEnabled = true;
            this.comboBox_marca.Location = new System.Drawing.Point(552, 48);
            this.comboBox_marca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_marca.Name = "comboBox_marca";
            this.comboBox_marca.Size = new System.Drawing.Size(299, 28);
            this.comboBox_marca.TabIndex = 12;
            this.comboBox_marca.SelectedIndexChanged += new System.EventHandler(this.comboBox_marca_SelectedIndexChanged);
            this.comboBox_marca.TextChanged += new System.EventHandler(this.comboBox_marca_TextChanged);
            // 
            // richTextBox_descripcion
            // 
            this.richTextBox_descripcion.Location = new System.Drawing.Point(13, 193);
            this.richTextBox_descripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox_descripcion.Name = "richTextBox_descripcion";
            this.richTextBox_descripcion.Size = new System.Drawing.Size(842, 73);
            this.richTextBox_descripcion.TabIndex = 11;
            this.richTextBox_descripcion.Text = "";
            // 
            // textBox_modelo
            // 
            this.textBox_modelo.Location = new System.Drawing.Point(110, 49);
            this.textBox_modelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_modelo.Name = "textBox_modelo";
            this.textBox_modelo.Size = new System.Drawing.Size(303, 27);
            this.textBox_modelo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripción: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proveedor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            // 
            // button_registrar_producto
            // 
            this.button_registrar_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_registrar_producto.BackColor = System.Drawing.Color.Transparent;
            this.button_registrar_producto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_registrar_producto.BackgroundImage")));
            this.button_registrar_producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_registrar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_registrar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registrar_producto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_registrar_producto.Location = new System.Drawing.Point(824, 325);
            this.button_registrar_producto.Margin = new System.Windows.Forms.Padding(0);
            this.button_registrar_producto.Name = "button_registrar_producto";
            this.button_registrar_producto.Size = new System.Drawing.Size(34, 30);
            this.button_registrar_producto.TabIndex = 16;
            this.button_registrar_producto.Text = "cc";
            this.button_registrar_producto.UseVisualStyleBackColor = false;
            this.button_registrar_producto.Click += new System.EventHandler(this.button_registrar_producto_Click);
            // 
            // button_agregar_entrada
            // 
            this.button_agregar_entrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_agregar_entrada.BackColor = System.Drawing.Color.Transparent;
            this.button_agregar_entrada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_agregar_entrada.BackgroundImage")));
            this.button_agregar_entrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_agregar_entrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_agregar_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_agregar_entrada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar_entrada.Location = new System.Drawing.Point(782, 325);
            this.button_agregar_entrada.Margin = new System.Windows.Forms.Padding(0);
            this.button_agregar_entrada.Name = "button_agregar_entrada";
            this.button_agregar_entrada.Size = new System.Drawing.Size(34, 30);
            this.button_agregar_entrada.TabIndex = 18;
            this.button_agregar_entrada.Text = "cc";
            this.button_agregar_entrada.UseVisualStyleBackColor = false;
            // 
            // FormRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(894, 364);
            this.Controls.Add(this.button_agregar_entrada);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_registrar_producto);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRegistrarProducto";
            this.Text = "Registrar Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_proveedor;
        private System.Windows.Forms.ComboBox comboBox_marca;
        private System.Windows.Forms.RichTextBox richTextBox_descripcion;
        private System.Windows.Forms.TextBox textBox_modelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_registrar_producto;
        private System.Windows.Forms.ComboBox comboBox_costo;
        private System.Windows.Forms.ComboBox comboBox_precio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_agregar_entrada;
    }
}

