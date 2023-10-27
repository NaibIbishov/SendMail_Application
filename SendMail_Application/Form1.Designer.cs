namespace SendMail_Application
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
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMovzu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciqlama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGonder.Location = new System.Drawing.Point(117, 291);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(283, 44);
            this.btnGonder.TabIndex = 0;
            this.btnGonder.Text = "Göndər";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtAlici
            // 
            this.txtAlici.Location = new System.Drawing.Point(117, 25);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(301, 25);
            this.txtAlici.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alıcı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mövzu";
            // 
            // txtMovzu
            // 
            this.txtMovzu.Location = new System.Drawing.Point(117, 65);
            this.txtMovzu.Name = "txtMovzu";
            this.txtMovzu.Size = new System.Drawing.Size(301, 25);
            this.txtMovzu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Açıqlama";
            // 
            // txtAciqlama
            // 
            this.txtAciqlama.Location = new System.Drawing.Point(117, 114);
            this.txtAciqlama.Multiline = true;
            this.txtAciqlama.Name = "txtAciqlama";
            this.txtAciqlama.Size = new System.Drawing.Size(301, 154);
            this.txtAciqlama.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAciqlama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMovzu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlici);
            this.Controls.Add(this.btnGonder);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Send Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMovzu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAciqlama;
    }
}

