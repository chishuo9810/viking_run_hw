namespace F74091051_W5_practice2
{
    partial class Form1
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
            this.record_textbox = new System.Windows.Forms.TextBox();
            this.feed = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.sweep = new System.Windows.Forms.Button();
            this.see_doctor = new System.Windows.Forms.Button();
            this.finish_the_day = new System.Windows.Forms.Button();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.enter_name = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.Label();
            this.mood = new System.Windows.Forms.Label();
            this.belly = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.accident = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // record_textbox
            // 
            this.record_textbox.Location = new System.Drawing.Point(-2, 1);
            this.record_textbox.Multiline = true;
            this.record_textbox.Name = "record_textbox";
            this.record_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.record_textbox.Size = new System.Drawing.Size(358, 389);
            this.record_textbox.TabIndex = 0;
            // 
            // feed
            // 
            this.feed.Location = new System.Drawing.Point(366, 331);
            this.feed.Name = "feed";
            this.feed.Size = new System.Drawing.Size(87, 36);
            this.feed.TabIndex = 1;
            this.feed.Text = "餵食";
            this.feed.UseVisualStyleBackColor = true;
            this.feed.Click += new System.EventHandler(this.feed_Click);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(477, 330);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(88, 37);
            this.play.TabIndex = 2;
            this.play.Text = "玩耍";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // sweep
            // 
            this.sweep.Location = new System.Drawing.Point(586, 331);
            this.sweep.Name = "sweep";
            this.sweep.Size = new System.Drawing.Size(94, 36);
            this.sweep.TabIndex = 3;
            this.sweep.Text = "打掃";
            this.sweep.UseVisualStyleBackColor = true;
            this.sweep.Click += new System.EventHandler(this.sweep_Click);
            // 
            // see_doctor
            // 
            this.see_doctor.Location = new System.Drawing.Point(709, 331);
            this.see_doctor.Name = "see_doctor";
            this.see_doctor.Size = new System.Drawing.Size(81, 36);
            this.see_doctor.TabIndex = 4;
            this.see_doctor.Text = "看醫生";
            this.see_doctor.UseVisualStyleBackColor = true;
            this.see_doctor.Click += new System.EventHandler(this.see_doctor_Click);
            // 
            // finish_the_day
            // 
            this.finish_the_day.Location = new System.Drawing.Point(600, 393);
            this.finish_the_day.Name = "finish_the_day";
            this.finish_the_day.Size = new System.Drawing.Size(190, 36);
            this.finish_the_day.TabIndex = 5;
            this.finish_the_day.Text = "結束這一天";
            this.finish_the_day.UseVisualStyleBackColor = true;
            this.finish_the_day.Click += new System.EventHandler(this.finish_the_day_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(12, 400);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(230, 29);
            this.name_textbox.TabIndex = 6;
            // 
            // enter_name
            // 
            this.enter_name.Location = new System.Drawing.Point(261, 400);
            this.enter_name.Name = "enter_name";
            this.enter_name.Size = new System.Drawing.Size(101, 29);
            this.enter_name.TabIndex = 7;
            this.enter_name.Text = "輸入名字";
            this.enter_name.UseVisualStyleBackColor = true;
            this.enter_name.Click += new System.EventHandler(this.enter_name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "金錢";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "狀態";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "事件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "健康:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "飽足感:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "體重:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "心情:";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(428, 54);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(16, 18);
            this.money.TabIndex = 15;
            this.money.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "元";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(583, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(583, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(583, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "g";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(583, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "%";
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Location = new System.Drawing.Point(514, 116);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(16, 18);
            this.health.TabIndex = 21;
            this.health.Text = "0";
            // 
            // mood
            // 
            this.mood.AutoSize = true;
            this.mood.Location = new System.Drawing.Point(514, 199);
            this.mood.Name = "mood";
            this.mood.Size = new System.Drawing.Size(16, 18);
            this.mood.TabIndex = 22;
            this.mood.Text = "0";
            // 
            // belly
            // 
            this.belly.AutoSize = true;
            this.belly.Location = new System.Drawing.Point(514, 171);
            this.belly.Name = "belly";
            this.belly.Size = new System.Drawing.Size(16, 18);
            this.belly.TabIndex = 23;
            this.belly.Text = "0";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(514, 143);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(16, 18);
            this.weight.TabIndex = 24;
            this.weight.Text = "0";
            // 
            // accident
            // 
            this.accident.Location = new System.Drawing.Point(428, 260);
            this.accident.Name = "accident";
            this.accident.Size = new System.Drawing.Size(264, 32);
            this.accident.TabIndex = 25;
            this.accident.Text = "幫寵物取名字";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accident);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.belly);
            this.Controls.Add(this.mood);
            this.Controls.Add(this.health);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enter_name);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.finish_the_day);
            this.Controls.Add(this.see_doctor);
            this.Controls.Add(this.sweep);
            this.Controls.Add(this.play);
            this.Controls.Add(this.feed);
            this.Controls.Add(this.record_textbox);
            this.Name = "Form1";
            this.Text = "電子雞";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox record_textbox;
        private System.Windows.Forms.Button feed;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button sweep;
        private System.Windows.Forms.Button see_doctor;
        private System.Windows.Forms.Button finish_the_day;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button enter_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label mood;
        private System.Windows.Forms.Label belly;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label accident;
    }
}

