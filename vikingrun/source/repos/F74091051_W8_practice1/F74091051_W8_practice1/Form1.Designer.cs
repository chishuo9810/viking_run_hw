namespace F74091051_W8_practice1
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
            this.start_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.person_lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.round_lb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.P2_point_lb = new System.Windows.Forms.Label();
            this.P1_point_lb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.remember_card_tm = new System.Windows.Forms.Timer(this.components);
            this.see_card_tm = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(276, 198);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(188, 60);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "開始遊戲";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "第";
            this.label1.Visible = false;
            // 
            // person_lb
            // 
            this.person_lb.AutoSize = true;
            this.person_lb.Location = new System.Drawing.Point(332, 19);
            this.person_lb.Name = "person_lb";
            this.person_lb.Size = new System.Drawing.Size(16, 18);
            this.person_lb.TabIndex = 2;
            this.person_lb.Text = "1";
            this.person_lb.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "輪到P";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "回合";
            this.label4.Visible = false;
            // 
            // round_lb
            // 
            this.round_lb.AutoSize = true;
            this.round_lb.Location = new System.Drawing.Point(166, 19);
            this.round_lb.Name = "round_lb";
            this.round_lb.Size = new System.Drawing.Size(16, 18);
            this.round_lb.TabIndex = 5;
            this.round_lb.Text = "1";
            this.round_lb.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "分";
            this.label6.Visible = false;
            // 
            // P2_point_lb
            // 
            this.P2_point_lb.AutoSize = true;
            this.P2_point_lb.Location = new System.Drawing.Point(48, 216);
            this.P2_point_lb.Name = "P2_point_lb";
            this.P2_point_lb.Size = new System.Drawing.Size(16, 18);
            this.P2_point_lb.TabIndex = 7;
            this.P2_point_lb.Text = "0";
            this.P2_point_lb.Visible = false;
            // 
            // P1_point_lb
            // 
            this.P1_point_lb.AutoSize = true;
            this.P1_point_lb.Location = new System.Drawing.Point(662, 216);
            this.P1_point_lb.Name = "P1_point_lb";
            this.P1_point_lb.Size = new System.Drawing.Size(16, 18);
            this.P1_point_lb.TabIndex = 8;
            this.P1_point_lb.Text = "0";
            this.P1_point_lb.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "P1:";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "P2:";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "分";
            this.label11.Visible = false;
            // 
            // remember_card_tm
            // 
            this.remember_card_tm.Interval = 1000;
            this.remember_card_tm.Tick += new System.EventHandler(this.remember_card_tm_Tick);
            // 
            // see_card_tm
            // 
            this.see_card_tm.Tick += new System.EventHandler(this.see_card_tm_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(745, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 812);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.P1_point_lb);
            this.Controls.Add(this.P2_point_lb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.round_lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.person_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label person_lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label round_lb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label P2_point_lb;
        private System.Windows.Forms.Label P1_point_lb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer remember_card_tm;
        private System.Windows.Forms.Timer see_card_tm;
        private System.Windows.Forms.Label label2;
    }
}

