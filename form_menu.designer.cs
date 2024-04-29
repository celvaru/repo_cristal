namespace CeluCenter.Vistas
{
    partial class form_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_menu));
            this.panel_principal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nreporte = new System.Windows.Forms.Button();
            this.btn_ncompra = new System.Windows.Forms.Button();
            this.btn_nventa = new System.Windows.Forms.Button();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_hventas = new System.Windows.Forms.Button();
            this.btn_cerrar_sesion = new System.Windows.Forms.Button();
            this.panel_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_principal
            // 
            this.panel_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_principal.BackColor = System.Drawing.Color.LightCyan;
            this.panel_principal.Controls.Add(this.label1);
            this.panel_principal.Controls.Add(this.btn_nreporte);
            this.panel_principal.Controls.Add(this.btn_ncompra);
            this.panel_principal.Controls.Add(this.btn_nventa);
            this.panel_principal.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_principal.Location = new System.Drawing.Point(204, 12);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(918, 537);
            this.panel_principal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "BIENVENIDO AL SISTEMA\r\nDE LA COMERCIAL CRISTAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_nreporte
            // 
            this.btn_nreporte.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_nreporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nreporte.FlatAppearance.BorderSize = 0;
            this.btn_nreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nreporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_nreporte.Image")));
            this.btn_nreporte.Location = new System.Drawing.Point(75, 387);
            this.btn_nreporte.Name = "btn_nreporte";
            this.btn_nreporte.Size = new System.Drawing.Size(250, 75);
            this.btn_nreporte.TabIndex = 2;
            this.btn_nreporte.Text = "Generar reporte";
            this.btn_nreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nreporte.UseVisualStyleBackColor = false;
            // 
            // btn_ncompra
            // 
            this.btn_ncompra.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ncompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ncompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ncompra.FlatAppearance.BorderSize = 0;
            this.btn_ncompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ncompra.Image = ((System.Drawing.Image)(resources.GetObject("btn_ncompra.Image")));
            this.btn_ncompra.Location = new System.Drawing.Point(75, 160);
            this.btn_ncompra.Name = "btn_ncompra";
            this.btn_ncompra.Size = new System.Drawing.Size(250, 75);
            this.btn_ncompra.TabIndex = 1;
            this.btn_ncompra.Text = "   Nueva compra";
            this.btn_ncompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ncompra.UseVisualStyleBackColor = false;
            this.btn_ncompra.Click += new System.EventHandler(this.btn_ncompra_Click);
            // 
            // btn_nventa
            // 
            this.btn_nventa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_nventa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nventa.FlatAppearance.BorderSize = 0;
            this.btn_nventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nventa.Image = ((System.Drawing.Image)(resources.GetObject("btn_nventa.Image")));
            this.btn_nventa.Location = new System.Drawing.Point(75, 270);
            this.btn_nventa.Name = "btn_nventa";
            this.btn_nventa.Size = new System.Drawing.Size(250, 75);
            this.btn_nventa.TabIndex = 0;
            this.btn_nventa.Text = "   Nueva venta";
            this.btn_nventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nventa.UseVisualStyleBackColor = false;
            this.btn_nventa.Click += new System.EventHandler(this.btn_nventa_Click);
            // 
            // btn_usuario
            // 
            this.btn_usuario.AutoSize = true;
            this.btn_usuario.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usuario.FlatAppearance.BorderSize = 0;
            this.btn_usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btn_usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuario.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario.Location = new System.Drawing.Point(2, 137);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(205, 43);
            this.btn_usuario.TabIndex = 2;
            this.btn_usuario.Text = "Usuarios";
            this.btn_usuario.UseVisualStyleBackColor = false;
            // 
            // btn_inventario
            // 
            this.btn_inventario.AutoSize = true;
            this.btn_inventario.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventario.FlatAppearance.BorderSize = 0;
            this.btn_inventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btn_inventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventario.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventario.Location = new System.Drawing.Point(2, 88);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(205, 43);
            this.btn_inventario.TabIndex = 3;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.UseVisualStyleBackColor = false;
            // 
            // btn_hventas
            // 
            this.btn_hventas.AutoSize = true;
            this.btn_hventas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_hventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hventas.FlatAppearance.BorderSize = 0;
            this.btn_hventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btn_hventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btn_hventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hventas.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hventas.Location = new System.Drawing.Point(2, 39);
            this.btn_hventas.Name = "btn_hventas";
            this.btn_hventas.Size = new System.Drawing.Size(205, 43);
            this.btn_hventas.TabIndex = 4;
            this.btn_hventas.Text = "Historial de ventas";
            this.btn_hventas.UseVisualStyleBackColor = false;
            // 
            // btn_cerrar_sesion
            // 
            this.btn_cerrar_sesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cerrar_sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_sesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_sesion.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_sesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_sesion.Image")));
            this.btn_cerrar_sesion.Location = new System.Drawing.Point(12, 508);
            this.btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            this.btn_cerrar_sesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cerrar_sesion.Size = new System.Drawing.Size(166, 41);
            this.btn_cerrar_sesion.TabIndex = 5;
            this.btn_cerrar_sesion.Text = "Cerrar Sesión";
            this.btn_cerrar_sesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar_sesion.UseVisualStyleBackColor = true;
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.btn_cerrar_sesion);
            this.Controls.Add(this.btn_hventas);
            this.Controls.Add(this.btn_inventario);
            this.Controls.Add(this.btn_usuario);
            this.Controls.Add(this.panel_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1150, 600);
            this.Name = "form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMERCIAL CRISTAL - Menú Principal";
            this.panel_principal.ResumeLayout(false);
            this.panel_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_hventas;
        private System.Windows.Forms.Button btn_cerrar_sesion;
        private System.Windows.Forms.Button btn_nventa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nreporte;
        private System.Windows.Forms.Button btn_ncompra;
    }
}