namespace Comercial_Cristal
{
    partial class form_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_principal));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ncompra = new FontAwesome.Sharp.IconButton();
            this.btn_nventa = new FontAwesome.Sharp.IconButton();
            this.btn_nreporte = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 78);
            this.label1.TabIndex = 8;
            this.label1.Text = "BIENVENIDO AL SISTEMA\r\nDE LA COMERCIAL CRISTAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(500, 150);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(650, 650);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ncompra
            // 
            this.btn_ncompra.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ncompra.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ncompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ncompra.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btn_ncompra.IconColor = System.Drawing.Color.Black;
            this.btn_ncompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ncompra.IconSize = 60;
            this.btn_ncompra.Location = new System.Drawing.Point(79, 164);
            this.btn_ncompra.Name = "btn_ncompra";
            this.btn_ncompra.Size = new System.Drawing.Size(257, 75);
            this.btn_ncompra.TabIndex = 10;
            this.btn_ncompra.Text = "Agregar productos";
            this.btn_ncompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ncompra.UseVisualStyleBackColor = false;
            this.btn_ncompra.Click += new System.EventHandler(this.btn_ncompra_Click);
            // 
            // btn_nventa
            // 
            this.btn_nventa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_nventa.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_nventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nventa.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btn_nventa.IconColor = System.Drawing.Color.Black;
            this.btn_nventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_nventa.IconSize = 60;
            this.btn_nventa.Location = new System.Drawing.Point(79, 288);
            this.btn_nventa.Name = "btn_nventa";
            this.btn_nventa.Size = new System.Drawing.Size(257, 75);
            this.btn_nventa.TabIndex = 11;
            this.btn_nventa.Text = "Nueva venta";
            this.btn_nventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nventa.UseVisualStyleBackColor = false;
            this.btn_nventa.Click += new System.EventHandler(this.btn_nventa_Click);
            // 
            // btn_nreporte
            // 
            this.btn_nreporte.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_nreporte.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_nreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nreporte.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btn_nreporte.IconColor = System.Drawing.Color.Black;
            this.btn_nreporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_nreporte.IconSize = 60;
            this.btn_nreporte.Location = new System.Drawing.Point(79, 412);
            this.btn_nreporte.Name = "btn_nreporte";
            this.btn_nreporte.Size = new System.Drawing.Size(257, 75);
            this.btn_nreporte.TabIndex = 12;
            this.btn_nreporte.Text = "Generar reportes";
            this.btn_nreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nreporte.UseVisualStyleBackColor = false;
            this.btn_nreporte.Click += new System.EventHandler(this.btn_nreporte_Click);
            // 
            // form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(918, 537);
            this.Controls.Add(this.btn_nreporte);
            this.Controls.Add(this.btn_nventa);
            this.Controls.Add(this.btn_ncompra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "form_principal";
            this.Text = "form_principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btn_ncompra;
        private FontAwesome.Sharp.IconButton btn_nventa;
        private FontAwesome.Sharp.IconButton btn_nreporte;
    }
}