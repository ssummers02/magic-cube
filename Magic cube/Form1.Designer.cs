using System;
using System.Drawing;

namespace Magic_cube
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
            this.checkmagickButton = new System.Windows.Forms.Button();
            this.createMagickButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            // 
            // checkmagickButton
            // 
            this.checkmagickButton.Location = new System.Drawing.Point(571, 418);
            this.checkmagickButton.Name = "checkmagickButton";
            this.checkmagickButton.Size = new System.Drawing.Size(109, 27);
            this.checkmagickButton.Text = "Проверить матрицу";
            this.checkmagickButton.Click += new System.EventHandler(this.CheckmagickButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(571+109, 418);
            this.clearButton.Name = "checkmagickButton";
            this.clearButton.Size = new System.Drawing.Size(109, 27);
            this.clearButton.Text = "Очистить";
            this.clearButton.Click += new System.EventHandler(this.CleanButtonClick);
            // 
            // createMagickButton
            // 
            this.createMagickButton.Location = new System.Drawing.Point(571, 447);
            this.createMagickButton.Name = "createMagickButton";
            this.createMagickButton.Size = new System.Drawing.Size(217, 27);
            this.createMagickButton.Text = "Создать магический квадрат";
            this.createMagickButton.Click += new System.EventHandler(this.CreateMagickButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magic_cube.Properties.Resources.color_2174049_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.createMagickButton);
            this.Controls.Add(this.checkmagickButton);
            this.Controls.Add(this.clearButton);

            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Cube";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button createMagickButton;
        private System.Windows.Forms.Button checkmagickButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label magicLabel;
        #endregion
    }
}