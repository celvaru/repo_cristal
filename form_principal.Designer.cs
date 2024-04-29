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
            this.btn_nreporte = new System.Windows.Forms.Button();
            this.btn_ncompra = new System.Windows.Forms.Button();
            this.btn_nventa = new System.Windows.Forms.Button();
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
            // btn_nreporte
            // 
            this.btn_nreporte.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_nreporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nreporte.FlatAppearance.BorderSize = 0;
            this.btn_nreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nreporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_nreporte.Image")));
            this.btn_nreporte.Location = new System.Drawing.Point(79, 407);
            this.btn_nreporte.Name = "btn_nreporte";
            this.btn_nreporte.Size = new System.Drawing.Size(250, 75);
            this.btn_nreporte.TabIndex = 7;
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
            this.btn_ncompra.Location = new System.Drawing.Point(79, 180);
            this.btn_ncompra.Name = "btn_ncompra";
            this.btn_ncompra.Size = new System.Drawing.Size(250, 75);
            this.btn_ncompra.TabIndex = 6;
            this.btn_ncompra.Text = "   Nueva compra";
            this.btn_ncompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ncompra.UseVisualStyleBackColor = false;
            // 
            // btn_nventa
            // 
            this.btn_nventa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_nventa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nventa.FlatAppearance.BorderSize = 0;
            this.btn_nventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nventa.Image = ((System.Drawing.Image)(resources.GetObject("btn_nventa.Image")));
            this.btn_nventa.Location = new System.Drawing.Point(79, 290);
            this.btn_nventa.Name = "btn_nventa";
            this.btn_nventa.Size = new System.Drawing.Size(250, 75);
            this.btn_nventa.TabIndex = 5;
            this.btn_nventa.Text = "   Nueva venta";
            this.btn_nventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nventa.UseVisualStyleBackColor = false;
            // 
            // form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(918, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nreporte);
            this.Controls.Add(this.btn_ncompra);
            this.Controls.Add(this.btn_nventa);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "form_principal";
            this.Text = "form_principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nreporte;
        private System.Windows.Forms.Button btn_ncompra;
        private System.Windows.Forms.Button btn_nventa;
    }
}