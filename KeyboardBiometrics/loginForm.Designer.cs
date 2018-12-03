﻿namespace KeyboardBiometrics
{
    partial class LoginForm
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
            this.buttonback = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.pass1Box = new System.Windows.Forms.TextBox();
            this.submitRegisterButton = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(8, 8);
            this.buttonback.Margin = new System.Windows.Forms.Padding(2);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(68, 28);
            this.buttonback.TabIndex = 0;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBox.Location = new System.Drawing.Point(161, 86);
            this.loginBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(201, 26);
            this.loginBox.TabIndex = 3;
            this.loginBox.Text = "Login";
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginBox.Click += new System.EventHandler(this.loginBox_Click);
            // 
            // pass1Box
            // 
            this.pass1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pass1Box.Location = new System.Drawing.Point(161, 136);
            this.pass1Box.Margin = new System.Windows.Forms.Padding(2);
            this.pass1Box.Name = "pass1Box";
            this.pass1Box.Size = new System.Drawing.Size(201, 26);
            this.pass1Box.TabIndex = 4;
            this.pass1Box.Text = "Password";
            this.pass1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass1Box.Click += new System.EventHandler(this.pass1Box_TextChanged);
            this.pass1Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass1Box_KeyDown);
            this.pass1Box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pass1Box_KeyUp);
            this.pass1Box.Leave += new System.EventHandler(this.pass1Box_Leave);
            // 
            // submitRegisterButton
            // 
            this.submitRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitRegisterButton.Location = new System.Drawing.Point(183, 188);
            this.submitRegisterButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitRegisterButton.Name = "submitRegisterButton";
            this.submitRegisterButton.Size = new System.Drawing.Size(157, 42);
            this.submitRegisterButton.TabIndex = 6;
            this.submitRegisterButton.Text = "Login";
            this.submitRegisterButton.UseVisualStyleBackColor = true;
            this.submitRegisterButton.Click += new System.EventHandler(this.submitLoginButton_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Maroon;
            this.labelError.Location = new System.Drawing.Point(237, 257);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(18, 26);
            this.labelError.TabIndex = 7;
            this.labelError.Text = " ";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.submitRegisterButton);
            this.Controls.Add(this.pass1Box);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.buttonback);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox pass1Box;
        private System.Windows.Forms.Button submitRegisterButton;
        private System.Windows.Forms.Label labelError;
    }
}