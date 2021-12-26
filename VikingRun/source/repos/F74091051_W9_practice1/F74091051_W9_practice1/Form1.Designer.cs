namespace F74091051_W9_practice1
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
            this.play_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.select_files_btn = new System.Windows.Forms.Button();
            this.loop_ckb = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // play_btn
            // 
            this.play_btn.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.play_btn.Location = new System.Drawing.Point(104, 611);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(242, 57);
            this.play_btn.TabIndex = 0;
            this.play_btn.Text = "Play";
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stop_btn.Location = new System.Drawing.Point(510, 611);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(242, 57);
            this.stop_btn.TabIndex = 1;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // select_files_btn
            // 
            this.select_files_btn.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.select_files_btn.Location = new System.Drawing.Point(903, 611);
            this.select_files_btn.Name = "select_files_btn";
            this.select_files_btn.Size = new System.Drawing.Size(242, 57);
            this.select_files_btn.TabIndex = 2;
            this.select_files_btn.Text = "Select Files";
            this.select_files_btn.UseVisualStyleBackColor = true;
            this.select_files_btn.Click += new System.EventHandler(this.select_files_btn_Click);
            // 
            // loop_ckb
            // 
            this.loop_ckb.AutoSize = true;
            this.loop_ckb.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loop_ckb.Location = new System.Drawing.Point(79, 530);
            this.loop_ckb.Name = "loop_ckb";
            this.loop_ckb.Size = new System.Drawing.Size(123, 44);
            this.loop_ckb.TabIndex = 3;
            this.loop_ckb.Text = "Loop";
            this.loop_ckb.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(139, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 410);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 718);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loop_ckb);
            this.Controls.Add(this.select_files_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.play_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button select_files_btn;
        private System.Windows.Forms.CheckBox loop_ckb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

