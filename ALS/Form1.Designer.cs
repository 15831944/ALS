﻿namespace ALS
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
            this.grouper1 = new CodeVendor.Controls.Grouper();
            this.gboxRecycle = new CodeVendor.Controls.Grouper();
            this.SuspendLayout();
            // 
            // grouper1
            // 
            this.grouper1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grouper1.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper1.BorderColor = System.Drawing.Color.Silver;
            this.grouper1.BorderThickness = 1F;
            this.grouper1.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grouper1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(8)))), ((int)(((byte)(100)))));
            this.grouper1.GroupImage = null;
            this.grouper1.GroupTitle = "安装管路";
            this.grouper1.Location = new System.Drawing.Point(12, 12);
            this.grouper1.Name = "grouper1";
            this.grouper1.Padding = new System.Windows.Forms.Padding(5, 12, 3, 3);
            this.grouper1.PaintGroupBox = true;
            this.grouper1.RoundCorners = 10;
            this.grouper1.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper1.ShadowControl = false;
            this.grouper1.ShadowThickness = 3;
            this.grouper1.Size = new System.Drawing.Size(365, 238);
            this.grouper1.TabIndex = 119;
            // 
            // gboxRecycle
            // 
            this.gboxRecycle.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gboxRecycle.BackgroundGradientColor = System.Drawing.Color.White;
            this.gboxRecycle.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.gboxRecycle.BorderColor = System.Drawing.Color.Silver;
            this.gboxRecycle.BorderThickness = 1F;
            this.gboxRecycle.CustomGroupBoxColor = System.Drawing.Color.White;
            this.gboxRecycle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxRecycle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(100)))));
            this.gboxRecycle.GroupImage = null;
            this.gboxRecycle.GroupTitle = "PE回收方法,请参照以下步骤回收";
            this.gboxRecycle.Location = new System.Drawing.Point(460, 30);
            this.gboxRecycle.Name = "gboxRecycle";
            this.gboxRecycle.Padding = new System.Windows.Forms.Padding(2, 25, 3, 3);
            this.gboxRecycle.PaintGroupBox = true;
            this.gboxRecycle.RoundCorners = 10;
            this.gboxRecycle.ShadowColor = System.Drawing.Color.DarkGray;
            this.gboxRecycle.ShadowControl = false;
            this.gboxRecycle.ShadowThickness = 3;
            this.gboxRecycle.Size = new System.Drawing.Size(196, 162);
            this.gboxRecycle.TabIndex = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 262);
            this.Controls.Add(this.gboxRecycle);
            this.Controls.Add(this.grouper1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CodeVendor.Controls.Grouper grouper1;
        public CodeVendor.Controls.Grouper gboxRecycle;
    }
}