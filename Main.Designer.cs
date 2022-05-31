namespace AutoClicker
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneTrackBar1 = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.MinCpsLabel = new System.Windows.Forms.Label();
            this.MaxCpsLabel = new System.Windows.Forms.Label();
            this.siticoneTrackBar2 = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.MinCpsValue = new System.Windows.Forms.Label();
            this.MaxCpsValue = new System.Windows.Forms.Label();
            this.Closedown = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Label();
            this.StartButton = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneTrackBar1
            // 
            this.siticoneTrackBar1.HoverState.Parent = this.siticoneTrackBar1;
            this.siticoneTrackBar1.Location = new System.Drawing.Point(12, 64);
            this.siticoneTrackBar1.Name = "siticoneTrackBar1";
            this.siticoneTrackBar1.Size = new System.Drawing.Size(300, 23);
            this.siticoneTrackBar1.TabIndex = 0;
            this.siticoneTrackBar1.ThumbColor = System.Drawing.Color.White;
            this.siticoneTrackBar1.Value = 10;
            this.siticoneTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneTrackBar1_Scroll);
            // 
            // MinCpsLabel
            // 
            this.MinCpsLabel.AutoSize = true;
            this.MinCpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinCpsLabel.ForeColor = System.Drawing.Color.White;
            this.MinCpsLabel.Location = new System.Drawing.Point(8, 41);
            this.MinCpsLabel.Name = "MinCpsLabel";
            this.MinCpsLabel.Size = new System.Drawing.Size(108, 20);
            this.MinCpsLabel.TabIndex = 1;
            this.MinCpsLabel.Text = "Minimum CPS";
            // 
            // MaxCpsLabel
            // 
            this.MaxCpsLabel.AutoSize = true;
            this.MaxCpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxCpsLabel.ForeColor = System.Drawing.Color.White;
            this.MaxCpsLabel.Location = new System.Drawing.Point(8, 91);
            this.MaxCpsLabel.Name = "MaxCpsLabel";
            this.MaxCpsLabel.Size = new System.Drawing.Size(112, 20);
            this.MaxCpsLabel.TabIndex = 3;
            this.MaxCpsLabel.Text = "Maximum CPS";
            // 
            // siticoneTrackBar2
            // 
            this.siticoneTrackBar2.HoverState.Parent = this.siticoneTrackBar2;
            this.siticoneTrackBar2.Location = new System.Drawing.Point(12, 114);
            this.siticoneTrackBar2.Name = "siticoneTrackBar2";
            this.siticoneTrackBar2.Size = new System.Drawing.Size(300, 23);
            this.siticoneTrackBar2.TabIndex = 2;
            this.siticoneTrackBar2.ThumbColor = System.Drawing.Color.White;
            this.siticoneTrackBar2.Value = 20;
            this.siticoneTrackBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneTrackBar2_Scroll);
            // 
            // MinCpsValue
            // 
            this.MinCpsValue.AutoSize = true;
            this.MinCpsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinCpsValue.ForeColor = System.Drawing.Color.White;
            this.MinCpsValue.Location = new System.Drawing.Point(318, 64);
            this.MinCpsValue.Name = "MinCpsValue";
            this.MinCpsValue.Size = new System.Drawing.Size(27, 20);
            this.MinCpsValue.TabIndex = 4;
            this.MinCpsValue.Text = "10";
            this.MinCpsValue.Click += new System.EventHandler(this.MinCpsValue_Click);
            // 
            // MaxCpsValue
            // 
            this.MaxCpsValue.AutoSize = true;
            this.MaxCpsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxCpsValue.ForeColor = System.Drawing.Color.White;
            this.MaxCpsValue.Location = new System.Drawing.Point(318, 114);
            this.MaxCpsValue.Name = "MaxCpsValue";
            this.MaxCpsValue.Size = new System.Drawing.Size(27, 20);
            this.MaxCpsValue.TabIndex = 5;
            this.MaxCpsValue.Text = "20";
            this.MaxCpsValue.Click += new System.EventHandler(this.MaxCpsValue_Click);
            // 
            // Closedown
            // 
            this.Closedown.AutoSize = true;
            this.Closedown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closedown.ForeColor = System.Drawing.Color.White;
            this.Closedown.Location = new System.Drawing.Point(333, 10);
            this.Closedown.Name = "Closedown";
            this.Closedown.Size = new System.Drawing.Size(14, 13);
            this.Closedown.TabIndex = 6;
            this.Closedown.Text = "X";
            this.Closedown.Click += new System.EventHandler(this.Closedown_Click);
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(314, 7);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(13, 13);
            this.Minimize.TabIndex = 7;
            this.Minimize.Text = "_";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(11, 7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(61, 13);
            this.Title.TabIndex = 8;
            this.Title.Text = "AutoClicker";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.Closedown);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 28);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.ForeColor = System.Drawing.Color.White;
            this.Info.Location = new System.Drawing.Point(255, 7);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(53, 13);
            this.Info.TabIndex = 9;
            this.Info.Text = "F9 = Stop";
            // 
            // StartButton
            // 
            this.StartButton.CheckedState.Parent = this.StartButton;
            this.StartButton.CustomImages.Parent = this.StartButton;
            this.StartButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartButton.DisabledState.Parent = this.StartButton;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.HoverState.Parent = this.StartButton;
            this.StartButton.Location = new System.Drawing.Point(12, 150);
            this.StartButton.Name = "StartButton";
            this.StartButton.ShadowDecoration.Parent = this.StartButton;
            this.StartButton.Size = new System.Drawing.Size(333, 45);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "START";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(354, 207);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MaxCpsValue);
            this.Controls.Add(this.MinCpsValue);
            this.Controls.Add(this.MaxCpsLabel);
            this.Controls.Add(this.siticoneTrackBar2);
            this.Controls.Add(this.MinCpsLabel);
            this.Controls.Add(this.siticoneTrackBar1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClicker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar siticoneTrackBar1;
        private System.Windows.Forms.Label MinCpsLabel;
        private System.Windows.Forms.Label MaxCpsLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar siticoneTrackBar2;
        private System.Windows.Forms.Label MinCpsValue;
        private System.Windows.Forms.Label MaxCpsValue;
        private System.Windows.Forms.Label Closedown;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Info;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton StartButton;
        private System.Windows.Forms.Timer timer1;
    }
}

