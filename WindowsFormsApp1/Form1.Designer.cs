namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtStatusCode = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtref = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtserfinsaResp = new System.Windows.Forms.TextBox();
            this.txtresponse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 156);
            this.button1.TabIndex = 0;
            this.button1.Text = "MANUAL PAYMENT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStatusCode
            // 
            this.txtStatusCode.Location = new System.Drawing.Point(12, 34);
            this.txtStatusCode.Name = "txtStatusCode";
            this.txtStatusCode.Size = new System.Drawing.Size(286, 20);
            this.txtStatusCode.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(63, 350);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(286, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "STATUS SERVER CODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "AMOUNT";
            // 
            // txtAuth
            // 
            this.txtAuth.Location = new System.Drawing.Point(63, 402);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.Size = new System.Drawing.Size(286, 20);
            this.txtAuth.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "NUMERO DE AUTH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "NUMERO REF";
            // 
            // txtref
            // 
            this.txtref.Location = new System.Drawing.Point(63, 453);
            this.txtref.Name = "txtref";
            this.txtref.Size = new System.Drawing.Size(286, 20);
            this.txtref.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "SERFINSA RESPONSE";
            // 
            // txtserfinsaResp
            // 
            this.txtserfinsaResp.Location = new System.Drawing.Point(63, 301);
            this.txtserfinsaResp.Name = "txtserfinsaResp";
            this.txtserfinsaResp.Size = new System.Drawing.Size(286, 20);
            this.txtserfinsaResp.TabIndex = 10;
            // 
            // txtresponse
            // 
            this.txtresponse.Location = new System.Drawing.Point(63, 518);
            this.txtresponse.Multiline = true;
            this.txtresponse.Name = "txtresponse";
            this.txtresponse.Size = new System.Drawing.Size(286, 242);
            this.txtresponse.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 772);
            this.Controls.Add(this.txtresponse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtserfinsaResp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtref);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAuth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtStatusCode);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStatusCode;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtref;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtserfinsaResp;
        private System.Windows.Forms.TextBox txtresponse;
    }
}

