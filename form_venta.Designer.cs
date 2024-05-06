namespace Comercial_Cristal
{
    partial class form_venta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_venta));
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cliente = new FontAwesome.Sharp.IconButton();
            this.txt_ci = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabla_detalle = new System.Windows.Forms.DataGridView();
            this.detalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalle_comercial_cristal = new Comercial_Cristal.detalle_comercial_cristal();
            this.combo_producto = new System.Windows.Forms.ComboBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_nro_venta = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.btn_limpiar = new FontAwesome.Sharp.IconButton();
            this.btn_registrar = new FontAwesome.Sharp.IconButton();
            this.btn_volver = new FontAwesome.Sharp.IconButton();
            this.btn_imprimir = new FontAwesome.Sharp.IconButton();
            this.btn_aumentar = new FontAwesome.Sharp.IconButton();
            this.combocolor = new System.Windows.Forms.ComboBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.detalleTableAdapter = new Comercial_Cristal.detalle_comercial_cristalTableAdapters.DetalleTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto_comercial_cristal = new Comercial_Cristal.producto_comercial_cristal();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Comercial_Cristal.producto_comercial_cristalTableAdapters.ProductoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_comercial_cristal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_comercial_cristal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date_fecha
            // 
            this.date_fecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date_fecha.CustomFormat = "dd/MM/yyyy";
            this.date_fecha.Enabled = false;
            this.date_fecha.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_fecha.Location = new System.Drawing.Point(155, 388);
            this.date_fecha.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.date_fecha.MaxDate = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            this.date_fecha.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(145, 30);
            this.date_fecha.TabIndex = 24;
            this.date_fecha.Value = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 432);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 395);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fecha venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 355);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nro. venta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cliente);
            this.groupBox1.Controls.Add(this.txt_ci);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(22, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(308, 180);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // btn_cliente
            // 
            this.btn_cliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cliente.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.btn_cliente.IconColor = System.Drawing.Color.Black;
            this.btn_cliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cliente.IconSize = 40;
            this.btn_cliente.Location = new System.Drawing.Point(73, 115);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(150, 57);
            this.btn_cliente.TabIndex = 65;
            this.btn_cliente.Text = "Nuevo cliente";
            this.btn_cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // txt_ci
            // 
            this.txt_ci.Location = new System.Drawing.Point(117, 77);
            this.txt_ci.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_ci.Name = "txt_ci";
            this.txt_ci.Size = new System.Drawing.Size(160, 30);
            this.txt_ci.TabIndex = 64;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(117, 36);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(160, 30);
            this.txt_nombre.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "CI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 86);
            this.label1.TabIndex = 16;
            this.label1.Text = "DATOS DE\r\nLA VENTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabla_detalle
            // 
            this.tabla_detalle.AllowUserToAddRows = false;
            this.tabla_detalle.AllowUserToDeleteRows = false;
            this.tabla_detalle.AllowUserToOrderColumns = true;
            this.tabla_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla_detalle.AutoGenerateColumns = false;
            this.tabla_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_detalle.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn});
            this.tabla_detalle.DataSource = this.detalleBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_detalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_detalle.Location = new System.Drawing.Point(372, 230);
            this.tabla_detalle.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabla_detalle.Name = "tabla_detalle";
            this.tabla_detalle.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_detalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabla_detalle.Size = new System.Drawing.Size(586, 222);
            this.tabla_detalle.TabIndex = 37;
            // 
            // detalleBindingSource
            // 
            this.detalleBindingSource.DataMember = "Detalle";
            this.detalleBindingSource.DataSource = this.detalle_comercial_cristal;
            // 
            // detalle_comercial_cristal
            // 
            this.detalle_comercial_cristal.DataSetName = "detalle_comercial_cristal";
            this.detalle_comercial_cristal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combo_producto
            // 
            this.combo_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.combo_producto.DataSource = this.productoBindingSource;
            this.combo_producto.FormattingEnabled = true;
            this.combo_producto.Location = new System.Drawing.Point(477, 107);
            this.combo_producto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.combo_producto.Name = "combo_producto";
            this.combo_producto.Size = new System.Drawing.Size(160, 29);
            this.combo_producto.TabIndex = 33;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(477, 190);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(160, 30);
            this.txt_cantidad.TabIndex = 32;
            // 
            // txt_precio
            // 
            this.txt_precio.Enabled = false;
            this.txt_precio.Location = new System.Drawing.Point(801, 146);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(157, 30);
            this.txt_precio.TabIndex = 31;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Location = new System.Drawing.Point(801, 189);
            this.txt_subtotal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(157, 30);
            this.txt_subtotal.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(701, 192);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 21);
            this.label11.TabIndex = 29;
            this.label11.Text = "Subtotal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(707, 109);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Código:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 193);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 43);
            this.label2.TabIndex = 25;
            this.label2.Text = "DETALLE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_nro_venta
            // 
            this.label_nro_venta.Location = new System.Drawing.Point(155, 346);
            this.label_nro_venta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_nro_venta.Name = "label_nro_venta";
            this.label_nro_venta.Size = new System.Drawing.Size(144, 30);
            this.label_nro_venta.TabIndex = 38;
            // 
            // label_total
            // 
            this.label_total.Location = new System.Drawing.Point(155, 432);
            this.label_total.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(145, 30);
            this.label_total.TabIndex = 39;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_limpiar.IconColor = System.Drawing.Color.Black;
            this.btn_limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_limpiar.IconSize = 40;
            this.btn_limpiar.Location = new System.Drawing.Point(817, 488);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(141, 50);
            this.btn_limpiar.TabIndex = 61;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btn_registrar.IconColor = System.Drawing.Color.Black;
            this.btn_registrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_registrar.IconSize = 40;
            this.btn_registrar.Location = new System.Drawing.Point(648, 488);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(141, 50);
            this.btn_registrar.TabIndex = 60;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // btn_volver
            // 
            this.btn_volver.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volver.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_volver.IconColor = System.Drawing.Color.Black;
            this.btn_volver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_volver.IconSize = 40;
            this.btn_volver.Location = new System.Drawing.Point(22, 488);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Rotation = 180D;
            this.btn_volver.Size = new System.Drawing.Size(141, 50);
            this.btn_volver.TabIndex = 59;
            this.btn_volver.Text = "Volver";
            this.btn_volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_imprimir.IconColor = System.Drawing.Color.Black;
            this.btn_imprimir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_imprimir.IconSize = 40;
            this.btn_imprimir.Location = new System.Drawing.Point(189, 488);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(141, 50);
            this.btn_imprimir.TabIndex = 63;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_aumentar
            // 
            this.btn_aumentar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_aumentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aumentar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_aumentar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_aumentar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_aumentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aumentar.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btn_aumentar.IconColor = System.Drawing.Color.Black;
            this.btn_aumentar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_aumentar.IconSize = 40;
            this.btn_aumentar.Location = new System.Drawing.Point(477, 488);
            this.btn_aumentar.Name = "btn_aumentar";
            this.btn_aumentar.Size = new System.Drawing.Size(141, 50);
            this.btn_aumentar.TabIndex = 64;
            this.btn_aumentar.Text = "Añadir";
            this.btn_aumentar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aumentar.UseVisualStyleBackColor = true;
            // 
            // combocolor
            // 
            this.combocolor.FormattingEnabled = true;
            this.combocolor.Location = new System.Drawing.Point(477, 147);
            this.combocolor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.combocolor.Name = "combocolor";
            this.combocolor.Size = new System.Drawing.Size(160, 29);
            this.combocolor.TabIndex = 68;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(801, 106);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(157, 30);
            this.txt_codigo.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(659, 149);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 21);
            this.label12.TabIndex = 66;
            this.label12.Text = "Precio metro:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(369, 150);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 21);
            this.label13.TabIndex = 65;
            this.label13.Text = "Producto:";
            // 
            // detalleTableAdapter
            // 
            this.detalleTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // producto_comercial_cristal
            // 
            this.producto_comercial_cristal.DataSetName = "producto_comercial_cristal";
            this.producto_comercial_cristal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.producto_comercial_cristal;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // form_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.combocolor);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_aumentar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label_nro_venta);
            this.Controls.Add(this.tabla_detalle);
            this.Controls.Add(this.combo_producto);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "form_venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMERCIAL CRISTAL - Nueva venta";
            this.Load += new System.EventHandler(this.form_venta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_comercial_cristal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_comercial_cristal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_fecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabla_detalle;
        private System.Windows.Forms.ComboBox combo_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_nro_venta;
        private System.Windows.Forms.Label label_total;
        private FontAwesome.Sharp.IconButton btn_limpiar;
        private FontAwesome.Sharp.IconButton btn_registrar;
        private FontAwesome.Sharp.IconButton btn_volver;
        private System.Windows.Forms.TextBox txt_ci;
        private System.Windows.Forms.TextBox txt_nombre;
        private FontAwesome.Sharp.IconButton btn_imprimir;
        private FontAwesome.Sharp.IconButton btn_aumentar;
        private FontAwesome.Sharp.IconButton btn_cliente;
        private System.Windows.Forms.ComboBox combocolor;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private detalle_comercial_cristal detalle_comercial_cristal;
        private System.Windows.Forms.BindingSource detalleBindingSource;
        private detalle_comercial_cristalTableAdapters.DetalleTableAdapter detalleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private producto_comercial_cristal producto_comercial_cristal;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private producto_comercial_cristalTableAdapters.ProductoTableAdapter productoTableAdapter;
    }
}