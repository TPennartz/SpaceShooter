namespace SpaceShooter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveBackground = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.LeftMove_timer = new System.Windows.Forms.Timer(this.components);
            this.RightMove_timer = new System.Windows.Forms.Timer(this.components);
            this.DownMove_timer = new System.Windows.Forms.Timer(this.components);
            this.UpMove_timer = new System.Windows.Forms.Timer(this.components);
            this.MoveMuntionsTimer = new System.Windows.Forms.Timer(this.components);
            this.Move_enemies = new System.Windows.Forms.Timer(this.components);
            this.EnemiesMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Play_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Level_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBackground
            // 
            this.MoveBackground.Enabled = true;
            this.MoveBackground.Interval = 10;
            this.MoveBackground.Tick += new System.EventHandler(this.MoveBigTimer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(260, 400);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // LeftMove_timer
            // 
            this.LeftMove_timer.Interval = 5;
            this.LeftMove_timer.Tick += new System.EventHandler(this.LeftMove_timer_Tick);
            // 
            // RightMove_timer
            // 
            this.RightMove_timer.Interval = 5;
            this.RightMove_timer.Tick += new System.EventHandler(this.RightMove_timer_Tick);
            // 
            // DownMove_timer
            // 
            this.DownMove_timer.Interval = 5;
            this.DownMove_timer.Tick += new System.EventHandler(this.DownMove_timer_Tick);
            // 
            // UpMove_timer
            // 
            this.UpMove_timer.Interval = 5;
            this.UpMove_timer.Tick += new System.EventHandler(this.UpMove_timer_Tick);
            // 
            // MoveMuntionsTimer
            // 
            this.MoveMuntionsTimer.Enabled = true;
            this.MoveMuntionsTimer.Interval = 20;
            this.MoveMuntionsTimer.Tick += new System.EventHandler(this.MoveMuntionsTimer_Tick);
            // 
            // Move_enemies
            // 
            this.Move_enemies.Enabled = true;
            this.Move_enemies.Tick += new System.EventHandler(this.Move_enemies_Tick);
            // 
            // EnemiesMunitionTimer
            // 
            this.EnemiesMunitionTimer.Enabled = true;
            this.EnemiesMunitionTimer.Interval = 20;
            this.EnemiesMunitionTimer.Tick += new System.EventHandler(this.EnemiesMunitionTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(213, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Play_button
            // 
            this.Play_button.Location = new System.Drawing.Point(182, 216);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(205, 50);
            this.Play_button.TabIndex = 3;
            this.Play_button.Text = "Play ";
            this.Play_button.UseVisualStyleBackColor = true;
            this.Play_button.Visible = false;
            this.Play_button.Click += new System.EventHandler(this.Play_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(182, 283);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(205, 54);
            this.Exit_button.TabIndex = 4;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Visible = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Level_label
            // 
            this.Level_label.AutoSize = true;
            this.Level_label.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Level_label.Location = new System.Drawing.Point(516, 9);
            this.Level_label.Name = "Level_label";
            this.Level_label.Size = new System.Drawing.Size(0, 17);
            this.Level_label.TabIndex = 6;
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score_label.Location = new System.Drawing.Point(86, 9);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(0, 17);
            this.score_label.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(442, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.Level_label);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Play_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.Form1_load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBackground;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer LeftMove_timer;
        private System.Windows.Forms.Timer RightMove_timer;
        private System.Windows.Forms.Timer DownMove_timer;
        private System.Windows.Forms.Timer UpMove_timer;
        private System.Windows.Forms.Timer MoveMuntionsTimer;
        private System.Windows.Forms.Timer Move_enemies;
        private System.Windows.Forms.Timer EnemiesMunitionTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label Level_label;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

