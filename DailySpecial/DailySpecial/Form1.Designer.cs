namespace WindowsFormsApplication1
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
            this.lable1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.btnSpecialButton = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(108, 24);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(185, 13);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Enter a day number to see our special";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(139, 69);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(124, 13);
            this.lable2.TabIndex = 1;
            this.lable2.Text = "For example, Sunday = 1";
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(156, 108);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(73, 20);
            this.dayBox.TabIndex = 2;
            // 
            // btnSpecialButton
            // 
            this.btnSpecialButton.Location = new System.Drawing.Point(156, 149);
            this.btnSpecialButton.Name = "btnSpecialButton";
            this.btnSpecialButton.Size = new System.Drawing.Size(75, 23);
            this.btnSpecialButton.TabIndex = 5;
            this.btnSpecialButton.Text = "Get Special";
            this.btnSpecialButton.UseVisualStyleBackColor = true;
            this.btnSpecialButton.Click += new System.EventHandler(this.btnSpecialButton_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(142, 208);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 23);
            this.lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 262);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSpecialButton);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.lable1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.Button btnSpecialButton;
        private System.Windows.Forms.Label lblResult;
    }
}

