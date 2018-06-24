namespace OrmTest
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
            this.btnDapper = new System.Windows.Forms.Button();
            this.btnEF = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDapper
            // 
            this.btnDapper.Location = new System.Drawing.Point(121, 40);
            this.btnDapper.Name = "btnDapper";
            this.btnDapper.Size = new System.Drawing.Size(75, 23);
            this.btnDapper.TabIndex = 0;
            this.btnDapper.Text = "Dapper";
            this.btnDapper.UseVisualStyleBackColor = true;
            this.btnDapper.Click += new System.EventHandler(this.btnDapper_Click);
            // 
            // btnEF
            // 
            this.btnEF.Location = new System.Drawing.Point(268, 40);
            this.btnEF.Name = "btnEF";
            this.btnEF.Size = new System.Drawing.Size(75, 23);
            this.btnEF.TabIndex = 1;
            this.btnEF.Text = "EF";
            this.btnEF.UseVisualStyleBackColor = true;
            this.btnEF.Click += new System.EventHandler(this.btnEF_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(219, 120);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(33, 12);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 187);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnEF);
            this.Controls.Add(this.btnDapper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDapper;
        private System.Windows.Forms.Button btnEF;
        private System.Windows.Forms.Label lblResult;
    }
}

