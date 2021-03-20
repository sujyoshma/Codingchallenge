namespace VendingMachine
{
    partial class frmVendingMachine
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
            this.rbtn_cola = new System.Windows.Forms.RadioButton();
            this.rbtn_chips = new System.Windows.Forms.RadioButton();
            this.rbtn_candy = new System.Windows.Forms.RadioButton();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtn_cola
            // 
            this.rbtn_cola.AutoSize = true;
            this.rbtn_cola.Enabled = false;
            this.rbtn_cola.Location = new System.Drawing.Point(81, 49);
            this.rbtn_cola.Name = "rbtn_cola";
            this.rbtn_cola.Size = new System.Drawing.Size(46, 17);
            this.rbtn_cola.TabIndex = 1;
            this.rbtn_cola.TabStop = true;
            this.rbtn_cola.Text = "Cola";
            this.rbtn_cola.UseVisualStyleBackColor = true;
            this.rbtn_cola.CheckedChanged += new System.EventHandler(this.rbtn_cola_CheckedChanged);
            // 
            // rbtn_chips
            // 
            this.rbtn_chips.AutoSize = true;
            this.rbtn_chips.Enabled = false;
            this.rbtn_chips.Location = new System.Drawing.Point(81, 72);
            this.rbtn_chips.Name = "rbtn_chips";
            this.rbtn_chips.Size = new System.Drawing.Size(51, 17);
            this.rbtn_chips.TabIndex = 2;
            this.rbtn_chips.TabStop = true;
            this.rbtn_chips.Text = "Chips";
            this.rbtn_chips.UseVisualStyleBackColor = true;
            this.rbtn_chips.CheckedChanged += new System.EventHandler(this.rbtn_chips_CheckedChanged);
            // 
            // rbtn_candy
            // 
            this.rbtn_candy.AutoSize = true;
            this.rbtn_candy.Enabled = false;
            this.rbtn_candy.Location = new System.Drawing.Point(81, 95);
            this.rbtn_candy.Name = "rbtn_candy";
            this.rbtn_candy.Size = new System.Drawing.Size(55, 17);
            this.rbtn_candy.TabIndex = 3;
            this.rbtn_candy.TabStop = true;
            this.rbtn_candy.Text = "Candy";
            this.rbtn_candy.UseVisualStyleBackColor = true;
            this.rbtn_candy.CheckedChanged += new System.EventHandler(this.rbtn_candy_CheckedChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(79, 133);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(57, 13);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.Text = "Insert Coin";
            // 
            // frmVendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.rbtn_candy);
            this.Controls.Add(this.rbtn_chips);
            this.Controls.Add(this.rbtn_cola);
            this.Name = "frmVendingMachine";
            this.Text = "VendingMachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtn_cola;
        private System.Windows.Forms.RadioButton rbtn_chips;
        private System.Windows.Forms.RadioButton rbtn_candy;
        private System.Windows.Forms.Label lblDisplay;
    }
}

