
namespace mySnapshot
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
            this.btn_findURI = new System.Windows.Forms.Button();
            this.txtbx_results = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.picbx_image = new System.Windows.Forms.PictureBox();
            this.btn_get_image = new System.Windows.Forms.Button();
            this.webbsr_image = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.txtbx_camera_ip_address = new System.Windows.Forms.TextBox();
            this.btn_ping = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_findURI
            // 
            this.btn_findURI.Location = new System.Drawing.Point(12, 632);
            this.btn_findURI.Name = "btn_findURI";
            this.btn_findURI.Size = new System.Drawing.Size(193, 37);
            this.btn_findURI.TabIndex = 0;
            this.btn_findURI.Text = "Find URI";
            this.btn_findURI.UseVisualStyleBackColor = true;
            this.btn_findURI.Click += new System.EventHandler(this.btn_findURI_Click);
            // 
            // txtbx_results
            // 
            this.txtbx_results.Location = new System.Drawing.Point(12, 123);
            this.txtbx_results.Multiline = true;
            this.txtbx_results.Name = "txtbx_results";
            this.txtbx_results.Size = new System.Drawing.Size(432, 503);
            this.txtbx_results.TabIndex = 1;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(369, 632);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(193, 37);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(935, 632);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(193, 37);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // picbx_image
            // 
            this.picbx_image.Location = new System.Drawing.Point(463, 12);
            this.picbx_image.Name = "picbx_image";
            this.picbx_image.Size = new System.Drawing.Size(653, 542);
            this.picbx_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_image.TabIndex = 4;
            this.picbx_image.TabStop = false;
            // 
            // btn_get_image
            // 
            this.btn_get_image.Location = new System.Drawing.Point(616, 632);
            this.btn_get_image.Name = "btn_get_image";
            this.btn_get_image.Size = new System.Drawing.Size(193, 37);
            this.btn_get_image.TabIndex = 5;
            this.btn_get_image.Text = "Get Image";
            this.btn_get_image.UseVisualStyleBackColor = true;
            this.btn_get_image.Click += new System.EventHandler(this.btn_get_image_Click);
            // 
            // webbsr_image
            // 
            this.webbsr_image.Location = new System.Drawing.Point(974, 570);
            this.webbsr_image.MinimumSize = new System.Drawing.Size(20, 20);
            this.webbsr_image.Name = "webbsr_image";
            this.webbsr_image.Size = new System.Drawing.Size(142, 56);
            this.webbsr_image.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Camera IP Address:";
            // 
            // txtbx_username
            // 
            this.txtbx_username.Location = new System.Drawing.Point(189, 27);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(232, 26);
            this.txtbx_username.TabIndex = 10;
            this.txtbx_username.Text = "admin";
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(189, 59);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(232, 26);
            this.txtbx_password.TabIndex = 11;
            // 
            // txtbx_camera_ip_address
            // 
            this.txtbx_camera_ip_address.Location = new System.Drawing.Point(191, 91);
            this.txtbx_camera_ip_address.Name = "txtbx_camera_ip_address";
            this.txtbx_camera_ip_address.Size = new System.Drawing.Size(232, 26);
            this.txtbx_camera_ip_address.TabIndex = 12;
            this.txtbx_camera_ip_address.Text = "192.168.1.113";
            // 
            // btn_ping
            // 
            this.btn_ping.Location = new System.Drawing.Point(211, 632);
            this.btn_ping.Name = "btn_ping";
            this.btn_ping.Size = new System.Drawing.Size(152, 37);
            this.btn_ping.TabIndex = 13;
            this.btn_ping.Text = "Ping";
            this.btn_ping.UseVisualStyleBackColor = true;
            this.btn_ping.Click += new System.EventHandler(this.btn_ping_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 681);
            this.Controls.Add(this.btn_ping);
            this.Controls.Add(this.txtbx_camera_ip_address);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webbsr_image);
            this.Controls.Add(this.btn_get_image);
            this.Controls.Add(this.picbx_image);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txtbx_results);
            this.Controls.Add(this.btn_findURI);
            this.Name = "Form1";
            this.Text = "mySnapshot";
            ((System.ComponentModel.ISupportInitialize)(this.picbx_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_findURI;
        private System.Windows.Forms.TextBox txtbx_results;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox picbx_image;
        private System.Windows.Forms.Button btn_get_image;
        private System.Windows.Forms.WebBrowser webbsr_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.TextBox txtbx_camera_ip_address;
        private System.Windows.Forms.Button btn_ping;
    }
}

