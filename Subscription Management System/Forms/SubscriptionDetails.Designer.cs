﻿namespace Subscription_Management_System
{
    partial class SubscriptionDetails
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 83);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 0;
            label1.Text = "Plan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 151);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 1;
            label2.Text = "Number of Users";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 224);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 2;
            label3.Text = "Period";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 305);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 3;
            label4.Text = "Total Cost";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(472, 305);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(472, 224);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Location = new Point(472, 151);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Location = new Point(472, 83);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(677, 392);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SubscriptionDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SubscriptionDetails";
            Text = "SubscriptionDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
    }
}