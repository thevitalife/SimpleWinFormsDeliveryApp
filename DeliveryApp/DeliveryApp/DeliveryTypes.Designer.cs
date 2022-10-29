
namespace DeliveryApp
{
    partial class DeliveryTypes
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
            this.DGTypes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGTypes
            // 
            this.DGTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGTypes.Location = new System.Drawing.Point(0, 0);
            this.DGTypes.MultiSelect = false;
            this.DGTypes.Name = "DGTypes";
            this.DGTypes.RowHeadersWidth = 51;
            this.DGTypes.RowTemplate.Height = 29;
            this.DGTypes.Size = new System.Drawing.Size(455, 447);
            this.DGTypes.TabIndex = 0;
            // 
            // DeliveryTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 447);
            this.Controls.Add(this.DGTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeliveryTypes";
            this.Text = "DeliveryTypes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeliveryTypes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGTypes;
    }
}