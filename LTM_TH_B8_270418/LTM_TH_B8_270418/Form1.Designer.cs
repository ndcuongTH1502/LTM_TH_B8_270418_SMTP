namespace LTM_TH_B8_270418
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Sender = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.txt_Sub = new System.Windows.Forms.TextBox();
            this.txt_Body = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Body :";
            // 
            // txt_Sender
            // 
            this.txt_Sender.Location = new System.Drawing.Point(112, 20);
            this.txt_Sender.Name = "txt_Sender";
            this.txt_Sender.Size = new System.Drawing.Size(159, 20);
            this.txt_Sender.TabIndex = 5;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(112, 47);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(159, 20);
            this.txt_Pass.TabIndex = 6;
            // 
            // txt_To
            // 
            this.txt_To.Location = new System.Drawing.Point(112, 77);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(159, 20);
            this.txt_To.TabIndex = 7;
            // 
            // txt_Sub
            // 
            this.txt_Sub.Location = new System.Drawing.Point(112, 103);
            this.txt_Sub.Name = "txt_Sub";
            this.txt_Sub.Size = new System.Drawing.Size(268, 20);
            this.txt_Sub.TabIndex = 8;
            // 
            // txt_Body
            // 
            this.txt_Body.Location = new System.Drawing.Point(112, 135);
            this.txt_Body.Multiline = true;
            this.txt_Body.Name = "txt_Body";
            this.txt_Body.Size = new System.Drawing.Size(268, 117);
            this.txt_Body.TabIndex = 9;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(305, 258);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 10;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 292);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Body);
            this.Controls.Add(this.txt_Sub);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Sender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Send Mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Sender;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.TextBox txt_Sub;
        private System.Windows.Forms.TextBox txt_Body;
        private System.Windows.Forms.Button btn_Send;
    }
}

