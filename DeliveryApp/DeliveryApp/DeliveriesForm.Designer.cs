
namespace DeliveryApp
{
    partial class DeliveriesForm
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.DGDeliveries = new System.Windows.Forms.DataGridView();
            this.BTypes = new System.Windows.Forms.Button();
            this.PButtons = new System.Windows.Forms.Panel();
            this.BFinish = new System.Windows.Forms.Button();
            this.BStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGDeliveries)).BeginInit();
            this.PButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 12);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(154, 42);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create delivery";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DGDeliveries
            // 
            this.DGDeliveries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGDeliveries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDeliveries.Location = new System.Drawing.Point(0, 70);
            this.DGDeliveries.MultiSelect = false;
            this.DGDeliveries.Name = "DGDeliveries";
            this.DGDeliveries.RowHeadersWidth = 51;
            this.DGDeliveries.RowTemplate.Height = 29;
            this.DGDeliveries.Size = new System.Drawing.Size(1035, 380);
            this.DGDeliveries.TabIndex = 1;
            this.DGDeliveries.SelectionChanged += new System.EventHandler(this.DGDeliveries_SelectionChanged);
            // 
            // BTypes
            // 
            this.BTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTypes.Location = new System.Drawing.Point(860, 12);
            this.BTypes.Name = "BTypes";
            this.BTypes.Size = new System.Drawing.Size(163, 42);
            this.BTypes.TabIndex = 2;
            this.BTypes.Text = "Types";
            this.BTypes.UseVisualStyleBackColor = true;
            this.BTypes.Click += new System.EventHandler(this.BTypes_Click);
            // 
            // PButtons
            // 
            this.PButtons.Controls.Add(this.BFinish);
            this.PButtons.Controls.Add(this.BStart);
            this.PButtons.Controls.Add(this.CreateButton);
            this.PButtons.Controls.Add(this.BTypes);
            this.PButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.PButtons.Location = new System.Drawing.Point(0, 0);
            this.PButtons.Name = "PButtons";
            this.PButtons.Size = new System.Drawing.Size(1035, 64);
            this.PButtons.TabIndex = 3;
            // 
            // BFinish
            // 
            this.BFinish.Location = new System.Drawing.Point(332, 12);
            this.BFinish.Name = "BFinish";
            this.BFinish.Size = new System.Drawing.Size(154, 42);
            this.BFinish.TabIndex = 4;
            this.BFinish.Text = "Finish delivery";
            this.BFinish.UseVisualStyleBackColor = true;
            this.BFinish.Click += new System.EventHandler(this.BFinish_Click);
            // 
            // BStart
            // 
            this.BStart.Location = new System.Drawing.Point(172, 12);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(154, 42);
            this.BStart.TabIndex = 3;
            this.BStart.Text = "Start delivery";
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // DeliveriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.PButtons);
            this.Controls.Add(this.DGDeliveries);
            this.Name = "DeliveriesForm";
            this.Text = "Deliveries";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DGDeliveries)).EndInit();
            this.PButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridView DGDeliveries;
        private System.Windows.Forms.Button BTypes;
        private System.Windows.Forms.Panel PButtons;
        private System.Windows.Forms.Button BStart;
        private System.Windows.Forms.Button BFinish;
    }
}

