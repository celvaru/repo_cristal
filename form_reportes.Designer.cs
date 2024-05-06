namespace Comercial_Cristal
{
    partial class form_reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_reportes));
            this.btn_documento = new FontAwesome.Sharp.IconButton();
            this.btn_volver = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_reporte = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_mes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combo_anio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_documento
            // 
            this.btn_documento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_documento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_documento.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_documento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_documento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_documento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_documento.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btn_documento.IconColor = System.Drawing.Color.Black;
            this.btn_documento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_documento.IconSize = 40;
            this.btn_documento.Location = new System.Drawing.Point(295, 528);
            this.btn_documento.Name = "btn_documento";
            this.btn_documento.Size = new System.Drawing.Size(162, 58);
            this.btn_documento.TabIndex = 64;
            this.btn_documento.Text = "Ver documento";
            this.btn_documento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_documento.UseVisualStyleBackColor = true;
            // 
            // btn_volver
            // 
            this.btn_volver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volver.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_volver.IconColor = System.Drawing.Color.Black;
            this.btn_volver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_volver.IconSize = 40;
            this.btn_volver.Location = new System.Drawing.Point(68, 528);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Rotation = 180D;
            this.btn_volver.Size = new System.Drawing.Size(162, 58);
            this.btn_volver.TabIndex = 65;
            this.btn_volver.Text = "Volver";
            this.btn_volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(525, 528);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(162, 58);
            this.iconButton1.TabIndex = 66;
            this.iconButton1.Text = "Imprimir";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 43);
            this.label1.TabIndex = 67;
            this.label1.Text = "GENERADOR DE REPORTES";
            // 
            // combo_reporte
            // 
            this.combo_reporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combo_reporte.FormattingEnabled = true;
            this.combo_reporte.Items.AddRange(new object[] {
            "Ventas",
            "Ganancias"});
            this.combo_reporte.Location = new System.Drawing.Point(148, 84);
            this.combo_reporte.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.combo_reporte.Name = "combo_reporte";
            this.combo_reporte.Size = new System.Drawing.Size(144, 29);
            this.combo_reporte.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 68;
            this.label8.Text = "Reporte:";
            // 
            // combo_mes
            // 
            this.combo_mes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combo_mes.FormattingEnabled = true;
            this.combo_mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.combo_mes.Location = new System.Drawing.Point(553, 84);
            this.combo_mes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.combo_mes.Name = "combo_mes";
            this.combo_mes.Size = new System.Drawing.Size(132, 29);
            this.combo_mes.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 70;
            this.label2.Text = "Mes:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 370);
            this.dataGridView1.TabIndex = 72;
            // 
            // combo_anio
            // 
            this.combo_anio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combo_anio.FormattingEnabled = true;
            this.combo_anio.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.combo_anio.Location = new System.Drawing.Point(373, 84);
            this.combo_anio.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.combo_anio.Name = "combo_anio";
            this.combo_anio.Size = new System.Drawing.Size(97, 29);
            this.combo_anio.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 73;
            this.label3.Text = "Año:";
            // 
            // form_reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(754, 611);
            this.Controls.Add(this.combo_anio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combo_mes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_reporte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_documento);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(770, 650);
            this.MinimumSize = new System.Drawing.Size(770, 650);
            this.Name = "form_reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMERCIAL CRISTAL - Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_documento;
        private FontAwesome.Sharp.IconButton btn_volver;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_reporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_mes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_anio;
        private System.Windows.Forms.Label label3;
    }
}