namespace exercise
{
    partial class Form_price
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblprice = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtprice.Location = new System.Drawing.Point(163, 69);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(122, 34);
            this.txtprice.TabIndex = 0;
            // 
            // txt_tax
            // 
            this.txt_tax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tax.Location = new System.Drawing.Point(163, 111);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(124, 34);
            this.txt_tax.TabIndex = 1;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdiscount.Location = new System.Drawing.Point(164, 155);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(123, 34);
            this.txtdiscount.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(113, 236);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(215, 86);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblprice.Location = new System.Drawing.Point(304, 72);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(59, 28);
            this.lblprice.TabIndex = 4;
            this.lblprice.Text = "قیمت";
            // 
            // lbltax
            // 
            this.lbltax.AutoSize = true;
            this.lbltax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltax.Location = new System.Drawing.Point(304, 111);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(66, 28);
            this.lbltax.TabIndex = 4;
            this.lbltax.Text = "مالیات";
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_discount.Location = new System.Drawing.Point(304, 155);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(68, 28);
            this.lbl_discount.TabIndex = 4;
            this.lbl_discount.Text = "تخفیف";
            // 
            // Form_price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 437);
            this.Controls.Add(this.lbl_discount);
            this.Controls.Add(this.lbltax);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txt_tax);
            this.Controls.Add(this.txtprice);
            this.Name = "Form_price";
            this.Text = "price";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtprice;
        private TextBox txt_tax;
        private TextBox txtdiscount;
        private Button btnCalculate;
        private Label lblprice;
        private Label lbltax;
        private Label lbl_discount;
    }
}