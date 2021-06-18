namespace ProcessLunchForm
{
    partial class frmLunchOrder
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
            this.grbMainCourse = new System.Windows.Forms.GroupBox();
            this.rbSalad = new System.Windows.Forms.RadioButton();
            this.rbPizza = new System.Windows.Forms.RadioButton();
            this.rbHamburger = new System.Windows.Forms.RadioButton();
            this.grbAddOns = new System.Windows.Forms.GroupBox();
            this.cbAddon3 = new System.Windows.Forms.CheckBox();
            this.cbAddon2 = new System.Windows.Forms.CheckBox();
            this.cbAddon1 = new System.Windows.Forms.CheckBox();
            this.grbOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbMainCourse.SuspendLayout();
            this.grbAddOns.SuspendLayout();
            this.grbOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMainCourse
            // 
            this.grbMainCourse.Controls.Add(this.rbSalad);
            this.grbMainCourse.Controls.Add(this.rbPizza);
            this.grbMainCourse.Controls.Add(this.rbHamburger);
            this.grbMainCourse.Location = new System.Drawing.Point(12, 12);
            this.grbMainCourse.Name = "grbMainCourse";
            this.grbMainCourse.Size = new System.Drawing.Size(157, 110);
            this.grbMainCourse.TabIndex = 1;
            this.grbMainCourse.TabStop = false;
            this.grbMainCourse.Text = "Main Course";
            // 
            // rbSalad
            // 
            this.rbSalad.AutoSize = true;
            this.rbSalad.Location = new System.Drawing.Point(6, 87);
            this.rbSalad.Name = "rbSalad";
            this.rbSalad.Size = new System.Drawing.Size(88, 17);
            this.rbSalad.TabIndex = 2;
            this.rbSalad.TabStop = true;
            this.rbSalad.Text = "Salad - $4.95";
            this.rbSalad.UseVisualStyleBackColor = true;
            this.rbSalad.CheckedChanged += new System.EventHandler(this.MainCourseSelector);
            // 
            // rbPizza
            // 
            this.rbPizza.AutoSize = true;
            this.rbPizza.Location = new System.Drawing.Point(6, 51);
            this.rbPizza.Name = "rbPizza";
            this.rbPizza.Size = new System.Drawing.Size(86, 17);
            this.rbPizza.TabIndex = 1;
            this.rbPizza.TabStop = true;
            this.rbPizza.Text = "Pizza - $5.95";
            this.rbPizza.UseVisualStyleBackColor = true;
            this.rbPizza.CheckedChanged += new System.EventHandler(this.MainCourseSelector);
            // 
            // rbHamburger
            // 
            this.rbHamburger.AutoSize = true;
            this.rbHamburger.Location = new System.Drawing.Point(6, 19);
            this.rbHamburger.Name = "rbHamburger";
            this.rbHamburger.Size = new System.Drawing.Size(113, 17);
            this.rbHamburger.TabIndex = 0;
            this.rbHamburger.TabStop = true;
            this.rbHamburger.Text = "Hamburger - $6.95";
            this.rbHamburger.UseVisualStyleBackColor = true;
            this.rbHamburger.CheckedChanged += new System.EventHandler(this.MainCourseSelector);
            // 
            // grbAddOns
            // 
            this.grbAddOns.Controls.Add(this.cbAddon3);
            this.grbAddOns.Controls.Add(this.cbAddon2);
            this.grbAddOns.Controls.Add(this.cbAddon1);
            this.grbAddOns.Location = new System.Drawing.Point(188, 12);
            this.grbAddOns.Name = "grbAddOns";
            this.grbAddOns.Size = new System.Drawing.Size(191, 110);
            this.grbAddOns.TabIndex = 2;
            this.grbAddOns.TabStop = false;
            this.grbAddOns.Text = "Add-on Items";
            // 
            // cbAddon3
            // 
            this.cbAddon3.AutoSize = true;
            this.cbAddon3.Location = new System.Drawing.Point(6, 87);
            this.cbAddon3.Name = "cbAddon3";
            this.cbAddon3.Size = new System.Drawing.Size(80, 17);
            this.cbAddon3.TabIndex = 2;
            this.cbAddon3.Text = "checkBox3";
            this.cbAddon3.UseVisualStyleBackColor = true;
            this.cbAddon3.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // cbAddon2
            // 
            this.cbAddon2.AutoSize = true;
            this.cbAddon2.Location = new System.Drawing.Point(6, 51);
            this.cbAddon2.Name = "cbAddon2";
            this.cbAddon2.Size = new System.Drawing.Size(80, 17);
            this.cbAddon2.TabIndex = 1;
            this.cbAddon2.Text = "checkBox2";
            this.cbAddon2.UseVisualStyleBackColor = true;
            this.cbAddon2.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // cbAddon1
            // 
            this.cbAddon1.AutoSize = true;
            this.cbAddon1.Location = new System.Drawing.Point(6, 19);
            this.cbAddon1.Name = "cbAddon1";
            this.cbAddon1.Size = new System.Drawing.Size(80, 17);
            this.cbAddon1.TabIndex = 0;
            this.cbAddon1.Text = "checkBox1";
            this.cbAddon1.UseVisualStyleBackColor = true;
            this.cbAddon1.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // grbOrderTotal
            // 
            this.grbOrderTotal.Controls.Add(this.txtTotal);
            this.grbOrderTotal.Controls.Add(this.txtTax);
            this.grbOrderTotal.Controls.Add(this.txtSubtotal);
            this.grbOrderTotal.Controls.Add(this.lblTotal);
            this.grbOrderTotal.Controls.Add(this.lblTax);
            this.grbOrderTotal.Controls.Add(this.lblSubtotal);
            this.grbOrderTotal.Location = new System.Drawing.Point(12, 140);
            this.grbOrderTotal.Name = "grbOrderTotal";
            this.grbOrderTotal.Size = new System.Drawing.Size(200, 120);
            this.grbOrderTotal.TabIndex = 2;
            this.grbOrderTotal.TabStop = false;
            this.grbOrderTotal.Text = "Order Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(83, 85);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TabStop = false;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(83, 57);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 4;
            this.txtTax.TabStop = false;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(83, 29);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(18, 88);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Order total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(11, 60);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(66, 13);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax (7.75%):";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(28, 32);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(304, 149);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(304, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLunchOrder
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(391, 272);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grbOrderTotal);
            this.Controls.Add(this.grbAddOns);
            this.Controls.Add(this.grbMainCourse);
            this.Name = "frmLunchOrder";
            this.Text = "Lunch Order";
            this.grbMainCourse.ResumeLayout(false);
            this.grbMainCourse.PerformLayout();
            this.grbAddOns.ResumeLayout(false);
            this.grbAddOns.PerformLayout();
            this.grbOrderTotal.ResumeLayout(false);
            this.grbOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMainCourse;
        private System.Windows.Forms.RadioButton rbSalad;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.RadioButton rbHamburger;
        private System.Windows.Forms.GroupBox grbAddOns;
        private System.Windows.Forms.GroupBox grbOrderTotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbAddon3;
        private System.Windows.Forms.CheckBox cbAddon2;
        private System.Windows.Forms.CheckBox cbAddon1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
    }
}

