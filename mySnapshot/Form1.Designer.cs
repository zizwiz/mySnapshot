
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_findURI = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.picbx_image = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_camera_ip_address = new System.Windows.Forms.Label();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.txtbx_camera_ip_address = new System.Windows.Forms.TextBox();
            this.btn_ping = new System.Windows.Forms.Button();
            this.btn_stop_capture = new System.Windows.Forms.Button();
            this.btn_start_capture = new System.Windows.Forms.Button();
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.tabcntrl_main = new System.Windows.Forms.TabControl();
            this.tab_snapshot = new System.Windows.Forms.TabPage();
            this.tpl_snapshot = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_snapshot_rchtxtbx = new System.Windows.Forms.Panel();
            this.rchtxtbx_snapshot_results = new System.Windows.Forms.RichTextBox();
            this.pnl_snapshot_picbx = new System.Windows.Forms.Panel();
            this.tab_web_browser = new System.Windows.Forms.TabPage();
            this.pnl_web_browser = new System.Windows.Forms.Panel();
            this.webview_browser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tlp_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_sync_time = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.tpl_settings = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_username_lbl = new System.Windows.Forms.Panel();
            this.lbl_null = new System.Windows.Forms.Label();
            this.pnl_username_txtbx = new System.Windows.Forms.Panel();
            this.txtbx_null = new System.Windows.Forms.TextBox();
            this.pnl_password_lbl = new System.Windows.Forms.Panel();
            this.pnl_camera_ip_address_lbl = new System.Windows.Forms.Panel();
            this.pnl_password_txtbx = new System.Windows.Forms.Panel();
            this.pnl_camera_ip_address_txtbx = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlp_file_info = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_filename = new System.Windows.Forms.Panel();
            this.pnl_filesize = new System.Windows.Forms.Panel();
            this.pnl_retries = new System.Windows.Forms.Panel();
            this.lbl_file_name = new System.Windows.Forms.Label();
            this.lbl_file_size = new System.Windows.Forms.Label();
            this.lbl_retries = new System.Windows.Forms.Label();
            this.pnl_save_folder = new System.Windows.Forms.Panel();
            this.lbl_save_folder = new System.Windows.Forms.Label();
            this.pnl_unique_num = new System.Windows.Forms.Panel();
            this.lbl_unique_number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_image)).BeginInit();
            this.tlp_main.SuspendLayout();
            this.tabcntrl_main.SuspendLayout();
            this.tab_snapshot.SuspendLayout();
            this.tpl_snapshot.SuspendLayout();
            this.pnl_snapshot_rchtxtbx.SuspendLayout();
            this.pnl_snapshot_picbx.SuspendLayout();
            this.tab_web_browser.SuspendLayout();
            this.pnl_web_browser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webview_browser)).BeginInit();
            this.tlp_buttons.SuspendLayout();
            this.tpl_settings.SuspendLayout();
            this.pnl_username_lbl.SuspendLayout();
            this.pnl_username_txtbx.SuspendLayout();
            this.pnl_password_lbl.SuspendLayout();
            this.pnl_camera_ip_address_lbl.SuspendLayout();
            this.pnl_password_txtbx.SuspendLayout();
            this.pnl_camera_ip_address_txtbx.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlp_file_info.SuspendLayout();
            this.pnl_filename.SuspendLayout();
            this.pnl_filesize.SuspendLayout();
            this.pnl_retries.SuspendLayout();
            this.pnl_save_folder.SuspendLayout();
            this.pnl_unique_num.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_findURI
            // 
            this.btn_findURI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_findURI.Location = new System.Drawing.Point(3, 3);
            this.btn_findURI.Name = "btn_findURI";
            this.btn_findURI.Size = new System.Drawing.Size(131, 68);
            this.btn_findURI.TabIndex = 0;
            this.btn_findURI.Text = "Find IP Address";
            this.btn_findURI.UseVisualStyleBackColor = true;
            this.btn_findURI.Click += new System.EventHandler(this.btn_findURI_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear.Location = new System.Drawing.Point(287, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(131, 68);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(997, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(134, 68);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // picbx_image
            // 
            this.picbx_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbx_image.Location = new System.Drawing.Point(0, 0);
            this.picbx_image.Name = "picbx_image";
            this.picbx_image.Size = new System.Drawing.Size(775, 425);
            this.picbx_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_image.TabIndex = 4;
            this.picbx_image.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(133, 5);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(83, 20);
            this.lbl_username.TabIndex = 7;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(135, 5);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(78, 20);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Password";
            // 
            // lbl_camera_ip_address
            // 
            this.lbl_camera_ip_address.AutoSize = true;
            this.lbl_camera_ip_address.Location = new System.Drawing.Point(102, 5);
            this.lbl_camera_ip_address.Name = "lbl_camera_ip_address";
            this.lbl_camera_ip_address.Size = new System.Drawing.Size(147, 20);
            this.lbl_camera_ip_address.TabIndex = 9;
            this.lbl_camera_ip_address.Text = "Camera IP Address";
            // 
            // txtbx_username
            // 
            this.txtbx_username.Location = new System.Drawing.Point(60, 2);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(232, 26);
            this.txtbx_username.TabIndex = 10;
            this.txtbx_username.Text = "admin";
            this.txtbx_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(60, 2);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(232, 26);
            this.txtbx_password.TabIndex = 11;
            this.txtbx_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_camera_ip_address
            // 
            this.txtbx_camera_ip_address.Location = new System.Drawing.Point(61, 2);
            this.txtbx_camera_ip_address.Name = "txtbx_camera_ip_address";
            this.txtbx_camera_ip_address.Size = new System.Drawing.Size(232, 26);
            this.txtbx_camera_ip_address.TabIndex = 12;
            this.txtbx_camera_ip_address.Text = "192.168.1.113";
            this.txtbx_camera_ip_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ping
            // 
            this.btn_ping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ping.Location = new System.Drawing.Point(145, 3);
            this.btn_ping.Name = "btn_ping";
            this.btn_ping.Size = new System.Drawing.Size(131, 68);
            this.btn_ping.TabIndex = 13;
            this.btn_ping.Text = "Ping";
            this.btn_ping.UseVisualStyleBackColor = true;
            this.btn_ping.Click += new System.EventHandler(this.btn_ping_Click);
            // 
            // btn_stop_capture
            // 
            this.btn_stop_capture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_stop_capture.Location = new System.Drawing.Point(571, 3);
            this.btn_stop_capture.Name = "btn_stop_capture";
            this.btn_stop_capture.Size = new System.Drawing.Size(131, 68);
            this.btn_stop_capture.TabIndex = 14;
            this.btn_stop_capture.Text = "Stop Capture";
            this.btn_stop_capture.UseVisualStyleBackColor = true;
            this.btn_stop_capture.Click += new System.EventHandler(this.btn_stop_capture_Click);
            // 
            // btn_start_capture
            // 
            this.btn_start_capture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_start_capture.Location = new System.Drawing.Point(713, 3);
            this.btn_start_capture.Name = "btn_start_capture";
            this.btn_start_capture.Size = new System.Drawing.Size(131, 68);
            this.btn_start_capture.TabIndex = 15;
            this.btn_start_capture.Text = "Start Capture";
            this.btn_start_capture.UseVisualStyleBackColor = true;
            this.btn_start_capture.Click += new System.EventHandler(this.btn_start_capture_Click);
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 1;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Controls.Add(this.tabcntrl_main, 0, 1);
            this.tlp_main.Controls.Add(this.tlp_buttons, 0, 2);
            this.tlp_main.Controls.Add(this.tpl_settings, 0, 0);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 3;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp_main.Size = new System.Drawing.Size(1140, 681);
            this.tlp_main.TabIndex = 16;
            // 
            // tabcntrl_main
            // 
            this.tabcntrl_main.Controls.Add(this.tab_snapshot);
            this.tabcntrl_main.Controls.Add(this.tab_web_browser);
            this.tabcntrl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcntrl_main.Location = new System.Drawing.Point(3, 83);
            this.tabcntrl_main.Name = "tabcntrl_main";
            this.tabcntrl_main.SelectedIndex = 0;
            this.tabcntrl_main.Size = new System.Drawing.Size(1134, 515);
            this.tabcntrl_main.TabIndex = 0;
            this.tabcntrl_main.SelectedIndexChanged += new System.EventHandler(this.tabcntrl_main_SelectedIndexChanged);
            // 
            // tab_snapshot
            // 
            this.tab_snapshot.Controls.Add(this.tpl_snapshot);
            this.tab_snapshot.Location = new System.Drawing.Point(4, 29);
            this.tab_snapshot.Name = "tab_snapshot";
            this.tab_snapshot.Padding = new System.Windows.Forms.Padding(3);
            this.tab_snapshot.Size = new System.Drawing.Size(1126, 482);
            this.tab_snapshot.TabIndex = 0;
            this.tab_snapshot.Text = "SnapShot";
            this.tab_snapshot.UseVisualStyleBackColor = true;
            // 
            // tpl_snapshot
            // 
            this.tpl_snapshot.ColumnCount = 3;
            this.tpl_snapshot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tpl_snapshot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tpl_snapshot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tpl_snapshot.Controls.Add(this.pnl_snapshot_rchtxtbx, 0, 0);
            this.tpl_snapshot.Controls.Add(this.pnl_snapshot_picbx, 2, 0);
            this.tpl_snapshot.Controls.Add(this.panel1, 0, 2);
            this.tpl_snapshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl_snapshot.Location = new System.Drawing.Point(3, 3);
            this.tpl_snapshot.Name = "tpl_snapshot";
            this.tpl_snapshot.RowCount = 3;
            this.tpl_snapshot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl_snapshot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tpl_snapshot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpl_snapshot.Size = new System.Drawing.Size(1120, 476);
            this.tpl_snapshot.TabIndex = 0;
            // 
            // pnl_snapshot_rchtxtbx
            // 
            this.pnl_snapshot_rchtxtbx.Controls.Add(this.rchtxtbx_snapshot_results);
            this.pnl_snapshot_rchtxtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_snapshot_rchtxtbx.Location = new System.Drawing.Point(3, 3);
            this.pnl_snapshot_rchtxtbx.Name = "pnl_snapshot_rchtxtbx";
            this.pnl_snapshot_rchtxtbx.Size = new System.Drawing.Size(328, 425);
            this.pnl_snapshot_rchtxtbx.TabIndex = 0;
            // 
            // rchtxtbx_snapshot_results
            // 
            this.rchtxtbx_snapshot_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtbx_snapshot_results.Location = new System.Drawing.Point(0, 0);
            this.rchtxtbx_snapshot_results.Name = "rchtxtbx_snapshot_results";
            this.rchtxtbx_snapshot_results.Size = new System.Drawing.Size(328, 425);
            this.rchtxtbx_snapshot_results.TabIndex = 0;
            this.rchtxtbx_snapshot_results.Text = "";
            // 
            // pnl_snapshot_picbx
            // 
            this.pnl_snapshot_picbx.Controls.Add(this.picbx_image);
            this.pnl_snapshot_picbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_snapshot_picbx.Location = new System.Drawing.Point(342, 3);
            this.pnl_snapshot_picbx.Name = "pnl_snapshot_picbx";
            this.pnl_snapshot_picbx.Size = new System.Drawing.Size(775, 425);
            this.pnl_snapshot_picbx.TabIndex = 1;
            // 
            // tab_web_browser
            // 
            this.tab_web_browser.Controls.Add(this.pnl_web_browser);
            this.tab_web_browser.Location = new System.Drawing.Point(4, 29);
            this.tab_web_browser.Name = "tab_web_browser";
            this.tab_web_browser.Padding = new System.Windows.Forms.Padding(3);
            this.tab_web_browser.Size = new System.Drawing.Size(1126, 482);
            this.tab_web_browser.TabIndex = 1;
            this.tab_web_browser.Text = "WebBrowser";
            this.tab_web_browser.UseVisualStyleBackColor = true;
            // 
            // pnl_web_browser
            // 
            this.pnl_web_browser.Controls.Add(this.webview_browser);
            this.pnl_web_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_web_browser.Location = new System.Drawing.Point(3, 3);
            this.pnl_web_browser.Name = "pnl_web_browser";
            this.pnl_web_browser.Size = new System.Drawing.Size(1120, 476);
            this.pnl_web_browser.TabIndex = 0;
            // 
            // webview_browser
            // 
            this.webview_browser.AllowExternalDrop = true;
            this.webview_browser.CreationProperties = null;
            this.webview_browser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webview_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webview_browser.Location = new System.Drawing.Point(0, 0);
            this.webview_browser.Name = "webview_browser";
            this.webview_browser.Size = new System.Drawing.Size(1120, 476);
            this.webview_browser.TabIndex = 0;
            this.webview_browser.ZoomFactor = 1D;
            // 
            // tlp_buttons
            // 
            this.tlp_buttons.ColumnCount = 15;
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_buttons.Controls.Add(this.btn_sync_time, 12, 0);
            this.tlp_buttons.Controls.Add(this.btn_findURI, 0, 0);
            this.tlp_buttons.Controls.Add(this.btn_start_capture, 10, 0);
            this.tlp_buttons.Controls.Add(this.btn_ping, 2, 0);
            this.tlp_buttons.Controls.Add(this.btn_stop_capture, 8, 0);
            this.tlp_buttons.Controls.Add(this.btn_clear, 4, 0);
            this.tlp_buttons.Controls.Add(this.btn_close, 14, 0);
            this.tlp_buttons.Controls.Add(this.btn_browse, 6, 0);
            this.tlp_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_buttons.Location = new System.Drawing.Point(3, 604);
            this.tlp_buttons.Name = "tlp_buttons";
            this.tlp_buttons.RowCount = 1;
            this.tlp_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_buttons.Size = new System.Drawing.Size(1134, 74);
            this.tlp_buttons.TabIndex = 1;
            // 
            // btn_sync_time
            // 
            this.btn_sync_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sync_time.Location = new System.Drawing.Point(855, 3);
            this.btn_sync_time.Name = "btn_sync_time";
            this.btn_sync_time.Size = new System.Drawing.Size(131, 68);
            this.btn_sync_time.TabIndex = 5;
            this.btn_sync_time.Text = "Sync Time";
            this.btn_sync_time.UseVisualStyleBackColor = true;
            this.btn_sync_time.Click += new System.EventHandler(this.btn_sync_time_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_browse.Location = new System.Drawing.Point(429, 3);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(131, 68);
            this.btn_browse.TabIndex = 16;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // tpl_settings
            // 
            this.tpl_settings.ColumnCount = 5;
            this.tpl_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tpl_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tpl_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tpl_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tpl_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tpl_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpl_settings.Controls.Add(this.pnl_username_lbl, 0, 0);
            this.tpl_settings.Controls.Add(this.pnl_username_txtbx, 0, 1);
            this.tpl_settings.Controls.Add(this.pnl_password_lbl, 2, 0);
            this.tpl_settings.Controls.Add(this.pnl_camera_ip_address_lbl, 4, 0);
            this.tpl_settings.Controls.Add(this.pnl_password_txtbx, 2, 1);
            this.tpl_settings.Controls.Add(this.pnl_camera_ip_address_txtbx, 4, 1);
            this.tpl_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl_settings.Location = new System.Drawing.Point(3, 3);
            this.tpl_settings.Name = "tpl_settings";
            this.tpl_settings.RowCount = 2;
            this.tpl_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpl_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpl_settings.Size = new System.Drawing.Size(1134, 74);
            this.tpl_settings.TabIndex = 2;
            // 
            // pnl_username_lbl
            // 
            this.pnl_username_lbl.Controls.Add(this.lbl_null);
            this.pnl_username_lbl.Controls.Add(this.lbl_username);
            this.pnl_username_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_username_lbl.Location = new System.Drawing.Point(3, 3);
            this.pnl_username_lbl.Name = "pnl_username_lbl";
            this.pnl_username_lbl.Size = new System.Drawing.Size(368, 31);
            this.pnl_username_lbl.TabIndex = 0;
            // 
            // lbl_null
            // 
            this.lbl_null.AutoSize = true;
            this.lbl_null.Location = new System.Drawing.Point(298, 5);
            this.lbl_null.Name = "lbl_null";
            this.lbl_null.Size = new System.Drawing.Size(51, 20);
            this.lbl_null.TabIndex = 8;
            this.lbl_null.Text = "label1";
            this.lbl_null.Visible = false;
            // 
            // pnl_username_txtbx
            // 
            this.pnl_username_txtbx.Controls.Add(this.txtbx_null);
            this.pnl_username_txtbx.Controls.Add(this.txtbx_username);
            this.pnl_username_txtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_username_txtbx.Location = new System.Drawing.Point(3, 40);
            this.pnl_username_txtbx.Name = "pnl_username_txtbx";
            this.pnl_username_txtbx.Size = new System.Drawing.Size(368, 31);
            this.pnl_username_txtbx.TabIndex = 1;
            // 
            // txtbx_null
            // 
            this.txtbx_null.Location = new System.Drawing.Point(339, 3);
            this.txtbx_null.Name = "txtbx_null";
            this.txtbx_null.Size = new System.Drawing.Size(19, 26);
            this.txtbx_null.TabIndex = 11;
            this.txtbx_null.Visible = false;
            // 
            // pnl_password_lbl
            // 
            this.pnl_password_lbl.Controls.Add(this.lbl_password);
            this.pnl_password_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_password_lbl.Location = new System.Drawing.Point(382, 3);
            this.pnl_password_lbl.Name = "pnl_password_lbl";
            this.pnl_password_lbl.Size = new System.Drawing.Size(368, 31);
            this.pnl_password_lbl.TabIndex = 2;
            // 
            // pnl_camera_ip_address_lbl
            // 
            this.pnl_camera_ip_address_lbl.Controls.Add(this.lbl_camera_ip_address);
            this.pnl_camera_ip_address_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_camera_ip_address_lbl.Location = new System.Drawing.Point(761, 3);
            this.pnl_camera_ip_address_lbl.Name = "pnl_camera_ip_address_lbl";
            this.pnl_camera_ip_address_lbl.Size = new System.Drawing.Size(370, 31);
            this.pnl_camera_ip_address_lbl.TabIndex = 3;
            // 
            // pnl_password_txtbx
            // 
            this.pnl_password_txtbx.Controls.Add(this.txtbx_password);
            this.pnl_password_txtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_password_txtbx.Location = new System.Drawing.Point(382, 40);
            this.pnl_password_txtbx.Name = "pnl_password_txtbx";
            this.pnl_password_txtbx.Size = new System.Drawing.Size(368, 31);
            this.pnl_password_txtbx.TabIndex = 4;
            // 
            // pnl_camera_ip_address_txtbx
            // 
            this.pnl_camera_ip_address_txtbx.Controls.Add(this.txtbx_camera_ip_address);
            this.pnl_camera_ip_address_txtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_camera_ip_address_txtbx.Location = new System.Drawing.Point(761, 40);
            this.pnl_camera_ip_address_txtbx.Name = "pnl_camera_ip_address_txtbx";
            this.pnl_camera_ip_address_txtbx.Size = new System.Drawing.Size(370, 31);
            this.pnl_camera_ip_address_txtbx.TabIndex = 5;
            // 
            // panel1
            // 
            this.tpl_snapshot.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.tlp_file_info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 34);
            this.panel1.TabIndex = 2;
            // 
            // tlp_file_info
            // 
            this.tlp_file_info.ColumnCount = 9;
            this.tlp_file_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_file_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_file_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_file_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_file_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_file_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_file_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_file_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_file_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_file_info.Controls.Add(this.pnl_filename, 0, 0);
            this.tlp_file_info.Controls.Add(this.pnl_filesize, 2, 0);
            this.tlp_file_info.Controls.Add(this.pnl_retries, 4, 0);
            this.tlp_file_info.Controls.Add(this.pnl_save_folder, 6, 0);
            this.tlp_file_info.Controls.Add(this.pnl_unique_num, 8, 0);
            this.tlp_file_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_file_info.Location = new System.Drawing.Point(0, 0);
            this.tlp_file_info.Name = "tlp_file_info";
            this.tlp_file_info.RowCount = 1;
            this.tlp_file_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_file_info.Size = new System.Drawing.Size(1114, 34);
            this.tlp_file_info.TabIndex = 0;
            // 
            // pnl_filename
            // 
            this.pnl_filename.Controls.Add(this.lbl_file_name);
            this.pnl_filename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_filename.Location = new System.Drawing.Point(3, 3);
            this.pnl_filename.Name = "pnl_filename";
            this.pnl_filename.Size = new System.Drawing.Size(431, 28);
            this.pnl_filename.TabIndex = 0;
            // 
            // pnl_filesize
            // 
            this.pnl_filesize.Controls.Add(this.lbl_file_size);
            this.pnl_filesize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_filesize.Location = new System.Drawing.Point(445, 3);
            this.pnl_filesize.Name = "pnl_filesize";
            this.pnl_filesize.Size = new System.Drawing.Size(103, 28);
            this.pnl_filesize.TabIndex = 1;
            // 
            // pnl_retries
            // 
            this.pnl_retries.Controls.Add(this.lbl_retries);
            this.pnl_retries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_retries.Location = new System.Drawing.Point(559, 3);
            this.pnl_retries.Name = "pnl_retries";
            this.pnl_retries.Size = new System.Drawing.Size(103, 28);
            this.pnl_retries.TabIndex = 2;
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.AutoSize = true;
            this.lbl_file_name.Location = new System.Drawing.Point(7, 4);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Size = new System.Drawing.Size(80, 20);
            this.lbl_file_name.TabIndex = 0;
            this.lbl_file_name.Text = "File Name";
            // 
            // lbl_file_size
            // 
            this.lbl_file_size.AutoSize = true;
            this.lbl_file_size.Location = new System.Drawing.Point(3, 4);
            this.lbl_file_size.Name = "lbl_file_size";
            this.lbl_file_size.Size = new System.Drawing.Size(69, 20);
            this.lbl_file_size.TabIndex = 0;
            this.lbl_file_size.Text = "File Size";
            // 
            // lbl_retries
            // 
            this.lbl_retries.AutoSize = true;
            this.lbl_retries.Location = new System.Drawing.Point(3, 4);
            this.lbl_retries.Name = "lbl_retries";
            this.lbl_retries.Size = new System.Drawing.Size(60, 20);
            this.lbl_retries.TabIndex = 0;
            this.lbl_retries.Text = "Retries";
            // 
            // pnl_save_folder
            // 
            this.pnl_save_folder.Controls.Add(this.lbl_save_folder);
            this.pnl_save_folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_save_folder.Location = new System.Drawing.Point(673, 3);
            this.pnl_save_folder.Name = "pnl_save_folder";
            this.pnl_save_folder.Size = new System.Drawing.Size(322, 28);
            this.pnl_save_folder.TabIndex = 3;
            // 
            // lbl_save_folder
            // 
            this.lbl_save_folder.AutoSize = true;
            this.lbl_save_folder.Location = new System.Drawing.Point(3, 4);
            this.lbl_save_folder.Name = "lbl_save_folder";
            this.lbl_save_folder.Size = new System.Drawing.Size(94, 20);
            this.lbl_save_folder.TabIndex = 0;
            this.lbl_save_folder.Text = "Save Folder";
            // 
            // pnl_unique_num
            // 
            this.pnl_unique_num.Controls.Add(this.lbl_unique_number);
            this.pnl_unique_num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_unique_num.Location = new System.Drawing.Point(1006, 3);
            this.pnl_unique_num.Name = "pnl_unique_num";
            this.pnl_unique_num.Size = new System.Drawing.Size(105, 28);
            this.pnl_unique_num.TabIndex = 4;
            // 
            // lbl_unique_number
            // 
            this.lbl_unique_number.AutoSize = true;
            this.lbl_unique_number.Location = new System.Drawing.Point(3, 4);
            this.lbl_unique_number.Name = "lbl_unique_number";
            this.lbl_unique_number.Size = new System.Drawing.Size(97, 20);
            this.lbl_unique_number.TabIndex = 0;
            this.lbl_unique_number.Text = "Unique Num";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 681);
            this.Controls.Add(this.tlp_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "mySnapshot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_image)).EndInit();
            this.tlp_main.ResumeLayout(false);
            this.tabcntrl_main.ResumeLayout(false);
            this.tab_snapshot.ResumeLayout(false);
            this.tpl_snapshot.ResumeLayout(false);
            this.pnl_snapshot_rchtxtbx.ResumeLayout(false);
            this.pnl_snapshot_picbx.ResumeLayout(false);
            this.tab_web_browser.ResumeLayout(false);
            this.pnl_web_browser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webview_browser)).EndInit();
            this.tlp_buttons.ResumeLayout(false);
            this.tpl_settings.ResumeLayout(false);
            this.pnl_username_lbl.ResumeLayout(false);
            this.pnl_username_lbl.PerformLayout();
            this.pnl_username_txtbx.ResumeLayout(false);
            this.pnl_username_txtbx.PerformLayout();
            this.pnl_password_lbl.ResumeLayout(false);
            this.pnl_password_lbl.PerformLayout();
            this.pnl_camera_ip_address_lbl.ResumeLayout(false);
            this.pnl_camera_ip_address_lbl.PerformLayout();
            this.pnl_password_txtbx.ResumeLayout(false);
            this.pnl_password_txtbx.PerformLayout();
            this.pnl_camera_ip_address_txtbx.ResumeLayout(false);
            this.pnl_camera_ip_address_txtbx.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tlp_file_info.ResumeLayout(false);
            this.pnl_filename.ResumeLayout(false);
            this.pnl_filename.PerformLayout();
            this.pnl_filesize.ResumeLayout(false);
            this.pnl_filesize.PerformLayout();
            this.pnl_retries.ResumeLayout(false);
            this.pnl_retries.PerformLayout();
            this.pnl_save_folder.ResumeLayout(false);
            this.pnl_save_folder.PerformLayout();
            this.pnl_unique_num.ResumeLayout(false);
            this.pnl_unique_num.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_findURI;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox picbx_image;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_camera_ip_address;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.TextBox txtbx_camera_ip_address;
        private System.Windows.Forms.Button btn_ping;
        private System.Windows.Forms.Button btn_stop_capture;
        private System.Windows.Forms.Button btn_start_capture;
        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.TabControl tabcntrl_main;
        private System.Windows.Forms.TabPage tab_snapshot;
        private System.Windows.Forms.TableLayoutPanel tpl_snapshot;
        private System.Windows.Forms.Panel pnl_snapshot_rchtxtbx;
        private System.Windows.Forms.RichTextBox rchtxtbx_snapshot_results;
        private System.Windows.Forms.Panel pnl_snapshot_picbx;
        private System.Windows.Forms.TabPage tab_web_browser;
        private System.Windows.Forms.Panel pnl_web_browser;
        private System.Windows.Forms.TableLayoutPanel tlp_buttons;
        private System.Windows.Forms.TableLayoutPanel tpl_settings;
        private System.Windows.Forms.Panel pnl_username_lbl;
        private System.Windows.Forms.Panel pnl_username_txtbx;
        private System.Windows.Forms.Panel pnl_password_lbl;
        private System.Windows.Forms.Panel pnl_camera_ip_address_lbl;
        private System.Windows.Forms.Panel pnl_password_txtbx;
        private System.Windows.Forms.Panel pnl_camera_ip_address_txtbx;
        private Microsoft.Web.WebView2.WinForms.WebView2 webview_browser;
        private System.Windows.Forms.Label lbl_null;
        private System.Windows.Forms.TextBox txtbx_null;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_sync_time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlp_file_info;
        private System.Windows.Forms.Panel pnl_filename;
        private System.Windows.Forms.Label lbl_file_name;
        private System.Windows.Forms.Panel pnl_filesize;
        private System.Windows.Forms.Label lbl_file_size;
        private System.Windows.Forms.Panel pnl_retries;
        private System.Windows.Forms.Label lbl_retries;
        private System.Windows.Forms.Panel pnl_save_folder;
        private System.Windows.Forms.Label lbl_save_folder;
        private System.Windows.Forms.Panel pnl_unique_num;
        private System.Windows.Forms.Label lbl_unique_number;
    }
}

