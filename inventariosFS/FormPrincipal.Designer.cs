namespace inventariosFS
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this._panel_Menu = new System.Windows.Forms.Panel();
            this.buttonPanelAdministrativo = new System.Windows.Forms.Button();
            this.buttonConsultarSalidas = new System.Windows.Forms.Button();
            this.buttonConsultarEntradas = new System.Windows.Forms.Button();
            this.buttonConsultaInventario = new System.Windows.Forms.Button();
            this.buttonRegistrarLote = new System.Windows.Forms.Button();
            this.button_regresar_sub_menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_home = new System.Windows.Forms.Button();
            this._panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel_Menu
            // 
            this._panel_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._panel_Menu.BackColor = System.Drawing.Color.Transparent;
            this._panel_Menu.Controls.Add(this.buttonPanelAdministrativo);
            this._panel_Menu.Controls.Add(this.buttonConsultarSalidas);
            this._panel_Menu.Controls.Add(this.buttonConsultarEntradas);
            this._panel_Menu.Controls.Add(this.buttonConsultaInventario);
            this._panel_Menu.Controls.Add(this.buttonRegistrarLote);
            this._panel_Menu.Controls.Add(this.button_regresar_sub_menu);
            this._panel_Menu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._panel_Menu.ForeColor = System.Drawing.Color.Black;
            this._panel_Menu.Location = new System.Drawing.Point(1, 2);
            this._panel_Menu.Name = "_panel_Menu";
            this._panel_Menu.Size = new System.Drawing.Size(317, 253);
            this._panel_Menu.TabIndex = 11;
            this._panel_Menu.Visible = false;
            // 
            // buttonPanelAdministrativo
            // 
            this.buttonPanelAdministrativo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanelAdministrativo.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonPanelAdministrativo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPanelAdministrativo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPanelAdministrativo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPanelAdministrativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPanelAdministrativo.ForeColor = System.Drawing.Color.Black;
            this.buttonPanelAdministrativo.Location = new System.Drawing.Point(5, 159);
            this.buttonPanelAdministrativo.Name = "buttonPanelAdministrativo";
            this.buttonPanelAdministrativo.Size = new System.Drawing.Size(306, 32);
            this.buttonPanelAdministrativo.TabIndex = 0;
            this.buttonPanelAdministrativo.Text = "Panel Administrativo";
            this.buttonPanelAdministrativo.UseVisualStyleBackColor = false;
            this.buttonPanelAdministrativo.Click += new System.EventHandler(this.buttonPanelAdministrativo_Click);
            // 
            // buttonConsultarSalidas
            // 
            this.buttonConsultarSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConsultarSalidas.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonConsultarSalidas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonConsultarSalidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonConsultarSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultarSalidas.ForeColor = System.Drawing.Color.Black;
            this.buttonConsultarSalidas.Location = new System.Drawing.Point(3, 122);
            this.buttonConsultarSalidas.Name = "buttonConsultarSalidas";
            this.buttonConsultarSalidas.Size = new System.Drawing.Size(306, 31);
            this.buttonConsultarSalidas.TabIndex = 0;
            this.buttonConsultarSalidas.Text = "Consulta de salidas";
            this.buttonConsultarSalidas.UseVisualStyleBackColor = false;
            this.buttonConsultarSalidas.Click += new System.EventHandler(this.buttonConsultarSalidas_Click);
            // 
            // buttonConsultarEntradas
            // 
            this.buttonConsultarEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConsultarEntradas.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonConsultarEntradas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonConsultarEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonConsultarEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultarEntradas.ForeColor = System.Drawing.Color.Black;
            this.buttonConsultarEntradas.Location = new System.Drawing.Point(3, 85);
            this.buttonConsultarEntradas.Name = "buttonConsultarEntradas";
            this.buttonConsultarEntradas.Size = new System.Drawing.Size(306, 31);
            this.buttonConsultarEntradas.TabIndex = 0;
            this.buttonConsultarEntradas.Text = "Consulta de entradas";
            this.buttonConsultarEntradas.UseVisualStyleBackColor = false;
            this.buttonConsultarEntradas.Click += new System.EventHandler(this.buttonConsultarEntradas_Click);
            // 
            // buttonConsultaInventario
            // 
            this.buttonConsultaInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConsultaInventario.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonConsultaInventario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonConsultaInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonConsultaInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultaInventario.ForeColor = System.Drawing.Color.White;
            this.buttonConsultaInventario.Location = new System.Drawing.Point(3, 48);
            this.buttonConsultaInventario.Name = "buttonConsultaInventario";
            this.buttonConsultaInventario.Size = new System.Drawing.Size(306, 31);
            this.buttonConsultaInventario.TabIndex = 0;
            this.buttonConsultaInventario.Text = "Consulta de inventario";
            this.buttonConsultaInventario.UseVisualStyleBackColor = false;
            this.buttonConsultaInventario.Click += new System.EventHandler(this.buttonConsultaInventario_Click);
            // 
            // buttonRegistrarLote
            // 
            this.buttonRegistrarLote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegistrarLote.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonRegistrarLote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRegistrarLote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonRegistrarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarLote.ForeColor = System.Drawing.Color.Black;
            this.buttonRegistrarLote.Location = new System.Drawing.Point(5, 197);
            this.buttonRegistrarLote.Name = "buttonRegistrarLote";
            this.buttonRegistrarLote.Size = new System.Drawing.Size(306, 31);
            this.buttonRegistrarLote.TabIndex = 0;
            this.buttonRegistrarLote.Text = "Registrar lote";
            this.buttonRegistrarLote.UseVisualStyleBackColor = false;
            // 
            // button_regresar_sub_menu
            // 
            this.button_regresar_sub_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_regresar_sub_menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_regresar_sub_menu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_regresar_sub_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button_regresar_sub_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_regresar_sub_menu.ForeColor = System.Drawing.Color.Black;
            this.button_regresar_sub_menu.Location = new System.Drawing.Point(3, 3);
            this.button_regresar_sub_menu.Name = "button_regresar_sub_menu";
            this.button_regresar_sub_menu.Size = new System.Drawing.Size(256, 38);
            this.button_regresar_sub_menu.TabIndex = 0;
            this.button_regresar_sub_menu.Text = "Regresar";
            this.button_regresar_sub_menu.UseVisualStyleBackColor = false;
            this.button_regresar_sub_menu.Click += new System.EventHandler(this.button_regresar_sub_menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(371, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inventarios FS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.DarkBlue;
            this.button_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_home.BackgroundImage")));
            this.button_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Location = new System.Drawing.Point(580, 12);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(61, 38);
            this.button_home.TabIndex = 13;
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(653, 267);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._panel_Menu);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this._panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _panel_Menu;
        private System.Windows.Forms.Button buttonPanelAdministrativo;
        private System.Windows.Forms.Button buttonConsultarSalidas;
        private System.Windows.Forms.Button buttonConsultarEntradas;
        private System.Windows.Forms.Button buttonConsultaInventario;
        private System.Windows.Forms.Button buttonRegistrarLote;
        private System.Windows.Forms.Button button_regresar_sub_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_home;
    }
}