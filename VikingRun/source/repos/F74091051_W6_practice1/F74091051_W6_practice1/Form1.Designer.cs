namespace F74091051_W6_practice1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.height = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "高";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "寬";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "請輸數字(-9~99)";
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.LightCoral;
            this.enter.ForeColor = System.Drawing.Color.Black;
            this.enter.Location = new System.Drawing.Point(89, 226);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 38);
            this.enter.TabIndex = 3;
            this.enter.Text = "確認";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(105, 64);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 29);
            this.height.TabIndex = 4;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(105, 149);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 29);
            this.width.TabIndex = 5;
            // 
            // number
            // 
            this.number.Enabled = false;
            this.number.Location = new System.Drawing.Point(78, 363);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 29);
            this.number.TabIndex = 6;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 558);
            this.Controls.Add(this.number);
            this.Controls.Add(this.width);
            this.Controls.Add(this.height);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox number;
    }
}

