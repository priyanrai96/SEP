﻿namespace FinalProject
{
    partial class AfterLogin
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
            this.PanelTop = new System.Windows.Forms.Panel();
            this.BedsButton = new System.Windows.Forms.Button();
            this.CentralStationButton = new System.Windows.Forms.Button();
            this.MinimizeButtonAfterLogin = new System.Windows.Forms.PictureBox();
            this.CloseButtonAfterLogin = new System.Windows.Forms.PictureBox();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonAfterLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonAfterLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.MinimizeButtonAfterLogin);
            this.PanelTop.Controls.Add(this.CloseButtonAfterLogin);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(750, 44);
            this.PanelTop.TabIndex = 0;
            this.PanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            // 
            // BedsButton
            // 
            this.BedsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BedsButton.Location = new System.Drawing.Point(146, 174);
            this.BedsButton.Name = "BedsButton";
            this.BedsButton.Size = new System.Drawing.Size(200, 100);
            this.BedsButton.TabIndex = 1;
            this.BedsButton.Text = "*Beds*";
            this.BedsButton.UseVisualStyleBackColor = true;
            this.BedsButton.Click += new System.EventHandler(this.BedsButton_Click);
            // 
            // CentralStationButton
            // 
            this.CentralStationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CentralStationButton.Location = new System.Drawing.Point(404, 174);
            this.CentralStationButton.Name = "CentralStationButton";
            this.CentralStationButton.Size = new System.Drawing.Size(200, 100);
            this.CentralStationButton.TabIndex = 2;
            this.CentralStationButton.Text = "*Central Station*";
            this.CentralStationButton.UseVisualStyleBackColor = true;
            this.CentralStationButton.Click += new System.EventHandler(this.CentralStationButton_Click);
            // 
            // MinimizeButtonAfterLogin
            // 
            this.MinimizeButtonAfterLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButtonAfterLogin.Image = global::FinalProject.Properties.Resources.minimize__1_;
            this.MinimizeButtonAfterLogin.Location = new System.Drawing.Point(681, 10);
            this.MinimizeButtonAfterLogin.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeButtonAfterLogin.Name = "MinimizeButtonAfterLogin";
            this.MinimizeButtonAfterLogin.Size = new System.Drawing.Size(23, 25);
            this.MinimizeButtonAfterLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButtonAfterLogin.TabIndex = 2;
            this.MinimizeButtonAfterLogin.TabStop = false;
            this.MinimizeButtonAfterLogin.Click += new System.EventHandler(this.MinimizeButtonAfterLogin_Click);
            // 
            // CloseButtonAfterLogin
            // 
            this.CloseButtonAfterLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButtonAfterLogin.Image = global::FinalProject.Properties.Resources.close;
            this.CloseButtonAfterLogin.Location = new System.Drawing.Point(716, 10);
            this.CloseButtonAfterLogin.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButtonAfterLogin.Name = "CloseButtonAfterLogin";
            this.CloseButtonAfterLogin.Size = new System.Drawing.Size(23, 25);
            this.CloseButtonAfterLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButtonAfterLogin.TabIndex = 1;
            this.CloseButtonAfterLogin.TabStop = false;
            this.CloseButtonAfterLogin.Click += new System.EventHandler(this.CloseButtonAfterLogin_Click);
            // 
            // AfterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(750, 447);
            this.Controls.Add(this.CentralStationButton);
            this.Controls.Add(this.BedsButton);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AfterLogin";
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonAfterLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonAfterLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.PictureBox CloseButtonAfterLogin;
        private System.Windows.Forms.PictureBox MinimizeButtonAfterLogin;
        private System.Windows.Forms.Button BedsButton;
        private System.Windows.Forms.Button CentralStationButton;
    }
}