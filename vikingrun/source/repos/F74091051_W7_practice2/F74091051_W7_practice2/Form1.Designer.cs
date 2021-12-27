namespace F74091051_W7_practice2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wood_rdb = new System.Windows.Forms.RadioButton();
            this.fire_rdb = new System.Windows.Forms.RadioButton();
            this.water_rdb = new System.Windows.Forms.RadioButton();
            this.enter_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.attribute_lb = new System.Windows.Forms.Label();
            this.point_lb = new System.Windows.Forms.Label();
            this.time_lb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇初始屬性";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wood_rdb);
            this.groupBox1.Controls.Add(this.fire_rdb);
            this.groupBox1.Controls.Add(this.water_rdb);
            this.groupBox1.Location = new System.Drawing.Point(292, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // wood_rdb
            // 
            this.wood_rdb.AutoSize = true;
            this.wood_rdb.Location = new System.Drawing.Point(40, 165);
            this.wood_rdb.Name = "wood_rdb";
            this.wood_rdb.Size = new System.Drawing.Size(51, 22);
            this.wood_rdb.TabIndex = 2;
            this.wood_rdb.TabStop = true;
            this.wood_rdb.Text = "木";
            this.wood_rdb.UseVisualStyleBackColor = true;
            // 
            // fire_rdb
            // 
            this.fire_rdb.AutoSize = true;
            this.fire_rdb.Location = new System.Drawing.Point(40, 101);
            this.fire_rdb.Name = "fire_rdb";
            this.fire_rdb.Size = new System.Drawing.Size(51, 22);
            this.fire_rdb.TabIndex = 1;
            this.fire_rdb.TabStop = true;
            this.fire_rdb.Text = "火";
            this.fire_rdb.UseVisualStyleBackColor = true;
            // 
            // water_rdb
            // 
            this.water_rdb.AutoSize = true;
            this.water_rdb.Location = new System.Drawing.Point(40, 28);
            this.water_rdb.Name = "water_rdb";
            this.water_rdb.Size = new System.Drawing.Size(51, 22);
            this.water_rdb.TabIndex = 0;
            this.water_rdb.TabStop = true;
            this.water_rdb.Text = "水";
            this.water_rdb.UseVisualStyleBackColor = true;
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(332, 396);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(75, 31);
            this.enter_btn.TabIndex = 2;
            this.enter_btn.Text = "確認";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "目前屬性:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "目前分數:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "剩餘時間:";
            this.label4.Visible = false;
            // 
            // attribute_lb
            // 
            this.attribute_lb.AutoSize = true;
            this.attribute_lb.Location = new System.Drawing.Point(727, 41);
            this.attribute_lb.Name = "attribute_lb";
            this.attribute_lb.Size = new System.Drawing.Size(0, 18);
            this.attribute_lb.TabIndex = 6;
            this.attribute_lb.Visible = false;
            // 
            // point_lb
            // 
            this.point_lb.AutoSize = true;
            this.point_lb.Location = new System.Drawing.Point(727, 85);
            this.point_lb.Name = "point_lb";
            this.point_lb.Size = new System.Drawing.Size(16, 18);
            this.point_lb.TabIndex = 7;
            this.point_lb.Text = "0";
            this.point_lb.Visible = false;
            // 
            // time_lb
            // 
            this.time_lb.AutoSize = true;
            this.time_lb.Location = new System.Drawing.Point(727, 131);
            this.time_lb.Name = "time_lb";
            this.time_lb.Size = new System.Drawing.Size(50, 18);
            this.time_lb.TabIndex = 8;
            this.time_lb.Text = "label7";
            this.time_lb.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.time_lb);
            this.Controls.Add(this.point_lb);
            this.Controls.Add(this.attribute_lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton wood_rdb;
        private System.Windows.Forms.RadioButton fire_rdb;
        private System.Windows.Forms.RadioButton water_rdb;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label attribute_lb;
        private System.Windows.Forms.Label point_lb;
        private System.Windows.Forms.Label time_lb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

