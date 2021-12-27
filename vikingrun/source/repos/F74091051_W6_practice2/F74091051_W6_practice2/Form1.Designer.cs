namespace F74091051_W6_practice2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.third_rb = new System.Windows.Forms.RadioButton();
            this.second_rb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.first_rb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.downright_rb = new System.Windows.Forms.RadioButton();
            this.downmid_rb = new System.Windows.Forms.RadioButton();
            this.upright_rb = new System.Windows.Forms.RadioButton();
            this.downleft_rb = new System.Windows.Forms.RadioButton();
            this.upleft_rb = new System.Windows.Forms.RadioButton();
            this.upmid_rb = new System.Windows.Forms.RadioButton();
            this.bold_rb = new System.Windows.Forms.CheckBox();
            this.italic_rb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wordsize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.word = new System.Windows.Forms.TextBox();
            this.last = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Label();
            this.down = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::F74091051_W6_practice2.Properties.Resources.pic_01_1_;
            this.pictureBox1.InitialImage = global::F74091051_W6_practice2.Properties.Resources.pic_01_1_;
            this.pictureBox1.Location = new System.Drawing.Point(78, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // third_rb
            // 
            this.third_rb.AutoSize = true;
            this.third_rb.Location = new System.Drawing.Point(36, 111);
            this.third_rb.Name = "third_rb";
            this.third_rb.Size = new System.Drawing.Size(123, 22);
            this.third_rb.TabIndex = 1;
            this.third_rb.Text = "微軟正黑體";
            this.third_rb.UseVisualStyleBackColor = true;
            this.third_rb.CheckedChanged += new System.EventHandler(this.third_rb_CheckedChanged);
            // 
            // second_rb
            // 
            this.second_rb.AutoSize = true;
            this.second_rb.Location = new System.Drawing.Point(36, 72);
            this.second_rb.Name = "second_rb";
            this.second_rb.Size = new System.Drawing.Size(105, 22);
            this.second_rb.TabIndex = 2;
            this.second_rb.Text = "新細明體";
            this.second_rb.UseVisualStyleBackColor = true;
            this.second_rb.CheckedChanged += new System.EventHandler(this.second_rb_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.third_rb);
            this.groupBox1.Controls.Add(this.first_rb);
            this.groupBox1.Controls.Add(this.second_rb);
            this.groupBox1.Location = new System.Drawing.Point(704, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字體";
            // 
            // first_rb
            // 
            this.first_rb.AutoSize = true;
            this.first_rb.Checked = true;
            this.first_rb.Location = new System.Drawing.Point(36, 28);
            this.first_rb.Name = "first_rb";
            this.first_rb.Size = new System.Drawing.Size(87, 22);
            this.first_rb.TabIndex = 0;
            this.first_rb.TabStop = true;
            this.first_rb.Text = "標楷體";
            this.first_rb.UseVisualStyleBackColor = true;
            this.first_rb.CheckedChanged += new System.EventHandler(this.first_rb_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.downright_rb);
            this.groupBox2.Controls.Add(this.downmid_rb);
            this.groupBox2.Controls.Add(this.upright_rb);
            this.groupBox2.Controls.Add(this.downleft_rb);
            this.groupBox2.Controls.Add(this.upleft_rb);
            this.groupBox2.Controls.Add(this.upmid_rb);
            this.groupBox2.Location = new System.Drawing.Point(698, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "位置";
            // 
            // downright_rb
            // 
            this.downright_rb.AutoSize = true;
            this.downright_rb.Location = new System.Drawing.Point(156, 56);
            this.downright_rb.Name = "downright_rb";
            this.downright_rb.Size = new System.Drawing.Size(69, 22);
            this.downright_rb.TabIndex = 5;
            this.downright_rb.Text = "下右";
            this.downright_rb.UseVisualStyleBackColor = true;
            this.downright_rb.CheckedChanged += new System.EventHandler(this.downright_rb_CheckedChanged);
            // 
            // downmid_rb
            // 
            this.downmid_rb.AutoSize = true;
            this.downmid_rb.Location = new System.Drawing.Point(84, 56);
            this.downmid_rb.Name = "downmid_rb";
            this.downmid_rb.Size = new System.Drawing.Size(69, 22);
            this.downmid_rb.TabIndex = 3;
            this.downmid_rb.Text = "下中";
            this.downmid_rb.UseVisualStyleBackColor = true;
            this.downmid_rb.CheckedChanged += new System.EventHandler(this.downmid_rb_CheckedChanged);
            // 
            // upright_rb
            // 
            this.upright_rb.AutoSize = true;
            this.upright_rb.Location = new System.Drawing.Point(156, 28);
            this.upright_rb.Name = "upright_rb";
            this.upright_rb.Size = new System.Drawing.Size(69, 22);
            this.upright_rb.TabIndex = 3;
            this.upright_rb.Text = "上右";
            this.upright_rb.UseVisualStyleBackColor = true;
            this.upright_rb.CheckedChanged += new System.EventHandler(this.upright_rb_CheckedChanged);
            // 
            // downleft_rb
            // 
            this.downleft_rb.AutoSize = true;
            this.downleft_rb.Location = new System.Drawing.Point(9, 56);
            this.downleft_rb.Name = "downleft_rb";
            this.downleft_rb.Size = new System.Drawing.Size(69, 22);
            this.downleft_rb.TabIndex = 2;
            this.downleft_rb.Text = "下左";
            this.downleft_rb.UseVisualStyleBackColor = true;
            this.downleft_rb.CheckedChanged += new System.EventHandler(this.downleft_rb_CheckedChanged);
            // 
            // upleft_rb
            // 
            this.upleft_rb.AutoSize = true;
            this.upleft_rb.Checked = true;
            this.upleft_rb.Location = new System.Drawing.Point(11, 28);
            this.upleft_rb.Name = "upleft_rb";
            this.upleft_rb.Size = new System.Drawing.Size(69, 22);
            this.upleft_rb.TabIndex = 1;
            this.upleft_rb.TabStop = true;
            this.upleft_rb.Text = "上左";
            this.upleft_rb.UseVisualStyleBackColor = true;
            this.upleft_rb.CheckedChanged += new System.EventHandler(this.upleft_rb_CheckedChanged);
            // 
            // upmid_rb
            // 
            this.upmid_rb.AutoSize = true;
            this.upmid_rb.Location = new System.Drawing.Point(81, 28);
            this.upmid_rb.Name = "upmid_rb";
            this.upmid_rb.Size = new System.Drawing.Size(69, 22);
            this.upmid_rb.TabIndex = 4;
            this.upmid_rb.Text = "上中";
            this.upmid_rb.UseVisualStyleBackColor = true;
            this.upmid_rb.CheckedChanged += new System.EventHandler(this.upmid_rb_CheckedChanged);
            // 
            // bold_rb
            // 
            this.bold_rb.AutoSize = true;
            this.bold_rb.Location = new System.Drawing.Point(706, 287);
            this.bold_rb.Name = "bold_rb";
            this.bold_rb.Size = new System.Drawing.Size(70, 22);
            this.bold_rb.TabIndex = 5;
            this.bold_rb.Text = "粗體";
            this.bold_rb.UseVisualStyleBackColor = true;
            this.bold_rb.CheckedChanged += new System.EventHandler(this.bold_rb_CheckedChanged);
            // 
            // italic_rb
            // 
            this.italic_rb.AutoSize = true;
            this.italic_rb.Location = new System.Drawing.Point(817, 287);
            this.italic_rb.Name = "italic_rb";
            this.italic_rb.Size = new System.Drawing.Size(70, 22);
            this.italic_rb.TabIndex = 6;
            this.italic_rb.Text = "斜體";
            this.italic_rb.UseVisualStyleBackColor = true;
            this.italic_rb.CheckedChanged += new System.EventHandler(this.italic_rb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "字體大小:";
            // 
            // wordsize
            // 
            this.wordsize.Location = new System.Drawing.Point(807, 453);
            this.wordsize.Name = "wordsize";
            this.wordsize.Size = new System.Drawing.Size(100, 29);
            this.wordsize.TabIndex = 8;
            this.wordsize.Text = "12";
            this.wordsize.TextChanged += new System.EventHandler(this.wordsize_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "文字";
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(698, 515);
            this.word.Multiline = true;
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(226, 101);
            this.word.TabIndex = 10;
            this.word.Text = "早安";
            this.word.TextChanged += new System.EventHandler(this.word_TextChanged);
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(94, 567);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(75, 49);
            this.last.TabIndex = 11;
            this.last.Text = "前一張";
            this.last.UseVisualStyleBackColor = true;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(379, 567);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 49);
            this.next.TabIndex = 12;
            this.next.Text = "下一張";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // up
            // 
            this.up.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.up.Location = new System.Drawing.Point(75, 21);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(404, 77);
            this.up.TabIndex = 13;
            this.up.Text = "早安";
            this.up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // down
            // 
            this.down.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.down.Location = new System.Drawing.Point(74, 462);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(404, 69);
            this.down.TabIndex = 14;
            this.down.Text = "早安";
            this.down.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.down.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 628);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.next);
            this.Controls.Add(this.last);
            this.Controls.Add(this.word);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wordsize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.italic_rb);
            this.Controls.Add(this.bold_rb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton third_rb;
        private System.Windows.Forms.RadioButton second_rb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton upleft_rb;
        private System.Windows.Forms.RadioButton first_rb;
        private System.Windows.Forms.RadioButton upright_rb;
        private System.Windows.Forms.RadioButton downleft_rb;
        private System.Windows.Forms.RadioButton upmid_rb;
        private System.Windows.Forms.RadioButton downmid_rb;
        private System.Windows.Forms.RadioButton downright_rb;
        private System.Windows.Forms.CheckBox bold_rb;
        private System.Windows.Forms.CheckBox italic_rb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wordsize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label up;
        private System.Windows.Forms.Label down;
    }
}

