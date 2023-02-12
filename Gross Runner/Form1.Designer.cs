namespace Gross_Runner
{
    partial class GamePlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlay));
            this.Character1 = new System.Windows.Forms.PictureBox();
            this.Wall3 = new System.Windows.Forms.PictureBox();
            this.Wall5 = new System.Windows.Forms.PictureBox();
            this.Wall4 = new System.Windows.Forms.PictureBox();
            this.Wall2 = new System.Windows.Forms.PictureBox();
            this.Wall6 = new System.Windows.Forms.PictureBox();
            this.gameRunning = new System.Windows.Forms.Timer(this.components);
            this.try_again = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.Wall7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Character1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall7)).BeginInit();
            this.SuspendLayout();
            // 
            // Character1
            // 
            this.Character1.BackColor = System.Drawing.Color.RosyBrown;
            this.Character1.Location = new System.Drawing.Point(191, 515);
            this.Character1.Name = "Character1";
            this.Character1.Size = new System.Drawing.Size(21, 32);
            this.Character1.TabIndex = 0;
            this.Character1.TabStop = false;
            // 
            // Wall3
            // 
            this.Wall3.BackColor = System.Drawing.Color.Gray;
            this.Wall3.Location = new System.Drawing.Point(266, 239);
            this.Wall3.Name = "Wall3";
            this.Wall3.Size = new System.Drawing.Size(194, 98);
            this.Wall3.TabIndex = 1;
            this.Wall3.TabStop = false;
            // 
            // Wall5
            // 
            this.Wall5.BackColor = System.Drawing.Color.Gray;
            this.Wall5.Location = new System.Drawing.Point(180, 45);
            this.Wall5.Name = "Wall5";
            this.Wall5.Size = new System.Drawing.Size(71, 52);
            this.Wall5.TabIndex = 2;
            this.Wall5.TabStop = false;
            // 
            // Wall4
            // 
            this.Wall4.BackColor = System.Drawing.Color.Gray;
            this.Wall4.Location = new System.Drawing.Point(12, 30);
            this.Wall4.Name = "Wall4";
            this.Wall4.Size = new System.Drawing.Size(83, 165);
            this.Wall4.TabIndex = 3;
            this.Wall4.TabStop = false;
            // 
            // Wall2
            // 
            this.Wall2.BackColor = System.Drawing.Color.Gray;
            this.Wall2.Location = new System.Drawing.Point(12, 292);
            this.Wall2.Name = "Wall2";
            this.Wall2.Size = new System.Drawing.Size(122, 133);
            this.Wall2.TabIndex = 4;
            this.Wall2.TabStop = false;
            // 
            // Wall6
            // 
            this.Wall6.BackColor = System.Drawing.Color.Gray;
            this.Wall6.Location = new System.Drawing.Point(308, -160);
            this.Wall6.Name = "Wall6";
            this.Wall6.Size = new System.Drawing.Size(126, 105);
            this.Wall6.TabIndex = 5;
            this.Wall6.TabStop = false;
            // 
            // gameRunning
            // 
            this.gameRunning.Interval = 50;
            this.gameRunning.Tick += new System.EventHandler(this.gameRunning_Tick);
            // 
            // try_again
            // 
            this.try_again.BackColor = System.Drawing.Color.Orange;
            this.try_again.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.try_again.ForeColor = System.Drawing.Color.DarkRed;
            this.try_again.Location = new System.Drawing.Point(68, 239);
            this.try_again.Name = "try_again";
            this.try_again.Size = new System.Drawing.Size(294, 98);
            this.try_again.TabIndex = 6;
            this.try_again.UseVisualStyleBackColor = false;
            this.try_again.Visible = false;
            this.try_again.Click += new System.EventHandler(this.try_again_Click);
            this.try_again.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Restart_Press);
            // 
            // Pause
            // 
            this.Pause.AutoSize = true;
            this.Pause.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pause.Location = new System.Drawing.Point(432, 9);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(15, 15);
            this.Pause.TabIndex = 7;
            this.Pause.Text = "||";
            this.Pause.Click += new System.EventHandler(this.pause_click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(373, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(15, 15);
            this.score.TabIndex = 8;
            this.score.Text = "0";
            // 
            // Wall7
            // 
            this.Wall7.BackColor = System.Drawing.Color.Gray;
            this.Wall7.InitialImage = ((System.Drawing.Image)(resources.GetObject("Wall7.InitialImage")));
            this.Wall7.Location = new System.Drawing.Point(341, 151);
            this.Wall7.Name = "Wall7";
            this.Wall7.Size = new System.Drawing.Size(106, 66);
            this.Wall7.TabIndex = 9;
            this.Wall7.TabStop = false;
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(459, 596);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.score);
            this.Controls.Add(this.try_again);
            this.Controls.Add(this.Wall6);
            this.Controls.Add(this.Wall2);
            this.Controls.Add(this.Wall4);
            this.Controls.Add(this.Wall5);
            this.Controls.Add(this.Wall3);
            this.Controls.Add(this.Character1);
            this.Controls.Add(this.Wall7);
            this.MaximizeBox = false;
            this.Name = "GamePlay";
            this.Text = "Play";
            this.Load += new System.EventHandler(this.GamePlay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Behaviour1);
            ((System.ComponentModel.ISupportInitialize)(this.Character1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Character1;
        private System.Windows.Forms.PictureBox Wall3;
        private System.Windows.Forms.PictureBox Wall5;
        private System.Windows.Forms.PictureBox Wall4;
        private System.Windows.Forms.PictureBox Wall2;
        private System.Windows.Forms.PictureBox Wall6;
        private System.Windows.Forms.Timer gameRunning;
        private System.Windows.Forms.Button try_again;
        private System.Windows.Forms.Label Pause;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox Wall7;
    }
}

