
namespace AutoSeatDistribute
{
    partial class SeatControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SeatsPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SwitchButton = new System.Windows.Forms.Button();
            this.FirstTB = new System.Windows.Forms.TextBox();
            this.SecondTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(436, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 54);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeatsPanel
            // 
            this.SeatsPanel.Location = new System.Drawing.Point(30, 84);
            this.SeatsPanel.Name = "SeatsPanel";
            this.SeatsPanel.Size = new System.Drawing.Size(526, 268);
            this.SeatsPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoSeatDistribute.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(205, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SwitchButton
            // 
            this.SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SwitchButton.Location = new System.Drawing.Point(35, 13);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(75, 51);
            this.SwitchButton.TabIndex = 0;
            this.SwitchButton.Text = "Switch";
            this.SwitchButton.UseVisualStyleBackColor = true;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // FirstTB
            // 
            this.FirstTB.Location = new System.Drawing.Point(116, 13);
            this.FirstTB.Name = "FirstTB";
            this.FirstTB.Size = new System.Drawing.Size(67, 22);
            this.FirstTB.TabIndex = 0;
            // 
            // SecondTB
            // 
            this.SecondTB.Location = new System.Drawing.Point(116, 42);
            this.SecondTB.Name = "SecondTB";
            this.SecondTB.Size = new System.Drawing.Size(67, 22);
            this.SecondTB.TabIndex = 4;
            // 
            // SeatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.SecondTB);
            this.Controls.Add(this.FirstTB);
            this.Controls.Add(this.SwitchButton);
            this.Controls.Add(this.SeatsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SeatControl";
            this.Size = new System.Drawing.Size(586, 373);
            this.Load += new System.EventHandler(this.SeatControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SeatsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.TextBox FirstTB;
        private System.Windows.Forms.TextBox SecondTB;
    }
}
