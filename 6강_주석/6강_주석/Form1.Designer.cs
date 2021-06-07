
namespace _6강_주석
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResult1 = new System.Windows.Forms.Button();
            this.btnResult2 = new System.Windows.Forms.Button();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.lboxDay = new System.Windows.Forms.ListBox();
            this.lboxTime = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnResult1
            // 
            this.btnResult1.Location = new System.Drawing.Point(28, 234);
            this.btnResult1.Name = "btnResult1";
            this.btnResult1.Size = new System.Drawing.Size(75, 23);
            this.btnResult1.TabIndex = 0;
            this.btnResult1.Text = "결과 보기";
            this.btnResult1.UseVisualStyleBackColor = true;
            this.btnResult1.Click += new System.EventHandler(this.btnResult1_Click_1);
            // 
            // btnResult2
            // 
            this.btnResult2.Location = new System.Drawing.Point(196, 220);
            this.btnResult2.Name = "btnResult2";
            this.btnResult2.Size = new System.Drawing.Size(75, 23);
            this.btnResult2.TabIndex = 0;
            this.btnResult2.Text = "button1";
            this.btnResult2.UseVisualStyleBackColor = true;
            this.btnResult2.Click += new System.EventHandler(this.btnResult2_Click);
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(28, 12);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(100, 25);
            this.tboxName.TabIndex = 1;
            // 
            // tboxResult
            // 
            this.tboxResult.Enabled = false;
            this.tboxResult.ForeColor = System.Drawing.Color.Transparent;
            this.tboxResult.Location = new System.Drawing.Point(28, 291);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(497, 25);
            this.tboxResult.TabIndex = 2;
            // 
            // lboxDay
            // 
            this.lboxDay.FormattingEnabled = true;
            this.lboxDay.ItemHeight = 15;
            this.lboxDay.Location = new System.Drawing.Point(28, 62);
            this.lboxDay.Name = "lboxDay";
            this.lboxDay.Size = new System.Drawing.Size(120, 139);
            this.lboxDay.TabIndex = 3;
            // 
            // lboxTime
            // 
            this.lboxTime.FormattingEnabled = true;
            this.lboxTime.ItemHeight = 15;
            this.lboxTime.Location = new System.Drawing.Point(196, 62);
            this.lboxTime.Name = "lboxTime";
            this.lboxTime.Size = new System.Drawing.Size(120, 139);
            this.lboxTime.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lboxTime);
            this.Controls.Add(this.lboxDay);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.btnResult2);
            this.Controls.Add(this.btnResult1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResult1;
        private System.Windows.Forms.Button btnResult2;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.ListBox lboxDay;
        private System.Windows.Forms.ListBox lboxTime;
    }
}

