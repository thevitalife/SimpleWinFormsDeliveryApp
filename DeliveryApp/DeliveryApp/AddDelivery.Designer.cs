
namespace DeliveryApp
{
    partial class AddDelivery
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
            this.TBFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBDescription = new System.Windows.Forms.TextBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TBMass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TBFrom
            // 
            this.TBFrom.Location = new System.Drawing.Point(12, 32);
            this.TBFrom.Name = "TBFrom";
            this.TBFrom.Size = new System.Drawing.Size(384, 27);
            this.TBFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // TBTo
            // 
            this.TBTo.Location = new System.Drawing.Point(12, 85);
            this.TBTo.Name = "TBTo";
            this.TBTo.Size = new System.Drawing.Size(384, 27);
            this.TBTo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // TBDescription
            // 
            this.TBDescription.Location = new System.Drawing.Point(12, 138);
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.Size = new System.Drawing.Size(384, 27);
            this.TBDescription.TabIndex = 4;
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(12, 290);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(384, 33);
            this.BAdd.TabIndex = 6;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mass";
            // 
            // TBMass
            // 
            this.TBMass.Location = new System.Drawing.Point(12, 191);
            this.TBMass.Name = "TBMass";
            this.TBMass.Size = new System.Drawing.Size(384, 27);
            this.TBMass.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type";
            // 
            // CBType
            // 
            this.CBType.FormattingEnabled = true;
            this.CBType.Location = new System.Drawing.Point(12, 245);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(384, 28);
            this.CBType.TabIndex = 10;
            // 
            // AddDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 335);
            this.Controls.Add(this.CBType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBMass);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddDelivery";
            this.Text = "Add delivery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDelivery_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBDescription;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBMass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBType;
    }
}