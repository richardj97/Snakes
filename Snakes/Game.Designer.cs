namespace Snakes
{
    partial class Game
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
            this.GreetingPanel = new System.Windows.Forms.Panel();
            this.HiscoresLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.GreetingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GreetingPanel
            // 
            this.GreetingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GreetingPanel.Controls.Add(this.HiscoresLabel);
            this.GreetingPanel.Controls.Add(this.ScoreLabel);
            this.GreetingPanel.Controls.Add(this.GreetingLabel);
            this.GreetingPanel.Location = new System.Drawing.Point(31, 28);
            this.GreetingPanel.Name = "GreetingPanel";
            this.GreetingPanel.Size = new System.Drawing.Size(422, 407);
            this.GreetingPanel.TabIndex = 0;
            // 
            // HiscoresLabel
            // 
            this.HiscoresLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HiscoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiscoresLabel.ForeColor = System.Drawing.Color.White;
            this.HiscoresLabel.Location = new System.Drawing.Point(0, 232);
            this.HiscoresLabel.Name = "HiscoresLabel";
            this.HiscoresLabel.Size = new System.Drawing.Size(422, 78);
            this.HiscoresLabel.TabIndex = 2;
            this.HiscoresLabel.Text = "PRESS ESC TO EXIT";
            this.HiscoresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HiscoresLabel.Visible = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(0, 99);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(422, 78);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "SCORE: 0";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScoreLabel.Visible = false;
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GreetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.GreetingLabel.Location = new System.Drawing.Point(0, 0);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(422, 407);
            this.GreetingLabel.TabIndex = 0;
            this.GreetingLabel.Text = "PRESS SPACE TO START";
            this.GreetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.GreetingPanel);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.ShowIcon = false;
            this.Text = "Snakes - by Richard Jacobs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            this.GreetingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GreetingPanel;
        private System.Windows.Forms.Label GreetingLabel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label HiscoresLabel;
    }
}