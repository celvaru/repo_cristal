namespace Comercial_Cristal
{
    partial class form_inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inventario_tabla = new System.Windows.Forms.DataGridView();
            this.garantia_txt = new System.Windows.Forms.TextBox();
            this.marca_txt = new System.Windows.Forms.TextBox();
            this.ram_txt = new System.Windows.Forms.TextBox();
            this.color_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bateria_txt = new System.Windows.Forms.TextBox();
            this.camara_txt = new System.Windows.Forms.TextBox();
            this.modelo_txt = new System.Windows.Forms.TextBox();
            this.codigo_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_limpiar = new FontAwesome.Sharp.IconButton();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_agregar = new FontAwesome.Sharp.IconButton();
            this.btn_buscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // inventario_tabla
            // 
            this.inventario_tabla.AllowUserToAddRows = false;
            this.inventario_tabla.AllowUserToDeleteRows = false;
            this.inventario_tabla.AllowUserToOrderColumns = true;
            this.inventario_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventario_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.inventario_tabla.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventario_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inventario_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventario_tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.inventario_tabla.Location = new System.Drawing.Point(42, 309);
            this.inventario_tabla.Name = "inventario_tabla";
            this.inventario_tabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventario_tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.inventario_tabla.Size = new System.Drawing.Size(835, 195);
            this.inventario_tabla.TabIndex = 58;
            // 
            // garantia_txt
            // 
            this.garantia_txt.Location = new System.Drawing.Point(478, 219);
            this.garantia_txt.Name = "garantia_txt";
            this.garantia_txt.Size = new System.Drawing.Size(178, 30);
            this.garantia_txt.TabIndex = 56;
            // 
            // marca_txt
            // 
            this.marca_txt.Location = new System.Drawing.Point(478, 259);
            this.marca_txt.Name = "marca_txt";
            this.marca_txt.Size = new System.Drawing.Size(178, 30);
            this.marca_txt.TabIndex = 55;
            // 
            // ram_txt
            // 
            this.ram_txt.Location = new System.Drawing.Point(478, 180);
            this.ram_txt.Name = "ram_txt";
            this.ram_txt.Size = new System.Drawing.Size(178, 30);
            this.ram_txt.TabIndex = 54;
            // 
            // color_txt
            // 
            this.color_txt.Location = new System.Drawing.Point(478, 140);
            this.color_txt.Name = "color_txt";
            this.color_txt.Size = new System.Drawing.Size(178, 30);
            this.color_txt.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Marca:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 51;
            this.label7.Text = "Garantía:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 50;
            this.label8.Text = "RAM:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 49;
            this.label9.Text = "Color:";
            // 
            // bateria_txt
            // 
            this.bateria_txt.Location = new System.Drawing.Point(186, 219);
            this.bateria_txt.Name = "bateria_txt";
            this.bateria_txt.Size = new System.Drawing.Size(171, 30);
            this.bateria_txt.TabIndex = 48;
            // 
            // camara_txt
            // 
            this.camara_txt.Location = new System.Drawing.Point(186, 259);
            this.camara_txt.Name = "camara_txt";
            this.camara_txt.Size = new System.Drawing.Size(171, 30);
            this.camara_txt.TabIndex = 47;
            // 
            // modelo_txt
            // 
            this.modelo_txt.Location = new System.Drawing.Point(186, 180);
            this.modelo_txt.Name = "modelo_txt";
            this.modelo_txt.Size = new System.Drawing.Size(171, 30);
            this.modelo_txt.TabIndex = 46;
            // 
            // codigo_txt
            // 
            this.codigo_txt.Location = new System.Drawing.Point(186, 140);
            this.codigo_txt.Name = "codigo_txt";
            this.codigo_txt.Size = new System.Drawing.Size(171, 30);
            this.codigo_txt.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Cámara:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Batería:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Código:";
            // 
            // buscar_txt
            // 
            this.buscar_txt.Location = new System.Drawing.Point(186, 95);
            this.buscar_txt.Name = "buscar_txt";
            this.buscar_txt.Size = new System.Drawing.Size(339, 30);
            this.buscar_txt.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 43);
            this.label2.TabIndex = 38;
            this.label2.Text = "INVENTARIO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_limpiar.IconColor = System.Drawing.Color.Black;
            this.btn_limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_limpiar.IconSize = 40;
            this.btn_limpiar.Location = new System.Drawing.Point(706, 241);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(135, 48);
            this.btn_limpiar.TabIndex = 61;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btn_eliminar.IconColor = System.Drawing.Color.Black;
            this.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminar.IconSize = 40;
            this.btn_eliminar.Location = new System.Drawing.Point(706, 187);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(135, 48);
            this.btn_eliminar.TabIndex = 60;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_agregar.IconColor = System.Drawing.Color.Black;
            this.btn_agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_agregar.IconSize = 40;
            this.btn_agregar.Location = new System.Drawing.Point(706, 132);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(135, 48);
            this.btn_agregar.TabIndex = 59;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_buscar.IconColor = System.Drawing.Color.Black;
            this.btn_buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buscar.IconSize = 28;
            this.btn_buscar.Location = new System.Drawing.Point(531, 95);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(111, 30);
            this.btn_buscar.TabIndex = 62;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // form_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(918, 537);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.inventario_tabla);
            this.Controls.Add(this.garantia_txt);
            this.Controls.Add(this.marca_txt);
            this.Controls.Add(this.ram_txt);
            this.Controls.Add(this.color_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bateria_txt);
            this.Controls.Add(this.camara_txt);
            this.Controls.Add(this.modelo_txt);
            this.Controls.Add(this.codigo_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar_txt);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "form_inventario";
            this.Text = "form_inventario";
            ((System.ComponentModel.ISupportInitialize)(this.inventario_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inventario_tabla;
        private System.Windows.Forms.TextBox garantia_txt;
        private System.Windows.Forms.TextBox marca_txt;
        private System.Windows.Forms.TextBox ram_txt;
        private System.Windows.Forms.TextBox color_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bateria_txt;
        private System.Windows.Forms.TextBox camara_txt;
        private System.Windows.Forms.TextBox modelo_txt;
        private System.Windows.Forms.TextBox codigo_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscar_txt;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_limpiar;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private FontAwesome.Sharp.IconButton btn_agregar;
        private FontAwesome.Sharp.IconButton btn_buscar;
    }
}