namespace Act4_u4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlPricipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.LstCarritos = new System.Windows.Forms.ListBox();
            this.BtnCalculateTotal = new System.Windows.Forms.Button();
            this.PnlDetails = new System.Windows.Forms.Panel();
            this.PnlSmartphone = new System.Windows.Forms.Panel();
            this.TxtCameraSmartphone = new System.Windows.Forms.TextBox();
            this.TxtSystmeOpSmartphone = new System.Windows.Forms.TextBox();
            this.TxtPriceSmartphone = new System.Windows.Forms.TextBox();
            this.LblCameraSmartphone = new System.Windows.Forms.Label();
            this.TxtNameSmartphone = new System.Windows.Forms.TextBox();
            this.LblSystemOpSmartphone = new System.Windows.Forms.Label();
            this.LblPriceSmartphone = new System.Windows.Forms.Label();
            this.LblNameSmartphone = new System.Windows.Forms.Label();
            this.PnlPortatil = new System.Windows.Forms.Panel();
            this.TxtRAMPortatil = new System.Windows.Forms.TextBox();
            this.TxtSystemOpPortatil = new System.Windows.Forms.TextBox();
            this.TxtPricePortatil = new System.Windows.Forms.TextBox();
            this.LblRAMPortatil = new System.Windows.Forms.Label();
            this.TxtNamePortatil = new System.Windows.Forms.TextBox();
            this.LblSystemOpPortatil = new System.Windows.Forms.Label();
            this.LblPricePortatil = new System.Windows.Forms.Label();
            this.LblNamePortatil = new System.Windows.Forms.Label();
            this.PnlTelevision = new System.Windows.Forms.Panel();
            this.TxtInchesTelevision = new System.Windows.Forms.TextBox();
            this.TxtPriceTelevision = new System.Windows.Forms.TextBox();
            this.TxtNameTelevision = new System.Windows.Forms.TextBox();
            this.LblInchesTelevision = new System.Windows.Forms.Label();
            this.LblPriceTelevision = new System.Windows.Forms.Label();
            this.LblNameTelevision = new System.Windows.Forms.Label();
            this.CmbTypeProduct = new System.Windows.Forms.ComboBox();
            this.PnlPricipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlDetails.SuspendLayout();
            this.PnlSmartphone.SuspendLayout();
            this.PnlPortatil.SuspendLayout();
            this.PnlTelevision.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPricipal
            // 
            this.PnlPricipal.Controls.Add(this.panel1);
            this.PnlPricipal.Controls.Add(this.PnlDetails);
            this.PnlPricipal.Location = new System.Drawing.Point(11, 50);
            this.PnlPricipal.Name = "PnlPricipal";
            this.PnlPricipal.Size = new System.Drawing.Size(798, 993);
            this.PnlPricipal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblTotal);
            this.panel1.Controls.Add(this.BtnAddProduct);
            this.panel1.Controls.Add(this.LstCarritos);
            this.panel1.Controls.Add(this.BtnCalculateTotal);
            this.panel1.Location = new System.Drawing.Point(19, 637);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 318);
            this.panel1.TabIndex = 8;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(337, 283);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(44, 16);
            this.LblTotal.TabIndex = 8;
            this.LblTotal.Text = "Total: ";
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Location = new System.Drawing.Point(13, 26);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(715, 30);
            this.BtnAddProduct.TabIndex = 4;
            this.BtnAddProduct.Text = "Add Product";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // LstCarritos
            // 
            this.LstCarritos.FormattingEnabled = true;
            this.LstCarritos.ItemHeight = 16;
            this.LstCarritos.Location = new System.Drawing.Point(13, 72);
            this.LstCarritos.Name = "LstCarritos";
            this.LstCarritos.Size = new System.Drawing.Size(715, 132);
            this.LstCarritos.TabIndex = 5;
            // 
            // BtnCalculateTotal
            // 
            this.BtnCalculateTotal.Location = new System.Drawing.Point(13, 221);
            this.BtnCalculateTotal.Name = "BtnCalculateTotal";
            this.BtnCalculateTotal.Size = new System.Drawing.Size(715, 30);
            this.BtnCalculateTotal.TabIndex = 6;
            this.BtnCalculateTotal.Text = "Calculate Total";
            this.BtnCalculateTotal.UseVisualStyleBackColor = true;
            this.BtnCalculateTotal.Click += new System.EventHandler(this.BtnCalculateTotal_Click);
            // 
            // PnlDetails
            // 
            this.PnlDetails.Controls.Add(this.PnlSmartphone);
            this.PnlDetails.Controls.Add(this.PnlPortatil);
            this.PnlDetails.Controls.Add(this.PnlTelevision);
            this.PnlDetails.Location = new System.Drawing.Point(19, 17);
            this.PnlDetails.Name = "PnlDetails";
            this.PnlDetails.Size = new System.Drawing.Size(728, 587);
            this.PnlDetails.TabIndex = 1;
            // 
            // PnlSmartphone
            // 
            this.PnlSmartphone.Controls.Add(this.TxtCameraSmartphone);
            this.PnlSmartphone.Controls.Add(this.TxtSystmeOpSmartphone);
            this.PnlSmartphone.Controls.Add(this.TxtPriceSmartphone);
            this.PnlSmartphone.Controls.Add(this.LblCameraSmartphone);
            this.PnlSmartphone.Controls.Add(this.TxtNameSmartphone);
            this.PnlSmartphone.Controls.Add(this.LblSystemOpSmartphone);
            this.PnlSmartphone.Controls.Add(this.LblPriceSmartphone);
            this.PnlSmartphone.Controls.Add(this.LblNameSmartphone);
            this.PnlSmartphone.Location = new System.Drawing.Point(66, 385);
            this.PnlSmartphone.Name = "PnlSmartphone";
            this.PnlSmartphone.Size = new System.Drawing.Size(605, 176);
            this.PnlSmartphone.TabIndex = 4;
            // 
            // TxtCameraSmartphone
            // 
            this.TxtCameraSmartphone.Location = new System.Drawing.Point(135, 129);
            this.TxtCameraSmartphone.Name = "TxtCameraSmartphone";
            this.TxtCameraSmartphone.Size = new System.Drawing.Size(388, 22);
            this.TxtCameraSmartphone.TabIndex = 19;
            // 
            // TxtSystmeOpSmartphone
            // 
            this.TxtSystmeOpSmartphone.Location = new System.Drawing.Point(135, 92);
            this.TxtSystmeOpSmartphone.Name = "TxtSystmeOpSmartphone";
            this.TxtSystmeOpSmartphone.Size = new System.Drawing.Size(388, 22);
            this.TxtSystmeOpSmartphone.TabIndex = 18;
            // 
            // TxtPriceSmartphone
            // 
            this.TxtPriceSmartphone.Location = new System.Drawing.Point(135, 49);
            this.TxtPriceSmartphone.Name = "TxtPriceSmartphone";
            this.TxtPriceSmartphone.Size = new System.Drawing.Size(388, 22);
            this.TxtPriceSmartphone.TabIndex = 17;
            // 
            // LblCameraSmartphone
            // 
            this.LblCameraSmartphone.AutoSize = true;
            this.LblCameraSmartphone.Location = new System.Drawing.Point(18, 129);
            this.LblCameraSmartphone.Name = "LblCameraSmartphone";
            this.LblCameraSmartphone.Size = new System.Drawing.Size(58, 16);
            this.LblCameraSmartphone.TabIndex = 16;
            this.LblCameraSmartphone.Text = "Camera:";
            // 
            // TxtNameSmartphone
            // 
            this.TxtNameSmartphone.Location = new System.Drawing.Point(135, 11);
            this.TxtNameSmartphone.Name = "TxtNameSmartphone";
            this.TxtNameSmartphone.Size = new System.Drawing.Size(388, 22);
            this.TxtNameSmartphone.TabIndex = 15;
            // 
            // LblSystemOpSmartphone
            // 
            this.LblSystemOpSmartphone.AutoSize = true;
            this.LblSystemOpSmartphone.Location = new System.Drawing.Point(18, 92);
            this.LblSystemOpSmartphone.Name = "LblSystemOpSmartphone";
            this.LblSystemOpSmartphone.Size = new System.Drawing.Size(76, 16);
            this.LblSystemOpSmartphone.TabIndex = 14;
            this.LblSystemOpSmartphone.Text = "System Op:";
            // 
            // LblPriceSmartphone
            // 
            this.LblPriceSmartphone.AutoSize = true;
            this.LblPriceSmartphone.Location = new System.Drawing.Point(18, 49);
            this.LblPriceSmartphone.Name = "LblPriceSmartphone";
            this.LblPriceSmartphone.Size = new System.Drawing.Size(41, 16);
            this.LblPriceSmartphone.TabIndex = 13;
            this.LblPriceSmartphone.Text = "Price:";
            // 
            // LblNameSmartphone
            // 
            this.LblNameSmartphone.AutoSize = true;
            this.LblNameSmartphone.Location = new System.Drawing.Point(18, 11);
            this.LblNameSmartphone.Name = "LblNameSmartphone";
            this.LblNameSmartphone.Size = new System.Drawing.Size(47, 16);
            this.LblNameSmartphone.TabIndex = 12;
            this.LblNameSmartphone.Text = "Name:";
            // 
            // PnlPortatil
            // 
            this.PnlPortatil.Controls.Add(this.TxtRAMPortatil);
            this.PnlPortatil.Controls.Add(this.TxtSystemOpPortatil);
            this.PnlPortatil.Controls.Add(this.TxtPricePortatil);
            this.PnlPortatil.Controls.Add(this.LblRAMPortatil);
            this.PnlPortatil.Controls.Add(this.TxtNamePortatil);
            this.PnlPortatil.Controls.Add(this.LblSystemOpPortatil);
            this.PnlPortatil.Controls.Add(this.LblPricePortatil);
            this.PnlPortatil.Controls.Add(this.LblNamePortatil);
            this.PnlPortatil.Location = new System.Drawing.Point(66, 182);
            this.PnlPortatil.Name = "PnlPortatil";
            this.PnlPortatil.Size = new System.Drawing.Size(605, 174);
            this.PnlPortatil.TabIndex = 3;
            // 
            // TxtRAMPortatil
            // 
            this.TxtRAMPortatil.Location = new System.Drawing.Point(135, 138);
            this.TxtRAMPortatil.Name = "TxtRAMPortatil";
            this.TxtRAMPortatil.Size = new System.Drawing.Size(388, 22);
            this.TxtRAMPortatil.TabIndex = 11;
            // 
            // TxtSystemOpPortatil
            // 
            this.TxtSystemOpPortatil.Location = new System.Drawing.Point(135, 101);
            this.TxtSystemOpPortatil.Name = "TxtSystemOpPortatil";
            this.TxtSystemOpPortatil.Size = new System.Drawing.Size(388, 22);
            this.TxtSystemOpPortatil.TabIndex = 10;
            // 
            // TxtPricePortatil
            // 
            this.TxtPricePortatil.Location = new System.Drawing.Point(135, 58);
            this.TxtPricePortatil.Name = "TxtPricePortatil";
            this.TxtPricePortatil.Size = new System.Drawing.Size(388, 22);
            this.TxtPricePortatil.TabIndex = 9;
            // 
            // LblRAMPortatil
            // 
            this.LblRAMPortatil.AutoSize = true;
            this.LblRAMPortatil.Location = new System.Drawing.Point(18, 138);
            this.LblRAMPortatil.Name = "LblRAMPortatil";
            this.LblRAMPortatil.Size = new System.Drawing.Size(40, 16);
            this.LblRAMPortatil.TabIndex = 8;
            this.LblRAMPortatil.Text = "RAM:";
            // 
            // TxtNamePortatil
            // 
            this.TxtNamePortatil.Location = new System.Drawing.Point(135, 20);
            this.TxtNamePortatil.Name = "TxtNamePortatil";
            this.TxtNamePortatil.Size = new System.Drawing.Size(388, 22);
            this.TxtNamePortatil.TabIndex = 7;
            // 
            // LblSystemOpPortatil
            // 
            this.LblSystemOpPortatil.AutoSize = true;
            this.LblSystemOpPortatil.Location = new System.Drawing.Point(18, 101);
            this.LblSystemOpPortatil.Name = "LblSystemOpPortatil";
            this.LblSystemOpPortatil.Size = new System.Drawing.Size(76, 16);
            this.LblSystemOpPortatil.TabIndex = 6;
            this.LblSystemOpPortatil.Text = "System Op:";
            // 
            // LblPricePortatil
            // 
            this.LblPricePortatil.AutoSize = true;
            this.LblPricePortatil.Location = new System.Drawing.Point(18, 58);
            this.LblPricePortatil.Name = "LblPricePortatil";
            this.LblPricePortatil.Size = new System.Drawing.Size(41, 16);
            this.LblPricePortatil.TabIndex = 5;
            this.LblPricePortatil.Text = "Price:";
            // 
            // LblNamePortatil
            // 
            this.LblNamePortatil.AutoSize = true;
            this.LblNamePortatil.Location = new System.Drawing.Point(18, 20);
            this.LblNamePortatil.Name = "LblNamePortatil";
            this.LblNamePortatil.Size = new System.Drawing.Size(47, 16);
            this.LblNamePortatil.TabIndex = 4;
            this.LblNamePortatil.Text = "Name:";
            // 
            // PnlTelevision
            // 
            this.PnlTelevision.Controls.Add(this.TxtInchesTelevision);
            this.PnlTelevision.Controls.Add(this.TxtPriceTelevision);
            this.PnlTelevision.Controls.Add(this.TxtNameTelevision);
            this.PnlTelevision.Controls.Add(this.LblInchesTelevision);
            this.PnlTelevision.Controls.Add(this.LblPriceTelevision);
            this.PnlTelevision.Controls.Add(this.LblNameTelevision);
            this.PnlTelevision.Location = new System.Drawing.Point(66, 21);
            this.PnlTelevision.Name = "PnlTelevision";
            this.PnlTelevision.Size = new System.Drawing.Size(605, 136);
            this.PnlTelevision.TabIndex = 2;
            // 
            // TxtInchesTelevision
            // 
            this.TxtInchesTelevision.Location = new System.Drawing.Point(135, 99);
            this.TxtInchesTelevision.Name = "TxtInchesTelevision";
            this.TxtInchesTelevision.Size = new System.Drawing.Size(388, 22);
            this.TxtInchesTelevision.TabIndex = 5;
            // 
            // TxtPriceTelevision
            // 
            this.TxtPriceTelevision.Location = new System.Drawing.Point(135, 57);
            this.TxtPriceTelevision.Name = "TxtPriceTelevision";
            this.TxtPriceTelevision.Size = new System.Drawing.Size(388, 22);
            this.TxtPriceTelevision.TabIndex = 4;
            // 
            // TxtNameTelevision
            // 
            this.TxtNameTelevision.Location = new System.Drawing.Point(135, 19);
            this.TxtNameTelevision.Name = "TxtNameTelevision";
            this.TxtNameTelevision.Size = new System.Drawing.Size(388, 22);
            this.TxtNameTelevision.TabIndex = 3;
            // 
            // LblInchesTelevision
            // 
            this.LblInchesTelevision.AutoSize = true;
            this.LblInchesTelevision.Location = new System.Drawing.Point(18, 100);
            this.LblInchesTelevision.Name = "LblInchesTelevision";
            this.LblInchesTelevision.Size = new System.Drawing.Size(46, 16);
            this.LblInchesTelevision.TabIndex = 2;
            this.LblInchesTelevision.Text = "Inches";
            // 
            // LblPriceTelevision
            // 
            this.LblPriceTelevision.AutoSize = true;
            this.LblPriceTelevision.Location = new System.Drawing.Point(18, 57);
            this.LblPriceTelevision.Name = "LblPriceTelevision";
            this.LblPriceTelevision.Size = new System.Drawing.Size(41, 16);
            this.LblPriceTelevision.TabIndex = 1;
            this.LblPriceTelevision.Text = "Price:";
            // 
            // LblNameTelevision
            // 
            this.LblNameTelevision.AutoSize = true;
            this.LblNameTelevision.Location = new System.Drawing.Point(18, 19);
            this.LblNameTelevision.Name = "LblNameTelevision";
            this.LblNameTelevision.Size = new System.Drawing.Size(47, 16);
            this.LblNameTelevision.TabIndex = 0;
            this.LblNameTelevision.Text = "Name:";
            // 
            // CmbTypeProduct
            // 
            this.CmbTypeProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTypeProduct.FormattingEnabled = true;
            this.CmbTypeProduct.Items.AddRange(new object[] {
            "Television",
            "Laptop",
            "Smartphone"});
            this.CmbTypeProduct.Location = new System.Drawing.Point(285, 12);
            this.CmbTypeProduct.Name = "CmbTypeProduct";
            this.CmbTypeProduct.Size = new System.Drawing.Size(194, 24);
            this.CmbTypeProduct.TabIndex = 1;
            this.CmbTypeProduct.SelectedIndexChanged += new System.EventHandler(this.CmbTypeProduct_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 1055);
            this.Controls.Add(this.PnlPricipal);
            this.Controls.Add(this.CmbTypeProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PnlPricipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlDetails.ResumeLayout(false);
            this.PnlSmartphone.ResumeLayout(false);
            this.PnlSmartphone.PerformLayout();
            this.PnlPortatil.ResumeLayout(false);
            this.PnlPortatil.PerformLayout();
            this.PnlTelevision.ResumeLayout(false);
            this.PnlTelevision.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPricipal;
        private System.Windows.Forms.ComboBox CmbTypeProduct;
        private System.Windows.Forms.Panel PnlDetails;
        private System.Windows.Forms.Panel PnlTelevision;
        private System.Windows.Forms.Button BtnCalculateTotal;
        private System.Windows.Forms.ListBox LstCarritos;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Panel PnlSmartphone;
        private System.Windows.Forms.Panel PnlPortatil;
        private System.Windows.Forms.Label LblInchesTelevision;
        private System.Windows.Forms.Label LblPriceTelevision;
        private System.Windows.Forms.Label LblNameTelevision;
        private System.Windows.Forms.TextBox TxtNamePortatil;
        private System.Windows.Forms.Label LblSystemOpPortatil;
        private System.Windows.Forms.Label LblPricePortatil;
        private System.Windows.Forms.Label LblNamePortatil;
        private System.Windows.Forms.TextBox TxtInchesTelevision;
        private System.Windows.Forms.TextBox TxtPriceTelevision;
        private System.Windows.Forms.TextBox TxtNameTelevision;
        private System.Windows.Forms.TextBox TxtRAMPortatil;
        private System.Windows.Forms.TextBox TxtSystemOpPortatil;
        private System.Windows.Forms.TextBox TxtPricePortatil;
        private System.Windows.Forms.Label LblRAMPortatil;
        private System.Windows.Forms.TextBox TxtCameraSmartphone;
        private System.Windows.Forms.TextBox TxtSystmeOpSmartphone;
        private System.Windows.Forms.TextBox TxtPriceSmartphone;
        private System.Windows.Forms.Label LblCameraSmartphone;
        private System.Windows.Forms.TextBox TxtNameSmartphone;
        private System.Windows.Forms.Label LblSystemOpSmartphone;
        private System.Windows.Forms.Label LblPriceSmartphone;
        private System.Windows.Forms.Label LblNameSmartphone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTotal;
    }
}

