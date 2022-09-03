
namespace AutoSeatDistribute
{
    partial class Action
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lastbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.PPLNText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RowsSeatsPanel = new System.Windows.Forms.Panel();
            this.EachRowsSeats = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ClassNameLable = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.Animation = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.RowsSeatsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.Lastbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 31);
            this.panel1.TabIndex = 0;
            // 
            // Lastbutton
            // 
            this.Lastbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lastbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lastbutton.Font = new System.Drawing.Font("新細明體", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lastbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lastbutton.Location = new System.Drawing.Point(692, 6);
            this.Lastbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Lastbutton.Name = "Lastbutton";
            this.Lastbutton.Size = new System.Drawing.Size(20, 19);
            this.Lastbutton.TabIndex = 3;
            this.Lastbutton.Text = "<";
            this.Lastbutton.UseVisualStyleBackColor = false;
            this.Lastbutton.Click += new System.EventHandler(this.Lastbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "TCIVS Seats Allocation System";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("新細明體", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Location = new System.Drawing.Point(716, 6);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 19);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.Animation);
            this.panel2.Controls.Add(this.GenerateButton);
            this.panel2.Controls.Add(this.PPLNText);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.RowsSeatsPanel);
            this.panel2.Controls.Add(this.ClassNameLable);
            this.panel2.Controls.Add(this.ControlPanel);
            this.panel2.Location = new System.Drawing.Point(-1, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 418);
            this.panel2.TabIndex = 1;
            // 
            // GenerateButton
            // 
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Location = new System.Drawing.Point(37, 384);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(69, 27);
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PPLNText
            // 
            this.PPLNText.Location = new System.Drawing.Point(34, 356);
            this.PPLNText.Margin = new System.Windows.Forms.Padding(2);
            this.PPLNText.Name = "PPLNText";
            this.PPLNText.Size = new System.Drawing.Size(76, 22);
            this.PPLNText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of People:";
            // 
            // RowsSeatsPanel
            // 
            this.RowsSeatsPanel.Controls.Add(this.EachRowsSeats);
            this.RowsSeatsPanel.Controls.Add(this.panel5);
            this.RowsSeatsPanel.Location = new System.Drawing.Point(10, 22);
            this.RowsSeatsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.RowsSeatsPanel.Name = "RowsSeatsPanel";
            this.RowsSeatsPanel.Size = new System.Drawing.Size(129, 313);
            this.RowsSeatsPanel.TabIndex = 2;
            // 
            // EachRowsSeats
            // 
            this.EachRowsSeats.AutoSize = true;
            this.EachRowsSeats.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EachRowsSeats.Location = new System.Drawing.Point(12, 8);
            this.EachRowsSeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EachRowsSeats.Name = "EachRowsSeats";
            this.EachRowsSeats.Size = new System.Drawing.Size(109, 16);
            this.EachRowsSeats.TabIndex = 1;
            this.EachRowsSeats.Text = "EachRowsSeats";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Location = new System.Drawing.Point(0, 26);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(129, 4);
            this.panel5.TabIndex = 0;
            // 
            // ClassNameLable
            // 
            this.ClassNameLable.AutoSize = true;
            this.ClassNameLable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassNameLable.Location = new System.Drawing.Point(639, 398);
            this.ClassNameLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassNameLable.Name = "ClassNameLable";
            this.ClassNameLable.Size = new System.Drawing.Size(41, 15);
            this.ClassNameLable.TabIndex = 1;
            this.ClassNameLable.Text = "label1";
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ControlPanel.Location = new System.Drawing.Point(151, 22);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(586, 373);
            this.ControlPanel.TabIndex = 0;
            // 
            // Animation
            // 
            this.Animation.AutoSize = true;
            this.Animation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animation.Location = new System.Drawing.Point(151, 397);
            this.Animation.Name = "Animation";
            this.Animation.Size = new System.Drawing.Size(81, 19);
            this.Animation.TabIndex = 6;
            this.Animation.Text = "Animation";
            this.Animation.UseVisualStyleBackColor = true;
            this.Animation.CheckStateChanged += new System.EventHandler(this.Animation_CheckStateChanged);
            // 
            // Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(745, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Action";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Action_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.RowsSeatsPanel.ResumeLayout(false);
            this.RowsSeatsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ClassNameLable;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel RowsSeatsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Lastbutton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox PPLNText;
        private System.Windows.Forms.Label EachRowsSeats;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox Animation;
    }
}

