namespace Comercial_Cristal
{
    partial class form_compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_compra));
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_producto = new System.Windows.Forms.ComboBox();
            this.txt_metros_stock = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_rollos_stock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_metros_rollo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_rollos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_metros_total = new System.Windows.Forms.TextBox();
            this.txt_rollos_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_registrar = new FontAwesome.Sharp.IconButton();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            this.combo_color = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "AGREGAR PRODUCTOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(379, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Producto:";
            // 
            // combo_producto
            // 
            this.combo_producto.FormattingEnabled = true;
            this.combo_producto.Items.AddRange(new object[] {
            "Nuevo producto"});
            this.combo_producto.Location = new System.Drawing.Point(176, 91);
            this.combo_producto.Name = "combo_producto";
            this.combo_producto.Size = new System.Drawing.Size(123, 29);
            this.combo_producto.TabIndex = 27;
            // 
            // txt_metros_stock
            // 
            this.txt_metros_stock.Enabled = false;
            this.txt_metros_stock.Location = new System.Drawing.Point(481, 282);
            this.txt_metros_stock.Name = "txt_metros_stock";
            this.txt_metros_stock.Size = new System.Drawing.Size(123, 30);
            this.txt_metros_stock.TabIndex = 26;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(176, 233);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(123, 30);
            this.txt_codigo.TabIndex = 25;
            // 
            // txt_rollos_stock
            // 
            this.txt_rollos_stock.Enabled = false;
            this.txt_rollos_stock.Location = new System.Drawing.Point(176, 282);
            this.txt_rollos_stock.Name = "txt_rollos_stock";
            this.txt_rollos_stock.Size = new System.Drawing.Size(123, 30);
            this.txt_rollos_stock.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Rollos en stock:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Metros en stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Producto:";
            // 
            // txt_metros_rollo
            // 
            this.txt_metros_rollo.Enabled = false;
            this.txt_metros_rollo.Location = new System.Drawing.Point(481, 233);
            this.txt_metros_rollo.Name = "txt_metros_rollo";
            this.txt_metros_rollo.Size = new System.Drawing.Size(123, 30);
            this.txt_metros_rollo.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Metros por rollo:";
            // 
            // txt_rollos
            // 
            this.txt_rollos.Location = new System.Drawing.Point(176, 188);
            this.txt_rollos.Name = "txt_rollos";
            this.txt_rollos.Size = new System.Drawing.Size(123, 30);
            this.txt_rollos.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "N° rollos:";
            // 
            // txt_metros_total
            // 
            this.txt_metros_total.Enabled = false;
            this.txt_metros_total.Location = new System.Drawing.Point(481, 329);
            this.txt_metros_total.Name = "txt_metros_total";
            this.txt_metros_total.Size = new System.Drawing.Size(123, 30);
            this.txt_metros_total.TabIndex = 35;
            // 
            // txt_rollos_total
            // 
            this.txt_rollos_total.Enabled = false;
            this.txt_rollos_total.Location = new System.Drawing.Point(176, 329);
            this.txt_rollos_total.Name = "txt_rollos_total";
            this.txt_rollos_total.Size = new System.Drawing.Size(123, 30);
            this.txt_rollos_total.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Total metros:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Total rollos:";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_registrar.IconColor = System.Drawing.Color.Black;
            this.btn_registrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_registrar.IconSize = 40;
            this.btn_registrar.Location = new System.Drawing.Point(234, 391);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(162, 58);
            this.btn_registrar.TabIndex = 62;
            this.btn_registrar.Text = "Registrar producto";
            this.btn_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_cancelar.IconColor = System.Drawing.Color.Black;
            this.btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancelar.IconSize = 40;
            this.btn_cancelar.Location = new System.Drawing.Point(42, 391);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Rotation = 180D;
            this.btn_cancelar.Size = new System.Drawing.Size(162, 58);
            this.btn_cancelar.TabIndex = 61;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // combo_color
            // 
            this.combo_color.FormattingEnabled = true;
            this.combo_color.Items.AddRange(new object[] {
            "Nuevo color"});
            this.combo_color.Location = new System.Drawing.Point(176, 138);
            this.combo_color.Name = "combo_color";
            this.combo_color.Size = new System.Drawing.Size(123, 29);
            this.combo_color.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 21);
            this.label11.TabIndex = 63;
            this.label11.Text = "Color/patrón:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(481, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 30);
            this.textBox1.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(343, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 21);
            this.label12.TabIndex = 65;
            this.label12.Text = "Color/patrón:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(481, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 30);
            this.textBox2.TabIndex = 67;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(345, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 21);
            this.label13.TabIndex = 69;
            this.label13.Text = "Precio metro:";
            // 
            // txt_precio
            // 
            this.txt_precio.Enabled = false;
            this.txt_precio.Location = new System.Drawing.Point(481, 188);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(123, 30);
            this.txt_precio.TabIndex = 68;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(426, 391);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(162, 58);
            this.iconButton1.TabIndex = 70;
            this.iconButton1.Text = "Actuatizar stock";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // form_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.combo_color);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_metros_total);
            this.Controls.Add(this.txt_rollos_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_rollos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_metros_rollo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_producto);
            this.Controls.Add(this.txt_metros_stock);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_rollos_stock);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(650, 500);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "form_compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMERCIAL CRISTAL - Agregar productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_producto;
        private System.Windows.Forms.TextBox txt_metros_stock;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_rollos_stock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_metros_rollo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_rollos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_metros_total;
        private System.Windows.Forms.TextBox txt_rollos_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_registrar;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private System.Windows.Forms.ComboBox combo_color;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_precio;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}