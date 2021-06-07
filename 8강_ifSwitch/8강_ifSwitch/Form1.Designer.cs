
namespace _8강_ifSwitch
{
    partial class cbox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nNumber2 = new System.Windows.Forms.NumericUpDown();
            this.nNumber1 = new System.Windows.Forms.NumericUpDown();
            this.btnifResult = new System.Windows.Forms.Button();
            this.lblifResult = new System.Windows.Forms.Label();
            this.cboxDay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblswitchResult = new System.Windows.Forms.Label();
            this.btnswitchResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number1)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number2)";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // nNumber2
            // 
            this.nNumber2.Location = new System.Drawing.Point(145, 54);
            this.nNumber2.Name = "nNumber2";
            this.nNumber2.Size = new System.Drawing.Size(66, 25);
            this.nNumber2.TabIndex = 1;
            // 
            // nNumber1
            // 
            this.nNumber1.Location = new System.Drawing.Point(24, 54);
            this.nNumber1.Name = "nNumber1";
            this.nNumber1.Size = new System.Drawing.Size(66, 25);
            this.nNumber1.TabIndex = 2;
            // 
            // btnifResult
            // 
            this.btnifResult.Location = new System.Drawing.Point(247, 52);
            this.btnifResult.Name = "btnifResult";
            this.btnifResult.Size = new System.Drawing.Size(113, 23);
            this.btnifResult.TabIndex = 3;
            this.btnifResult.Text = "number 비교";
            this.btnifResult.UseVisualStyleBackColor = true;
            this.btnifResult.Click += new System.EventHandler(this.btnifResult_Click);
            // 
            // lblifResult
            // 
            this.lblifResult.AutoSize = true;
            this.lblifResult.Location = new System.Drawing.Point(21, 87);
            this.lblifResult.Name = "lblifResult";
            this.lblifResult.Size = new System.Drawing.Size(15, 15);
            this.lblifResult.TabIndex = 4;
            this.lblifResult.Text = "-";
            this.lblifResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboxDay
            // 
            this.cboxDay.FormattingEnabled = true;
            this.cboxDay.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.cboxDay.Location = new System.Drawing.Point(24, 192);
            this.cboxDay.Name = "cboxDay";
            this.cboxDay.Size = new System.Drawing.Size(122, 23);
            this.cboxDay.TabIndex = 5;
            this.cboxDay.Text = "월";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "요일 선택)";
            // 
            // lblswitchResult
            // 
            this.lblswitchResult.AutoSize = true;
            this.lblswitchResult.Location = new System.Drawing.Point(21, 223);
            this.lblswitchResult.Name = "lblswitchResult";
            this.lblswitchResult.Size = new System.Drawing.Size(15, 15);
            this.lblswitchResult.TabIndex = 7;
            this.lblswitchResult.Text = "-";
            // 
            // btnswitchResult
            // 
            this.btnswitchResult.Location = new System.Drawing.Point(247, 191);
            this.btnswitchResult.Name = "btnswitchResult";
            this.btnswitchResult.Size = new System.Drawing.Size(113, 23);
            this.btnswitchResult.TabIndex = 8;
            this.btnswitchResult.Text = "선택요일확인";
            this.btnswitchResult.UseVisualStyleBackColor = true;
            this.btnswitchResult.Click += new System.EventHandler(this.btnswitchResult_Click);
            // 
            // cbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.btnswitchResult);
            this.Controls.Add(this.lblswitchResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxDay);
            this.Controls.Add(this.lblifResult);
            this.Controls.Add(this.btnifResult);
            this.Controls.Add(this.nNumber1);
            this.Controls.Add(this.nNumber2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cbox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nNumber2;
        private System.Windows.Forms.NumericUpDown nNumber1;
        private System.Windows.Forms.Button btnifResult;
        private System.Windows.Forms.Label lblifResult;
        private System.Windows.Forms.ComboBox cboxDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblswitchResult;
        private System.Windows.Forms.Button btnswitchResult;
    }
}

