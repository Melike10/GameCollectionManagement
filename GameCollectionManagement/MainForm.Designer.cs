﻿namespace GameCollectionManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileTsmi = new ToolStripMenuItem();
            exitTsmi = new ToolStripMenuItem();
            userTsmi = new ToolStripMenuItem();
            registerTsmi = new ToolStripMenuItem();
            allUserTsmi = new ToolStripMenuItem();
            gameTsmi = new ToolStripMenuItem();
            allGameTsmi = new ToolStripMenuItem();
            addGameTsmi = new ToolStripMenuItem();
            reviewTsmi = new ToolStripMenuItem();
            addReviewTsmi = new ToolStripMenuItem();
            allReviewTsmi = new ToolStripMenuItem();
            panelContent = new Panel();
            statusStrip1 = new StatusStrip();
            tsslUserName = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            panelContent.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileTsmi, userTsmi, gameTsmi, reviewTsmi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileTsmi
            // 
            fileTsmi.DropDownItems.AddRange(new ToolStripItem[] { exitTsmi });
            fileTsmi.Name = "fileTsmi";
            fileTsmi.Size = new Size(64, 24);
            fileTsmi.Text = "Dosya";
            // 
            // exitTsmi
            // 
            exitTsmi.Name = "exitTsmi";
            exitTsmi.Size = new Size(122, 26);
            exitTsmi.Text = "Çıkış";
            // 
            // userTsmi
            // 
            userTsmi.DropDownItems.AddRange(new ToolStripItem[] { registerTsmi, allUserTsmi });
            userTsmi.Name = "userTsmi";
            userTsmi.Size = new Size(79, 24);
            userTsmi.Text = "Kullanıcı";
            // 
            // registerTsmi
            // 
            registerTsmi.Name = "registerTsmi";
            registerTsmi.Size = new Size(198, 26);
            registerTsmi.Text = "Kayıt Ol";
            registerTsmi.Click += registerTsmi_Click;
            // 
            // allUserTsmi
            // 
            allUserTsmi.Name = "allUserTsmi";
            allUserTsmi.Size = new Size(198, 26);
            allUserTsmi.Text = "Tüm Kullanıcılar";
            allUserTsmi.Click += allUserTsmi_Click;
            // 
            // gameTsmi
            // 
            gameTsmi.DropDownItems.AddRange(new ToolStripItem[] { allGameTsmi, addGameTsmi });
            gameTsmi.Name = "gameTsmi";
            gameTsmi.Size = new Size(57, 24);
            gameTsmi.Text = "Oyun";
            // 
            // allGameTsmi
            // 
            allGameTsmi.Name = "allGameTsmi";
            allGameTsmi.Size = new Size(176, 26);
            allGameTsmi.Text = "Tüm Oyunlar";
            allGameTsmi.Click += allGameTsmi_Click;
            // 
            // addGameTsmi
            // 
            addGameTsmi.Name = "addGameTsmi";
            addGameTsmi.Size = new Size(176, 26);
            addGameTsmi.Text = "Oyun Ekle";
            addGameTsmi.Click += addGameTsmi_Click;
            // 
            // reviewTsmi
            // 
            reviewTsmi.DropDownItems.AddRange(new ToolStripItem[] { addReviewTsmi, allReviewTsmi });
            reviewTsmi.Name = "reviewTsmi";
            reviewTsmi.Size = new Size(65, 24);
            reviewTsmi.Text = "Yorum";
            // 
            // addReviewTsmi
            // 
            addReviewTsmi.Name = "addReviewTsmi";
            addReviewTsmi.Size = new Size(224, 26);
            addReviewTsmi.Text = "Yorum Ekle";
            addReviewTsmi.Click += addReviewTsmi_Click;
            // 
            // allReviewTsmi
            // 
            allReviewTsmi.Name = "allReviewTsmi";
            allReviewTsmi.Size = new Size(224, 26);
            allReviewTsmi.Text = "Tüm Yorumlar";
            allReviewTsmi.Click += allReviewTsmi_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(statusStrip1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 28);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(800, 422);
            panelContent.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslUserName });
            statusStrip1.Location = new Point(0, 400);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslUserName
            // 
            tsslUserName.Name = "tsslUserName";
            tsslUserName.Size = new Size(0, 16);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Oyun Koleksiyon Yönetimi";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileTsmi;
        private ToolStripMenuItem exitTsmi;
        private ToolStripMenuItem userTsmi;
        private ToolStripMenuItem registerTsmi;
        private ToolStripMenuItem allUserTsmi;
        private ToolStripMenuItem gameTsmi;
        private ToolStripMenuItem allGameTsmi;
        private ToolStripMenuItem reviewTsmi;
        private ToolStripMenuItem addGameTsmi;
        private ToolStripMenuItem addReviewTsmi;
        private ToolStripMenuItem allReviewTsmi;
        private Panel panelContent;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslUserName;
    }
}