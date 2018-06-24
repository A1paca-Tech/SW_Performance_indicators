namespace Performance_indicators
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
            this.bt_run = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_run
            // 
            this.bt_run.Font = new System.Drawing.Font("新細明體", 20F);
            this.bt_run.Location = new System.Drawing.Point(12, 84);
            this.bt_run.Name = "bt_run";
            this.bt_run.Size = new System.Drawing.Size(410, 53);
            this.bt_run.TabIndex = 0;
            this.bt_run.Text = "Run";
            this.bt_run.UseVisualStyleBackColor = true;
            this.bt_run.Click += new System.EventHandler(this.bt_run_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("新細明體", 20F);
            this.tb_name.Location = new System.Drawing.Point(12, 39);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(411, 39);
            this.tb_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "輸入班級成績的檔案名稱(input.txt)";
            // 
            // lb_show
            // 
            this.lb_show.AutoSize = true;
            this.lb_show.Font = new System.Drawing.Font("新細明體", 20F);
            this.lb_show.Location = new System.Drawing.Point(12, 158);
            this.lb_show.Name = "lb_show";
            this.lb_show.Size = new System.Drawing.Size(66, 27);
            this.lb_show.TabIndex = 3;
            this.lb_show.Text = "show";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.lb_show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_run);
            this.Name = "Form1";
            this.Text = "Performance indicators";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_run;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_show;
    }
}

