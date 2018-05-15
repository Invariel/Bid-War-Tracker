namespace Bid_War_Tracker
{
    partial class BidWarTracker
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
            this.chk_OnlyExisting = new System.Windows.Forms.CheckBox();
            this.txt_Prefix = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dg_Scores = new System.Windows.Forms.DataGridView();
            this.dg_Column_Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_Column_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_bitsValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_StreamLabsOAuth = new System.Windows.Forms.Button();
            this.txt_StreamLabsOauth = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TwitchOAuth = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_TwitchOauth = new System.Windows.Forms.TextBox();
            this.txt_TwitchChannel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_StreamLabsRefresh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Scores)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_OnlyExisting
            // 
            this.chk_OnlyExisting.AutoSize = true;
            this.chk_OnlyExisting.Location = new System.Drawing.Point(372, 191);
            this.chk_OnlyExisting.Name = "chk_OnlyExisting";
            this.chk_OnlyExisting.Size = new System.Drawing.Size(148, 17);
            this.chk_OnlyExisting.TabIndex = 4;
            this.chk_OnlyExisting.Text = "Only Allow Existing Words";
            this.chk_OnlyExisting.UseVisualStyleBackColor = true;
            // 
            // txt_Prefix
            // 
            this.txt_Prefix.Location = new System.Drawing.Point(83, 188);
            this.txt_Prefix.Name = "txt_Prefix";
            this.txt_Prefix.Size = new System.Drawing.Size(129, 20);
            this.txt_Prefix.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Word Prefix";
            // 
            // dg_Scores
            // 
            this.dg_Scores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Scores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_Column_Word,
            this.dg_Column_Score});
            this.dg_Scores.Location = new System.Drawing.Point(12, 12);
            this.dg_Scores.Name = "dg_Scores";
            this.dg_Scores.Size = new System.Drawing.Size(508, 173);
            this.dg_Scores.TabIndex = 1;
            // 
            // dg_Column_Word
            // 
            this.dg_Column_Word.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Column_Word.HeaderText = "Word";
            this.dg_Column_Word.Name = "dg_Column_Word";
            // 
            // dg_Column_Score
            // 
            this.dg_Column_Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Column_Score.FillWeight = 25F;
            this.dg_Column_Score.HeaderText = "Score";
            this.dg_Column_Score.Name = "dg_Column_Score";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(445, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 100;
            this.button3.Text = "Begin";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.lbl_bitsValue);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.numericUpDown5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.numericUpDown7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.numericUpDown8);
            this.groupBox4.Controls.Add(this.numericUpDown3);
            this.groupBox4.Controls.Add(this.numericUpDown6);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numericUpDown4);
            this.groupBox4.Location = new System.Drawing.Point(218, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 183);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Point Values";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(191, 19);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown2.TabIndex = 63;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 13);
            this.label11.TabIndex = 78;
            this.label11.Text = "A Tier Three subscription is worth";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(34, 19);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown1.TabIndex = 61;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "A Tier Two subscription is worth";
            // 
            // lbl_bitsValue
            // 
            this.lbl_bitsValue.AutoSize = true;
            this.lbl_bitsValue.Location = new System.Drawing.Point(109, 23);
            this.lbl_bitsValue.Name = "lbl_bitsValue";
            this.lbl_bitsValue.Size = new System.Drawing.Size(76, 13);
            this.lbl_bitsValue.TabIndex = 62;
            this.lbl_bitsValue.Text = "bit(s) are worth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "A Tier One subscription is worth";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(191, 72);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown5.TabIndex = 70;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "A Twitch Prime subscription is worth";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(191, 125);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown7.TabIndex = 76;
            this.numericUpDown7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "point(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "point(s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "point(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "point(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "point(s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "point(s)";
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(191, 152);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown8.TabIndex = 79;
            this.numericUpDown8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown3.Location = new System.Drawing.Point(34, 46);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown3.TabIndex = 65;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(191, 99);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown6.TabIndex = 73;
            this.numericUpDown6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "tipped is worth";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(191, 46);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown4.TabIndex = 67;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_StreamLabsRefresh);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btn_StreamLabsOAuth);
            this.groupBox3.Controls.Add(this.txt_StreamLabsOauth);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(12, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 96);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "StreamLabs Connection Settings";
            // 
            // btn_StreamLabsOAuth
            // 
            this.btn_StreamLabsOAuth.Location = new System.Drawing.Point(8, 67);
            this.btn_StreamLabsOAuth.Name = "btn_StreamLabsOAuth";
            this.btn_StreamLabsOAuth.Size = new System.Drawing.Size(186, 23);
            this.btn_StreamLabsOAuth.TabIndex = 45;
            this.btn_StreamLabsOAuth.Text = "Generate OAuth Tokens";
            this.btn_StreamLabsOAuth.UseVisualStyleBackColor = true;
            // 
            // txt_StreamLabsOauth
            // 
            this.txt_StreamLabsOauth.Location = new System.Drawing.Point(83, 17);
            this.txt_StreamLabsOauth.Name = "txt_StreamLabsOauth";
            this.txt_StreamLabsOauth.Size = new System.Drawing.Size(111, 20);
            this.txt_StreamLabsOauth.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Oauth Token";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TwitchOAuth);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_TwitchOauth);
            this.groupBox1.Controls.Add(this.txt_TwitchChannel);
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Twitch Connection Settings";
            // 
            // btn_TwitchOAuth
            // 
            this.btn_TwitchOAuth.Location = new System.Drawing.Point(8, 71);
            this.btn_TwitchOAuth.Name = "btn_TwitchOAuth";
            this.btn_TwitchOAuth.Size = new System.Drawing.Size(186, 23);
            this.btn_TwitchOAuth.TabIndex = 25;
            this.btn_TwitchOAuth.Text = "Generate OAuth Token";
            this.btn_TwitchOAuth.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Oauth Token";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Channel Name";
            // 
            // txt_TwitchOauth
            // 
            this.txt_TwitchOauth.Location = new System.Drawing.Point(83, 46);
            this.txt_TwitchOauth.Name = "txt_TwitchOauth";
            this.txt_TwitchOauth.Size = new System.Drawing.Size(111, 20);
            this.txt_TwitchOauth.TabIndex = 24;
            // 
            // txt_TwitchChannel
            // 
            this.txt_TwitchChannel.Location = new System.Drawing.Point(83, 19);
            this.txt_TwitchChannel.Name = "txt_TwitchChannel";
            this.txt_TwitchChannel.Size = new System.Drawing.Size(111, 20);
            this.txt_TwitchChannel.TabIndex = 22;
            this.txt_TwitchChannel.Text = "Channel Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Refresh Token";
            // 
            // txt_StreamLabsRefresh
            // 
            this.txt_StreamLabsRefresh.Location = new System.Drawing.Point(83, 41);
            this.txt_StreamLabsRefresh.Name = "txt_StreamLabsRefresh";
            this.txt_StreamLabsRefresh.Size = new System.Drawing.Size(111, 20);
            this.txt_StreamLabsRefresh.TabIndex = 44;
            // 
            // BidWarTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 436);
            this.Controls.Add(this.chk_OnlyExisting);
            this.Controls.Add(this.txt_Prefix);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dg_Scores);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "BidWarTracker";
            this.Text = "Bid War Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Scores)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_OnlyExisting;
        private System.Windows.Forms.TextBox txt_Prefix;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dg_Scores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_Column_Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_Column_Score;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_bitsValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_StreamLabsOAuth;
        private System.Windows.Forms.TextBox txt_StreamLabsOauth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TwitchOAuth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_TwitchOauth;
        private System.Windows.Forms.TextBox txt_TwitchChannel;
        private System.Windows.Forms.TextBox txt_StreamLabsRefresh;
        private System.Windows.Forms.Label label16;
    }
}

