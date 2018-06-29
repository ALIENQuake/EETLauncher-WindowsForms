namespace EETLauncher {
    partial class EETLauncherSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.EETLauncherSettings_PB_Logo = new System.Windows.Forms.PictureBox();
            this.EETLauncherSettings_LB_SETTINGS = new System.Windows.Forms.Label();
            this.EETLauncherSettings_LB_BACK = new System.Windows.Forms.Label();
            this.EETLauncherSettings_L_CurrentGUI = new System.Windows.Forms.Label();
            this.EETLauncherSettings_LB_CHANGEGUI = new System.Windows.Forms.Label();
            this.EETLauncherSettings_LB_OpenEETBaldurLua = new System.Windows.Forms.Label();
            this.EETLauncherSettings_TB_Log = new System.Windows.Forms.TextBox();
            this.bWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.EETLauncherSettings_PB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // EETLauncherSettings_PB_Logo
            // 
            this.EETLauncherSettings_PB_Logo.BackColor = System.Drawing.Color.Transparent;
            this.EETLauncherSettings_PB_Logo.BackgroundImage = global::EETLauncher.Properties.Resources.EETLauncher_Logo;
            this.EETLauncherSettings_PB_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EETLauncherSettings_PB_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.EETLauncherSettings_PB_Logo.Location = new System.Drawing.Point(0, 0);
            this.EETLauncherSettings_PB_Logo.Margin = new System.Windows.Forms.Padding(0);
            this.EETLauncherSettings_PB_Logo.Name = "EETLauncherSettings_PB_Logo";
            this.EETLauncherSettings_PB_Logo.Size = new System.Drawing.Size(327, 118);
            this.EETLauncherSettings_PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EETLauncherSettings_PB_Logo.TabIndex = 5;
            this.EETLauncherSettings_PB_Logo.TabStop = false;
            this.EETLauncherSettings_PB_Logo.WaitOnLoad = true;
            this.EETLauncherSettings_PB_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EETLauncherSettings_PB_Logo_MouseDown);
            // 
            // EETLauncherSettings_LB_SETTINGS
            // 
            this.EETLauncherSettings_LB_SETTINGS.AutoSize = true;
            this.EETLauncherSettings_LB_SETTINGS.BackColor = System.Drawing.Color.Transparent;
            this.EETLauncherSettings_LB_SETTINGS.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EETLauncherSettings_LB_SETTINGS.ForeColor = System.Drawing.Color.White;
            this.EETLauncherSettings_LB_SETTINGS.Location = new System.Drawing.Point(124, 129);
            this.EETLauncherSettings_LB_SETTINGS.Margin = new System.Windows.Forms.Padding(0);
            this.EETLauncherSettings_LB_SETTINGS.Name = "EETLauncherSettings_LB_SETTINGS";
            this.EETLauncherSettings_LB_SETTINGS.Size = new System.Drawing.Size(80, 24);
            this.EETLauncherSettings_LB_SETTINGS.TabIndex = 1;
            this.EETLauncherSettings_LB_SETTINGS.Text = "SETTINGS";
            this.EETLauncherSettings_LB_SETTINGS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EETLauncherSettings_LB_BACK
            // 
            this.EETLauncherSettings_LB_BACK.AutoSize = true;
            this.EETLauncherSettings_LB_BACK.BackColor = System.Drawing.Color.Transparent;
            this.EETLauncherSettings_LB_BACK.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EETLauncherSettings_LB_BACK.ForeColor = System.Drawing.Color.White;
            this.EETLauncherSettings_LB_BACK.Location = new System.Drawing.Point(134, 306);
            this.EETLauncherSettings_LB_BACK.Margin = new System.Windows.Forms.Padding(0);
            this.EETLauncherSettings_LB_BACK.Name = "EETLauncherSettings_LB_BACK";
            this.EETLauncherSettings_LB_BACK.Size = new System.Drawing.Size(51, 24);
            this.EETLauncherSettings_LB_BACK.TabIndex = 0;
            this.EETLauncherSettings_LB_BACK.Text = "BACK";
            this.EETLauncherSettings_LB_BACK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EETLauncherSettings_LB_BACK.Click += new System.EventHandler(this.EETLauncherSettings_LB_BACK_Click);
            this.EETLauncherSettings_LB_BACK.MouseLeave += new System.EventHandler(this.EETLauncherSettings_LB_BACK_MouseLeave);
            this.EETLauncherSettings_LB_BACK.MouseHover += new System.EventHandler(this.EETLauncherSettings_LB_BACK_MouseHover);
            // 
            // EETLauncherSettings_L_CurrentGUI
            // 
            this.EETLauncherSettings_L_CurrentGUI.AutoSize = true;
            this.EETLauncherSettings_L_CurrentGUI.BackColor = System.Drawing.Color.Transparent;
            this.EETLauncherSettings_L_CurrentGUI.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EETLauncherSettings_L_CurrentGUI.ForeColor = System.Drawing.Color.White;
            this.EETLauncherSettings_L_CurrentGUI.Location = new System.Drawing.Point(93, 173);
            this.EETLauncherSettings_L_CurrentGUI.Margin = new System.Windows.Forms.Padding(0);
            this.EETLauncherSettings_L_CurrentGUI.Name = "EETLauncherSettings_L_CurrentGUI";
            this.EETLauncherSettings_L_CurrentGUI.Size = new System.Drawing.Size(114, 24);
            this.EETLauncherSettings_L_CurrentGUI.TabIndex = 2;
            this.EETLauncherSettings_L_CurrentGUI.Text = "CURRENT GUI:";
            this.EETLauncherSettings_L_CurrentGUI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EETLauncherSettings_LB_CHANGEGUI
            // 
            this.EETLauncherSettings_LB_CHANGEGUI.AutoSize = true;
            this.EETLauncherSettings_LB_CHANGEGUI.BackColor = System.Drawing.Color.Transparent;
            this.EETLauncherSettings_LB_CHANGEGUI.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EETLauncherSettings_LB_CHANGEGUI.ForeColor = System.Drawing.Color.White;
            this.EETLauncherSettings_LB_CHANGEGUI.Location = new System.Drawing.Point(93, 197);
            this.EETLauncherSettings_LB_CHANGEGUI.Margin = new System.Windows.Forms.Padding(0);
            this.EETLauncherSettings_LB_CHANGEGUI.Name = "EETLauncherSettings_LB_CHANGEGUI";
            this.EETLauncherSettings_LB_CHANGEGUI.Size = new System.Drawing.Size(91, 24);
            this.EETLauncherSettings_LB_CHANGEGUI.TabIndex = 3;
            this.EETLauncherSettings_LB_CHANGEGUI.Text = "CHANGE to";
            this.EETLauncherSettings_LB_CHANGEGUI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EETLauncherSettings_LB_CHANGEGUI.Click += new System.EventHandler(this.EETLauncherSettings_LB_CHANGEGUI_Click);
            this.EETLauncherSettings_LB_CHANGEGUI.MouseLeave += new System.EventHandler(this.EETLauncherSettings_LB_CHANGEGUI_MouseLeave);
            this.EETLauncherSettings_LB_CHANGEGUI.MouseHover += new System.EventHandler(this.EETLauncherSettings_LB_CHANGEGUI_MouseHover);
            // 
            // EETLauncherSettings_LB_OpenEETBaldurLua
            // 
            this.EETLauncherSettings_LB_OpenEETBaldurLua.AutoSize = true;
            this.EETLauncherSettings_LB_OpenEETBaldurLua.BackColor = System.Drawing.Color.Transparent;
            this.EETLauncherSettings_LB_OpenEETBaldurLua.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EETLauncherSettings_LB_OpenEETBaldurLua.ForeColor = System.Drawing.Color.White;
            this.EETLauncherSettings_LB_OpenEETBaldurLua.Location = new System.Drawing.Point(80, 250);
            this.EETLauncherSettings_LB_OpenEETBaldurLua.Margin = new System.Windows.Forms.Padding(0);
            this.EETLauncherSettings_LB_OpenEETBaldurLua.Name = "EETLauncherSettings_LB_OpenEETBaldurLua";
            this.EETLauncherSettings_LB_OpenEETBaldurLua.Size = new System.Drawing.Size(164, 24);
            this.EETLauncherSettings_LB_OpenEETBaldurLua.TabIndex = 4;
            this.EETLauncherSettings_LB_OpenEETBaldurLua.Text = "OPEN EET Baldur.Lua";
            this.EETLauncherSettings_LB_OpenEETBaldurLua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EETLauncherSettings_LB_OpenEETBaldurLua.Click += new System.EventHandler(this.EETLauncherSettings_LB_OpenEETBaldurLua_Click);
            this.EETLauncherSettings_LB_OpenEETBaldurLua.MouseLeave += new System.EventHandler(this.EETLauncherSettings_LB_OpenEETBaldurLua_MouseLeave);
            this.EETLauncherSettings_LB_OpenEETBaldurLua.MouseHover += new System.EventHandler(this.EETLauncherSettings_LB_OpenEETBaldurLua_MouseHover);
            // 
            // EETLauncherSettings_TB_Log
            // 
            this.EETLauncherSettings_TB_Log.BackColor = System.Drawing.Color.Black;
            this.EETLauncherSettings_TB_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EETLauncherSettings_TB_Log.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EETLauncherSettings_TB_Log.ForeColor = System.Drawing.Color.White;
            this.EETLauncherSettings_TB_Log.Location = new System.Drawing.Point(0, 348);
            this.EETLauncherSettings_TB_Log.Margin = new System.Windows.Forms.Padding(0);
            this.EETLauncherSettings_TB_Log.Multiline = true;
            this.EETLauncherSettings_TB_Log.Name = "EETLauncherSettings_TB_Log";
            this.EETLauncherSettings_TB_Log.Size = new System.Drawing.Size(327, 13);
            this.EETLauncherSettings_TB_Log.TabIndex = 6;
            // 
            // bWorker1
            // 
            this.bWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWorker1_DoWork);
            // 
            // EETLauncherSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::EETLauncher.Properties.Resources.EETLauncher_Background;
            this.ClientSize = new System.Drawing.Size(327, 361);
            this.Controls.Add(this.EETLauncherSettings_TB_Log);
            this.Controls.Add(this.EETLauncherSettings_PB_Logo);
            this.Controls.Add(this.EETLauncherSettings_LB_OpenEETBaldurLua);
            this.Controls.Add(this.EETLauncherSettings_LB_CHANGEGUI);
            this.Controls.Add(this.EETLauncherSettings_L_CurrentGUI);
            this.Controls.Add(this.EETLauncherSettings_LB_SETTINGS);
            this.Controls.Add(this.EETLauncherSettings_LB_BACK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EETLauncherSettings";
            this.Text = "EETLauncherSettings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EETLauncherSettings_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EETLauncherSettings_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.EETLauncherSettings_PB_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EETLauncherSettings_LB_BACK;
        private System.Windows.Forms.Label EETLauncherSettings_LB_SETTINGS;
        private System.Windows.Forms.Label EETLauncherSettings_L_CurrentGUI;
        private System.Windows.Forms.Label EETLauncherSettings_LB_CHANGEGUI;
        private System.Windows.Forms.Label EETLauncherSettings_LB_OpenEETBaldurLua;
        private System.Windows.Forms.PictureBox EETLauncherSettings_PB_Logo;
        private System.Windows.Forms.TextBox EETLauncherSettings_TB_Log;
        private System.ComponentModel.BackgroundWorker bWorker1;
    }
}