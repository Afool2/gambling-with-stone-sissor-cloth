namespace WindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblMyCard = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCpuCard = new System.Windows.Forms.Label();
            this.lblJudgesdf = new System.Windows.Forms.Label();
            this.lblJudge = new System.Windows.Forms.Label();
            this.btnSissor = new System.Windows.Forms.Button();
            this.btnStone = new System.Windows.Forms.Button();
            this.btnCloth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "我";
            // 
            // lblMyCard
            // 
            this.lblMyCard.AutoSize = true;
            this.lblMyCard.Location = new System.Drawing.Point(202, 89);
            this.lblMyCard.Name = "lblMyCard";
            this.lblMyCard.Size = new System.Drawing.Size(0, 12);
            this.lblMyCard.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "电脑";
            // 
            // lblCpuCard
            // 
            this.lblCpuCard.AutoSize = true;
            this.lblCpuCard.Location = new System.Drawing.Point(568, 88);
            this.lblCpuCard.Name = "lblCpuCard";
            this.lblCpuCard.Size = new System.Drawing.Size(0, 12);
            this.lblCpuCard.TabIndex = 3;
            // 
            // lblJudgesdf
            // 
            this.lblJudgesdf.AutoSize = true;
            this.lblJudgesdf.Location = new System.Drawing.Point(279, 241);
            this.lblJudgesdf.Name = "lblJudgesdf";
            this.lblJudgesdf.Size = new System.Drawing.Size(29, 12);
            this.lblJudgesdf.TabIndex = 4;
            this.lblJudgesdf.Text = "裁判";
            // 
            // lblJudge
            // 
            this.lblJudge.AutoSize = true;
            this.lblJudge.Location = new System.Drawing.Point(391, 241);
            this.lblJudge.Name = "lblJudge";
            this.lblJudge.Size = new System.Drawing.Size(0, 12);
            this.lblJudge.TabIndex = 5;
            // 
            // btnSissor
            // 
            this.btnSissor.Location = new System.Drawing.Point(124, 409);
            this.btnSissor.Name = "btnSissor";
            this.btnSissor.Size = new System.Drawing.Size(75, 23);
            this.btnSissor.TabIndex = 6;
            this.btnSissor.Text = "剪刀";
            this.btnSissor.UseVisualStyleBackColor = true;
            this.btnSissor.Click += new System.EventHandler(this.btnSissor_Click);
            // 
            // btnStone
            // 
            this.btnStone.Location = new System.Drawing.Point(295, 409);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(75, 23);
            this.btnStone.TabIndex = 7;
            this.btnStone.Text = "石头";
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnCloth
            // 
            this.btnCloth.Location = new System.Drawing.Point(477, 409);
            this.btnCloth.Name = "btnCloth";
            this.btnCloth.Size = new System.Drawing.Size(75, 23);
            this.btnCloth.TabIndex = 8;
            this.btnCloth.Text = "布";
            this.btnCloth.UseVisualStyleBackColor = true;
            this.btnCloth.Click += new System.EventHandler(this.btnCloth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 521);
            this.Controls.Add(this.btnCloth);
            this.Controls.Add(this.btnStone);
            this.Controls.Add(this.btnSissor);
            this.Controls.Add(this.lblJudge);
            this.Controls.Add(this.lblJudgesdf);
            this.Controls.Add(this.lblCpuCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMyCard);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMyCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCpuCard;
        private System.Windows.Forms.Label lblJudgesdf;
        private System.Windows.Forms.Label lblJudge;
        private System.Windows.Forms.Button btnSissor;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Button btnCloth;
    }
}

