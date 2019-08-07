namespace C19_Ex01_Ziv_308445949_Noam_313527822
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.friendTab = new System.Windows.Forms.TabPage();
            this.postTab = new System.Windows.Forms.TabPage();
            this.eventsTab = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Friends = new System.Windows.Forms.ListBox();
            this.showFriendsBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.friendTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.friendTab);
            this.tabControl1.Controls.Add(this.postTab);
            this.tabControl1.Controls.Add(this.eventsTab);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(82, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 373);
            this.tabControl1.TabIndex = 1;
            // 
            // friendTab
            // 
            this.friendTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.friendTab.Controls.Add(this.showFriendsBtn);
            this.friendTab.Controls.Add(this.Friends);
            this.friendTab.Location = new System.Drawing.Point(4, 29);
            this.friendTab.Name = "friendTab";
            this.friendTab.Padding = new System.Windows.Forms.Padding(3);
            this.friendTab.Size = new System.Drawing.Size(606, 340);
            this.friendTab.TabIndex = 1;
            this.friendTab.Text = "Friends";
            this.friendTab.UseVisualStyleBackColor = true;
            // 
            // postTab
            // 
            this.postTab.Location = new System.Drawing.Point(4, 29);
            this.postTab.Name = "postTab";
            this.postTab.Padding = new System.Windows.Forms.Padding(3);
            this.postTab.Size = new System.Drawing.Size(436, 7);
            this.postTab.TabIndex = 0;
            this.postTab.Text = "Posts";
            this.postTab.UseVisualStyleBackColor = true;
            // 
            // eventsTab
            // 
            this.eventsTab.Location = new System.Drawing.Point(4, 29);
            this.eventsTab.Name = "eventsTab";
            this.eventsTab.Size = new System.Drawing.Size(436, 7);
            this.eventsTab.TabIndex = 2;
            this.eventsTab.Text = "Events";
            this.eventsTab.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(436, 7);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Friends
            // 
            this.Friends.FormattingEnabled = true;
            this.Friends.ItemHeight = 20;
            this.Friends.Location = new System.Drawing.Point(276, 42);
            this.Friends.Name = "Friends";
            this.Friends.Size = new System.Drawing.Size(291, 244);
            this.Friends.TabIndex = 0;
            // 
            // showFriendsBtn
            // 
            this.showFriendsBtn.Location = new System.Drawing.Point(33, 42);
            this.showFriendsBtn.Name = "showFriendsBtn";
            this.showFriendsBtn.Size = new System.Drawing.Size(176, 82);
            this.showFriendsBtn.TabIndex = 1;
            this.showFriendsBtn.Text = "Show Friends";
            this.showFriendsBtn.UseVisualStyleBackColor = true;
            this.showFriendsBtn.Click += new System.EventHandler(this.showFriendsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.friendTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage friendTab;
        private System.Windows.Forms.TabPage postTab;
        private System.Windows.Forms.TabPage eventsTab;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button showFriendsBtn;
        private System.Windows.Forms.ListBox Friends;
    }
}