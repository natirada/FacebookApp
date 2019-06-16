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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOfFacebook));
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
            this.labelQuestion.Location = new System.Drawing.Point(260, 194);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(51, 20);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "label1";
            // 
            // buttonOption1
            // 
            this.buttonOption1.Location = new System.Drawing.Point(118, 235);
            this.buttonOption1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOption1.Name = "buttonOption1";
            this.buttonOption1.Size = new System.Drawing.Size(138, 48);
            this.buttonOption1.TabIndex = 2;
            this.buttonOption1.Text = "button1";
            this.buttonOption1.UseVisualStyleBackColor = true;
            this.buttonOption1.Click += new System.EventHandler(this.buttonOption1_Click);
            // 
            // buttonOption2
            // 
            this.buttonOption2.Location = new System.Drawing.Point(448, 235);
            this.buttonOption2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOption2.Name = "buttonOption2";
            this.buttonOption2.Size = new System.Drawing.Size(138, 48);
            this.buttonOption2.TabIndex = 3;
            this.buttonOption2.Text = "button2";
            this.buttonOption2.UseVisualStyleBackColor = true;
            this.buttonOption2.Click += new System.EventHandler(this.buttonOption2_Click_1);
            // 
            // buttonOption3
            // 
            this.buttonOption3.Location = new System.Drawing.Point(282, 366);
            this.buttonOption3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOption3.Name = "buttonOption3";
            this.buttonOption3.Size = new System.Drawing.Size(138, 48);
            this.buttonOption3.TabIndex = 4;
            this.buttonOption3.Text = "button3";
            this.buttonOption3.UseVisualStyleBackColor = true;
            this.buttonOption3.Click += new System.EventHandler(this.buttonOption3_Click);
            // 
            // pictureBoxProfileFriend
            // 
            this.pictureBoxProfileFriend.Location = new System.Drawing.Point(282, 55);
            this.pictureBoxProfileFriend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxProfileFriend.Name = "pictureBoxProfileFriend";
            this.pictureBoxProfileFriend.Size = new System.Drawing.Size(186, 120);
            this.pictureBoxProfileFriend.TabIndex = 0;
            this.pictureBoxProfileFriend.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "How well do know your friend ?";
            // 
            // GameOfFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOption3);
            this.Controls.Add(this.buttonOption2);
            this.Controls.Add(this.buttonOption1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.pictureBoxProfileFriend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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