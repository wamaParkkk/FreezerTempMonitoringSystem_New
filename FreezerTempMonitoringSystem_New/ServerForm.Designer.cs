
namespace FreezerTempMonitoringSystem_New
{
    partial class ServerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.richTextBoxRecvMsg = new System.Windows.Forms.RichTextBox();
            this.richTextBoxServerStatus = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.laTime = new System.Windows.Forms.Label();
            this.laDate = new System.Windows.Forms.Label();
            this.labelPjtName = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxRecvMsg
            // 
            this.richTextBoxRecvMsg.BackColor = System.Drawing.Color.White;
            this.richTextBoxRecvMsg.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxRecvMsg.Location = new System.Drawing.Point(468, 123);
            this.richTextBoxRecvMsg.Name = "richTextBoxRecvMsg";
            this.richTextBoxRecvMsg.ReadOnly = true;
            this.richTextBoxRecvMsg.Size = new System.Drawing.Size(790, 850);
            this.richTextBoxRecvMsg.TabIndex = 6;
            this.richTextBoxRecvMsg.Text = "";
            // 
            // richTextBoxServerStatus
            // 
            this.richTextBoxServerStatus.BackColor = System.Drawing.Color.White;
            this.richTextBoxServerStatus.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxServerStatus.Location = new System.Drawing.Point(12, 123);
            this.richTextBoxServerStatus.Name = "richTextBoxServerStatus";
            this.richTextBoxServerStatus.ReadOnly = true;
            this.richTextBoxServerStatus.Size = new System.Drawing.Size(450, 850);
            this.richTextBoxServerStatus.TabIndex = 7;
            this.richTextBoxServerStatus.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(465, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Message received from the client";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "log.png");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.laTime);
            this.panel3.Controls.Add(this.laDate);
            this.panel3.Controls.Add(this.labelPjtName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1264, 100);
            this.panel3.TabIndex = 13;
            // 
            // laTime
            // 
            this.laTime.AutoSize = true;
            this.laTime.BackColor = System.Drawing.Color.Transparent;
            this.laTime.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTime.ForeColor = System.Drawing.SystemColors.Window;
            this.laTime.Location = new System.Drawing.Point(1142, 59);
            this.laTime.Name = "laTime";
            this.laTime.Size = new System.Drawing.Size(88, 25);
            this.laTime.TabIndex = 30;
            this.laTime.Text = "00:00:00";
            // 
            // laDate
            // 
            this.laDate.AutoSize = true;
            this.laDate.BackColor = System.Drawing.Color.Transparent;
            this.laDate.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDate.ForeColor = System.Drawing.SystemColors.Window;
            this.laDate.Location = new System.Drawing.Point(1142, 28);
            this.laDate.Name = "laDate";
            this.laDate.Size = new System.Drawing.Size(110, 25);
            this.laDate.TabIndex = 29;
            this.laDate.Text = "0000.00.00";
            // 
            // labelPjtName
            // 
            this.labelPjtName.BackColor = System.Drawing.Color.Transparent;
            this.labelPjtName.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPjtName.ForeColor = System.Drawing.Color.White;
            this.labelPjtName.Location = new System.Drawing.Point(200, 28);
            this.labelPjtName.Name = "labelPjtName";
            this.labelPjtName.Size = new System.Drawing.Size(833, 42);
            this.labelPjtName.TabIndex = 15;
            this.labelPjtName.Text = "Temp monitoring bridge (Module → SQL)";
            this.labelPjtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxServerStatus);
            this.Controls.Add(this.richTextBoxRecvMsg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerForm";
            this.Text = "Temp Monitoring System";
            this.Activated += new System.EventHandler(this.ServerForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxRecvMsg;
        private System.Windows.Forms.RichTextBox richTextBoxServerStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelPjtName;
        public System.Windows.Forms.Label laTime;
        public System.Windows.Forms.Label laDate;
    }
}

