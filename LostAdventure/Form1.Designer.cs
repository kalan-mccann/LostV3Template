﻿
namespace LostAdventure
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// im dissapointed in you
        ///you are the reason for my existance what did I do to deserve this
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.option2Label = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.option2Button = new System.Windows.Forms.PictureBox();
            this.option1Button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1Button)).BeginInit();
            this.SuspendLayout();
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(70, 360);
            this.option2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(225, 23);
            this.option2Label.TabIndex = 10;
            this.option2Label.Text = "Give In";
            this.option2Label.Click += new System.EventHandler(this.option2Label_Click);
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(70, 305);
            this.option1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(225, 23);
            this.option1Label.TabIndex = 9;
            this.option1Label.Text = "Embark";
            this.option1Label.Click += new System.EventHandler(this.option1Label_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(-3, -1);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(339, 304);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.Text = "nevermore";
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageBox.ErrorImage")));
            this.imageBox.Image = global::LostAdventure.Properties.Resources.forestLake;
            this.imageBox.Location = new System.Drawing.Point(21, 104);
            this.imageBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(268, 174);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 11;
            this.imageBox.TabStop = false;
            this.imageBox.Click += new System.EventHandler(this.imageBox_Click);
            // 
            // option2Button
            // 
            this.option2Button.Image = global::LostAdventure.Properties.Resources.arrowRight;
            this.option2Button.Location = new System.Drawing.Point(24, 350);
            this.option2Button.Margin = new System.Windows.Forms.Padding(2);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(39, 32);
            this.option2Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.option2Button.TabIndex = 7;
            this.option2Button.TabStop = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option1Button
            // 
            this.option1Button.Image = global::LostAdventure.Properties.Resources.arrowRight;
            this.option1Button.Location = new System.Drawing.Point(24, 305);
            this.option1Button.Margin = new System.Windows.Forms.Padding(2);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(39, 32);
            this.option1Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.option1Button.TabIndex = 6;
            this.option1Button.TabStop = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(314, 422);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost in a Forest";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox option2Button;
        private System.Windows.Forms.PictureBox option1Button;
    }
}

