namespace F74091051_W7_practice1
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
            this.components = new System.ComponentModel.Container();
            this.easy_button = new System.Windows.Forms.Button();
            this.normal_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.point_label = new System.Windows.Forms.Label();
            this.number_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // easy_button
            // 
            this.easy_button.Location = new System.Drawing.Point(329, 105);
            this.easy_button.Name = "easy_button";
            this.easy_button.Size = new System.Drawing.Size(107, 36);
            this.easy_button.TabIndex = 0;
            this.easy_button.Text = "簡單模式";
            this.easy_button.UseVisualStyleBackColor = true;
            this.easy_button.Click += new System.EventHandler(this.easy_button_Click);
            // 
            // normal_button
            // 
            this.normal_button.Location = new System.Drawing.Point(322, 256);
            this.normal_button.Name = "normal_button";
            this.normal_button.Size = new System.Drawing.Size(114, 37);
            this.normal_button.TabIndex = 1;
            this.normal_button.Text = "普通模式";
            this.normal_button.UseVisualStyleBackColor = true;
            this.normal_button.Click += new System.EventHandler(this.normal_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "你的分數:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "當前數字:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "倒數計時:";
            this.label3.Visible = false;
            // 
            // point_label
            // 
            this.point_label.AutoSize = true;
            this.point_label.Location = new System.Drawing.Point(732, 28);
            this.point_label.Name = "point_label";
            this.point_label.Size = new System.Drawing.Size(16, 18);
            this.point_label.TabIndex = 5;
            this.point_label.Text = "0";
            this.point_label.Visible = false;
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Location = new System.Drawing.Point(735, 88);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(50, 18);
            this.number_label.TabIndex = 6;
            this.number_label.Text = "label5";
            this.number_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.number_label.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.point_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.normal_button);
            this.Controls.Add(this.easy_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easy_button;
        private System.Windows.Forms.Button normal_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label point_label;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}

