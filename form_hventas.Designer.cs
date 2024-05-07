namespace Comercial_Cristal
{
    partial class form_hventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabla_ventas = new System.Windows.Forms.DataGridView();
            this.numventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.set_ventas_comercial_cristal = new Comercial_Cristal.set_ventas_comercial_cristal();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.combo_buscar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar = new FontAwesome.Sharp.IconButton();
            this.ventaTableAdapter = new Comercial_Cristal.set_ventas_comercial_cristalTableAdapters.VentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_ventas_comercial_cristal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_ventas
            // 
            this.tabla_ventas.AllowUserToAddRows = false;
            this.tabla_ventas.AllowUserToDeleteRows = false;
            this.tabla_ventas.AllowUserToOrderColumns = true;
            this.tabla_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla_ventas.AutoGenerateColumns = false;
            this.tabla_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_ventas.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabla_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numventaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.ciclienteDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.ciDataGridViewTextBoxColumn});
            this.tabla_ventas.DataSource = this.ventaBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_ventas.DefaultCellStyle = dataGridViewCellStyle5;
            this.tabla_ventas.Location = new System.Drawing.Point(60, 179);
            this.tabla_ventas.Name = "tabla_ventas";
            this.tabla_ventas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_ventas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tabla_ventas.Size = new System.Drawing.Size(798, 317);
            this.tabla_ventas.TabIndex = 20;
            // 
            // numventaDataGridViewTextBoxColumn
            // 
            this.numventaDataGridViewTextBoxColumn.DataPropertyName = "num_venta";
            this.numventaDataGridViewTextBoxColumn.HeaderText = "Nº de venta";
            this.numventaDataGridViewTextBoxColumn.Name = "numventaDataGridViewTextBoxColumn";
            this.numventaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciclienteDataGridViewTextBoxColumn
            // 
            this.ciclienteDataGridViewTextBoxColumn.DataPropertyName = "ci_cliente";
            this.ciclienteDataGridViewTextBoxColumn.HeaderText = "CI cliente";
            this.ciclienteDataGridViewTextBoxColumn.Name = "ciclienteDataGridViewTextBoxColumn";
            this.ciclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciDataGridViewTextBoxColumn
            // 
            this.ciDataGridViewTextBoxColumn.DataPropertyName = "ci";
            this.ciDataGridViewTextBoxColumn.HeaderText = "CI cajero";
            this.ciDataGridViewTextBoxColumn.Name = "ciDataGridViewTextBoxColumn";
            this.ciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "Venta";
            this.ventaBindingSource.DataSource = this.set_ventas_comercial_cristal;
            // 
            // set_ventas_comercial_cristal
            // 
            this.set_ventas_comercial_cristal.DataSetName = "set_ventas_comercial_cristal";
            this.set_ventas_comercial_cristal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.Location = new System.Drawing.Point(435, 106);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(306, 30);
            this.txt_buscar.TabIndex = 18;
            // 
            // combo_buscar
            // 
            this.combo_buscar.FormattingEnabled = true;
            this.combo_buscar.Items.AddRange(new object[] {
            "Nro. Compra",
            "CI cliente"});
            this.combo_buscar.Location = new System.Drawing.Point(173, 108);
            this.combo_buscar.Name = "combo_buscar";
            this.combo_buscar.Size = new System.Drawing.Size(162, 29);
            this.combo_buscar.TabIndex = 17;
            this.combo_buscar.Text = "Seleccione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Buscar por:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 43);
            this.label2.TabIndex = 15;
            this.label2.Text = "HISTORIAL DE VENTAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_buscar.IconColor = System.Drawing.Color.Black;
            this.btn_buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buscar.IconSize = 28;
            this.btn_buscar.Location = new System.Drawing.Point(747, 107);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(111, 30);
            this.btn_buscar.TabIndex = 21;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // form_hventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(918, 537);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.tabla_ventas);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.combo_buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "form_hventas";
            this.Text = "form_hventas";
            this.Load += new System.EventHandler(this.form_hventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_ventas_comercial_cristal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_ventas;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ComboBox combo_buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_buscar;
        private set_ventas_comercial_cristal set_ventas_comercial_cristal;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private set_ventas_comercial_cristalTableAdapters.VentaTableAdapter ventaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciDataGridViewTextBoxColumn;
    }
}