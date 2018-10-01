namespace russian
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnload = new System.Windows.Forms.Button();
            this.btnspin = new System.Windows.Forms.Button();
            this.btntry = new System.Windows.Forms.Button();
            this.btnshoot = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnrules = new System.Windows.Forms.Button();
            this.label1_player = new System.Windows.Forms.Label();
            this.label_round = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.DarkRed;
            this.btnload.BackgroundImage = global::russian.Properties.Resources.load;
            this.btnload.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnload.Location = new System.Drawing.Point(3, 12);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(169, 76);
            this.btnload.TabIndex = 0;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnspin
            // 
            this.btnspin.BackColor = System.Drawing.Color.Maroon;
            this.btnspin.BackgroundImage = global::russian.Properties.Resources.spin;
            this.btnspin.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnspin.Location = new System.Drawing.Point(3, 108);
            this.btnspin.Name = "btnspin";
            this.btnspin.Size = new System.Drawing.Size(169, 73);
            this.btnspin.TabIndex = 1;
            this.btnspin.Text = "Spin";
            this.btnspin.UseVisualStyleBackColor = false;
            this.btnspin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btntry
            // 
            this.btntry.BackColor = System.Drawing.Color.Maroon;
            this.btntry.Font = new System.Drawing.Font("Lucida Console", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntry.Location = new System.Drawing.Point(578, 419);
            this.btntry.Name = "btntry";
            this.btntry.Size = new System.Drawing.Size(209, 69);
            this.btntry.TabIndex = 2;
            this.btntry.Text = "Try Again";
            this.btntry.UseVisualStyleBackColor = false;
            this.btntry.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnshoot
            // 
            this.btnshoot.BackColor = System.Drawing.Color.Maroon;
            this.btnshoot.Font = new System.Drawing.Font("Lucida Console", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshoot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnshoot.Location = new System.Drawing.Point(3, 203);
            this.btnshoot.Name = "btnshoot";
            this.btnshoot.Size = new System.Drawing.Size(169, 64);
            this.btnshoot.TabIndex = 3;
            this.btnshoot.Text = "Shoot";
            this.btnshoot.UseVisualStyleBackColor = false;
            this.btnshoot.Click += new System.EventHandler(this.btnshoot_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Maroon;
            this.btnexit.Font = new System.Drawing.Font("Lucida Console", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(252, 413);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(184, 47);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnrules
            // 
            this.btnrules.BackColor = System.Drawing.Color.Maroon;
            this.btnrules.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrules.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrules.Location = new System.Drawing.Point(236, 347);
            this.btnrules.Name = "btnrules";
            this.btnrules.Size = new System.Drawing.Size(209, 60);
            this.btnrules.TabIndex = 5;
            this.btnrules.Text = "RULES";
            this.btnrules.UseVisualStyleBackColor = false;
            this.btnrules.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label1_player
            // 
            this.label1_player.AutoSize = true;
            this.label1_player.BackColor = System.Drawing.Color.Transparent;
            this.label1_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_player.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1_player.Location = new System.Drawing.Point(459, 72);
            this.label1_player.Name = "label1_player";
            this.label1_player.Size = new System.Drawing.Size(126, 29);
            this.label1_player.TabIndex = 6;
            this.label1_player.Text = "PLAYER :";
            // 
            // label_round
            // 
            this.label_round.AutoSize = true;
            this.label_round.BackColor = System.Drawing.Color.Transparent;
            this.label_round.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_round.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_round.Location = new System.Drawing.Point(556, 301);
            this.label_round.Name = "label_round";
            this.label_round.Size = new System.Drawing.Size(139, 29);
            this.label_round.TabIndex = 7;
            this.label_round.Text = "ROUND : 0";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_score.Location = new System.Drawing.Point(556, 272);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(137, 29);
            this.label_score.TabIndex = 8;
            this.label_score.Text = "SCORE : 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::russian.Properties.Resources.spin;
            this.pictureBox1.Location = new System.Drawing.Point(205, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 230);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6650;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(205, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 220);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(205, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(444, 229);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::russian.Properties.Resources.ssss;
            this.ClientSize = new System.Drawing.Size(799, 500);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_round);
            this.Controls.Add(this.label1_player);
            this.Controls.Add(this.btnrules);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnshoot);
            this.Controls.Add(this.btntry);
            this.Controls.Add(this.btnspin);
            this.Controls.Add(this.btnload);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnspin;
        private System.Windows.Forms.Button btntry;
        private System.Windows.Forms.Button btnshoot;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnrules;
        private System.Windows.Forms.Label label1_player;
        private System.Windows.Forms.Label label_round;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer3;
    }
}