namespace GameCollectionManagement
{
    partial class AddGame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtGameName = new TextBox();
            txtGameGenre = new TextBox();
            cbGamePlatform = new ComboBox();
            dtpReleaseDate = new DateTimePicker();
            numericGamePlayTime = new NumericUpDown();
            txtCoverImage = new TextBox();
            btnOpenFileDialog = new Button();
            ofdCoverImage = new OpenFileDialog();
            btnSaveGame = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).BeginInit();
            SuspendLayout();
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(189, 30);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(355, 27);
            txtGameName.TabIndex = 0;
            // 
            // txtGameGenre
            // 
            txtGameGenre.Location = new Point(189, 78);
            txtGameGenre.Name = "txtGameGenre";
            txtGameGenre.Size = new Size(355, 27);
            txtGameGenre.TabIndex = 1;
            // 
            // cbGamePlatform
            // 
            cbGamePlatform.FormattingEnabled = true;
            cbGamePlatform.Items.AddRange(new object[] { "PC", "XBox", "Play Station", "Nintendo" });
            cbGamePlatform.Location = new Point(189, 130);
            cbGamePlatform.Name = "cbGamePlatform";
            cbGamePlatform.Size = new Size(355, 28);
            cbGamePlatform.TabIndex = 2;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(189, 176);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(355, 27);
            dtpReleaseDate.TabIndex = 3;
            // 
            // numericGamePlayTime
            // 
            numericGamePlayTime.Location = new Point(189, 228);
            numericGamePlayTime.Name = "numericGamePlayTime";
            numericGamePlayTime.Size = new Size(355, 27);
            numericGamePlayTime.TabIndex = 4;
            // 
            // txtCoverImage
            // 
            txtCoverImage.Location = new Point(189, 281);
            txtCoverImage.Name = "txtCoverImage";
            txtCoverImage.Size = new Size(308, 27);
            txtCoverImage.TabIndex = 5;
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new Point(503, 279);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(41, 29);
            btnOpenFileDialog.TabIndex = 6;
            btnOpenFileDialog.Text = "...";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click;
            // 
            // ofdCoverImage
            // 
            ofdCoverImage.FileName = "openFileDialog1";
            // 
            // btnSaveGame
            // 
            btnSaveGame.Location = new Point(450, 339);
            btnSaveGame.Name = "btnSaveGame";
            btnSaveGame.Size = new Size(94, 29);
            btnSaveGame.TabIndex = 7;
            btnSaveGame.Text = "Oyun Ekle";
            btnSaveGame.UseVisualStyleBackColor = true;
            btnSaveGame.Click += btnSaveGame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 8;
            label1.Text = "Oyun Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 78);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 9;
            label2.Text = "Oyun Türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 130);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 10;
            label3.Text = "Oyun Platformu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 183);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 11;
            label4.Text = "Oyun Platformu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 235);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 12;
            label5.Text = "Oynama Süresi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 288);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 13;
            label6.Text = "Kapak Fotoğrafı";
            // 
            // AddGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSaveGame);
            Controls.Add(btnOpenFileDialog);
            Controls.Add(txtCoverImage);
            Controls.Add(numericGamePlayTime);
            Controls.Add(dtpReleaseDate);
            Controls.Add(cbGamePlatform);
            Controls.Add(txtGameGenre);
            Controls.Add(txtGameName);
            Name = "AddGame";
            Size = new Size(573, 406);
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGameName;
        private TextBox txtGameGenre;
        private ComboBox cbGamePlatform;
        private DateTimePicker dtpReleaseDate;
        private NumericUpDown numericGamePlayTime;
        private TextBox txtCoverImage;
        private Button btnOpenFileDialog;
        private OpenFileDialog ofdCoverImage;
        private Button btnSaveGame;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
