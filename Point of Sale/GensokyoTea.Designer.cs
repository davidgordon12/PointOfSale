
namespace Point_of_Sale
{
    partial class GensokyoTea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GensokyoTea));
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCompleTxn = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTXN = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnQuantity = new System.Windows.Forms.Button();
            this.teasListBox = new System.Windows.Forms.ListBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignOut.ForeColor = System.Drawing.Color.Red;
            this.btnSignOut.Location = new System.Drawing.Point(13, 363);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(100, 100);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.TabStop = false;
            this.btnSignOut.Text = "SIGN OUT";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDiscount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiscount.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnDiscount.Location = new System.Drawing.Point(119, 260);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(100, 100);
            this.btnDiscount.TabIndex = 0;
            this.btnDiscount.TabStop = false;
            this.btnDiscount.Text = "DISCOUNT (%)";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnCompleTxn
            // 
            this.btnCompleTxn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompleTxn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompleTxn.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCompleTxn.Location = new System.Drawing.Point(225, 366);
            this.btnCompleTxn.Name = "btnCompleTxn";
            this.btnCompleTxn.Size = new System.Drawing.Size(242, 100);
            this.btnCompleTxn.TabIndex = 7;
            this.btnCompleTxn.Text = "COMPLETE TXN";
            this.btnCompleTxn.UseVisualStyleBackColor = false;
            this.btnCompleTxn.Click += new System.EventHandler(this.btnCompleTxn_Click);
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoid.ForeColor = System.Drawing.Color.Red;
            this.btnVoid.Location = new System.Drawing.Point(119, 363);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(100, 100);
            this.btnVoid.TabIndex = 1;
            this.btnVoid.Text = "VOID";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTime.Location = new System.Drawing.Point(13, 24);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 19);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.Location = new System.Drawing.Point(12, 89);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(49, 19);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "label1";
            // 
            // lblTXN
            // 
            this.lblTXN.AutoSize = true;
            this.lblTXN.BackColor = System.Drawing.Color.Transparent;
            this.lblTXN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTXN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTXN.Location = new System.Drawing.Point(13, 149);
            this.lblTXN.Name = "lblTXN";
            this.lblTXN.Size = new System.Drawing.Size(49, 19);
            this.lblTXN.TabIndex = 9;
            this.lblTXN.Text = "label1";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(85, 209);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(98, 27);
            this.txtTotal.TabIndex = 10;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSubtotal.Location = new System.Drawing.Point(13, 213);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(66, 19);
            this.lblSubtotal.TabIndex = 11;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnQuantity
            // 
            this.btnQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuantity.Location = new System.Drawing.Point(13, 260);
            this.btnQuantity.Name = "btnQuantity";
            this.btnQuantity.Size = new System.Drawing.Size(100, 100);
            this.btnQuantity.TabIndex = 0;
            this.btnQuantity.TabStop = false;
            this.btnQuantity.Text = "QUANTITY";
            this.btnQuantity.UseVisualStyleBackColor = false;
            this.btnQuantity.Click += new System.EventHandler(this.btnQuantity_Click);
            // 
            // teasListBox
            // 
            this.teasListBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teasListBox.FormattingEnabled = true;
            this.teasListBox.ItemHeight = 19;
            this.teasListBox.Location = new System.Drawing.Point(225, 6);
            this.teasListBox.Name = "teasListBox";
            this.teasListBox.Size = new System.Drawing.Size(245, 137);
            this.teasListBox.TabIndex = 12;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddToCart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddToCart.Location = new System.Drawing.Point(225, 149);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(245, 87);
            this.btnAddToCart.TabIndex = 14;
            this.btnAddToCart.TabStop = false;
            this.btnAddToCart.Text = "ADD TO CART";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // cartListBox
            // 
            this.cartListBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 19;
            this.cartListBox.Location = new System.Drawing.Point(225, 242);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(245, 118);
            this.cartListBox.TabIndex = 15;
            // 
            // GensokyoTea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(479, 475);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.teasListBox);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTXN);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnCompleTxn);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.btnQuantity);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnDiscount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GensokyoTea";
            this.Text = "Gensokyo Tea";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnCompleTxn;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTXN;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnQuantity;
        private System.Windows.Forms.ListBox teasListBox;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.ListBox cartListBox;
    }
}

