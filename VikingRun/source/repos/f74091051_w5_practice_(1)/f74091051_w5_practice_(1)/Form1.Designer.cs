namespace f74091051_w5_practice__1_
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
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rndgenerate = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.generatenum = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Label();
            this.substitudechart = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Label();
            this.down = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.enter2 = new System.Windows.Forms.Button();
            this.historybox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(78, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(62, 18);
            this.name.TabIndex = 0;
            this.name.Text = "替換表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "↓";
            // 
            // rndgenerate
            // 
            this.rndgenerate.Location = new System.Drawing.Point(507, 307);
            this.rndgenerate.Name = "rndgenerate";
            this.rndgenerate.Size = new System.Drawing.Size(113, 49);
            this.rndgenerate.TabIndex = 4;
            this.rndgenerate.Text = "隨機產生";
            this.rndgenerate.UseVisualStyleBackColor = true;
            this.rndgenerate.Click += new System.EventHandler(this.rndgenerate_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(507, 372);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 44);
            this.save.TabIndex = 5;
            this.save.Text = "確認";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // generatenum
            // 
            this.generatenum.Location = new System.Drawing.Point(42, 237);
            this.generatenum.Name = "generatenum";
            this.generatenum.Size = new System.Drawing.Size(523, 29);
            this.generatenum.TabIndex = 6;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(89, 339);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(0, 18);
            this.check.TabIndex = 7;
            // 
            // substitudechart
            // 
            this.substitudechart.Location = new System.Drawing.Point(680, 62);
            this.substitudechart.Name = "substitudechart";
            this.substitudechart.Size = new System.Drawing.Size(75, 30);
            this.substitudechart.TabIndex = 8;
            this.substitudechart.Text = "替換表";
            this.substitudechart.UseVisualStyleBackColor = true;
            this.substitudechart.Click += new System.EventHandler(this.substitudechart_Click);
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(680, 156);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(75, 34);
            this.encrypt.TabIndex = 9;
            this.encrypt.Text = "加密";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(680, 243);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(75, 36);
            this.decrypt.TabIndex = 10;
            this.decrypt.Text = "解密";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(643, 337);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(126, 34);
            this.history.TabIndex = 11;
            this.history.Text = "歷史紀錄";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // up
            // 
            this.up.AutoSize = true;
            this.up.Location = new System.Drawing.Point(78, 134);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(50, 18);
            this.up.TabIndex = 12;
            this.up.Text = "label1";
            // 
            // down
            // 
            this.down.AutoSize = true;
            this.down.Location = new System.Drawing.Point(78, 284);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(50, 18);
            this.down.TabIndex = 13;
            this.down.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 29);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(225, 272);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 29);
            this.textBox2.TabIndex = 15;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(319, 372);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(91, 44);
            this.enter.TabIndex = 16;
            this.enter.Text = "確認";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // enter2
            // 
            this.enter2.Location = new System.Drawing.Point(319, 372);
            this.enter2.Name = "enter2";
            this.enter2.Size = new System.Drawing.Size(91, 44);
            this.enter2.TabIndex = 17;
            this.enter2.Text = "確認";
            this.enter2.UseVisualStyleBackColor = true;
            this.enter2.Click += new System.EventHandler(this.enter2_Click);
            // 
            // historybox
            // 
            this.historybox.Location = new System.Drawing.Point(12, 65);
            this.historybox.Multiline = true;
            this.historybox.Name = "historybox";
            this.historybox.ReadOnly = true;
            this.historybox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.historybox.Size = new System.Drawing.Size(615, 360);
            this.historybox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historybox);
            this.Controls.Add(this.enter2);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.history);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.substitudechart);
            this.Controls.Add(this.check);
            this.Controls.Add(this.generatenum);
            this.Controls.Add(this.save);
            this.Controls.Add(this.rndgenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "替換式密碼";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rndgenerate;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox generatenum;
        private System.Windows.Forms.Label check;
        private System.Windows.Forms.Button substitudechart;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Label up;
        private System.Windows.Forms.Label down;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button enter2;
        private System.Windows.Forms.TextBox historybox;
    }
}

