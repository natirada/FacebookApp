namespace WindowsFormsApp1
{
    partial class GameOfFacebook
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonOption1 = new System.Windows.Forms.Button();
            this.buttonOption2 = new System.Windows.Forms.Button();
            this.buttonOption3 = new System.Windows.Forms.Button();
            this.pictureBoxProfileFriend = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(185, 134);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(35, 13);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "label1";
            // 
            // buttonOption1
            // 
            this.buttonOption1.Location = new System.Drawing.Point(79, 153);
            this.buttonOption1.Name = "buttonOption1";
            this.buttonOption1.Size = new System.Drawing.Size(92, 31);
            this.buttonOption1.TabIndex = 2;
            this.buttonOption1.Text = "button1";
            this.buttonOption1.UseVisualStyleBackColor = true;
            this.buttonOption1.Click += new System.EventHandler(this.buttonOption1_Click);
            // 
            // buttonOption2
            // 
            this.buttonOption2.Location = new System.Drawing.Point(299, 153);
            this.buttonOption2.Name = "buttonOption2";
            this.buttonOption2.Size = new System.Drawing.Size(92, 31);
            this.buttonOption2.TabIndex = 3;
            this.buttonOption2.Text = "button2";
            this.buttonOption2.UseVisualStyleBackColor = true;
            this.buttonOption2.Click += new System.EventHandler(this.buttonOption2_Click);
            // 
            // buttonOption3
            // 
            this.buttonOption3.Location = new System.Drawing.Point(188, 238);
            this.buttonOption3.Name = "buttonOption3";
            this.buttonOption3.Size = new System.Drawing.Size(92, 31);
            this.buttonOption3.TabIndex = 4;
            this.buttonOption3.Text = "button3";
            this.buttonOption3.UseVisualStyleBackColor = true;
            this.buttonOption3.Click += new System.EventHandler(this.buttonOption3_Click);
            // 
            // pictureBoxProfileFriend
            // 
            this.pictureBoxProfileFriend.Location = new System.Drawing.Point(188, 36);
            this.pictureBoxProfileFriend.Name = "pictureBoxProfileFriend";
            this.pictureBoxProfileFriend.Size = new System.Drawing.Size(124, 78);
            this.pictureBoxProfileFriend.TabIndex = 0;
            this.pictureBoxProfileFriend.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "How well do know your friend ?";
            // 
            // GameOfFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOption3);
            this.Controls.Add(this.buttonOption2);
            this.Controls.Add(this.buttonOption1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.pictureBoxProfileFriend);
            this.Name = "GameOfFacebook";
            this.Text = "GameOfFacebook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfileFriend;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonOption1;
        private System.Windows.Forms.Button buttonOption2;
        private System.Windows.Forms.Button buttonOption3;
        private System.Windows.Forms.Label label1;
    }
}