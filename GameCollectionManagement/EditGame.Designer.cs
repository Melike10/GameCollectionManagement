namespace GameCollectionManagement
{
    partial class EditGame
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOpenFileDialog = new Button();
            txtCoverImage = new TextBox();
            numericGamePlayTime = new NumericUpDown();
            dtpReleaseDate = new DateTimePicker();
            cbGamePlatform = new ComboBox();
            txtGameGenre = new TextBox();
            txtGameName = new TextBox();
            btnEditGame = new Button();
            ofdCoverImage = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 279);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 26;
            label6.Text = "Kapak Fotoğrafı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 226);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 25;
            label5.Text = "Oynama Süresi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 174);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 24;
            label4.Text = "Oyun Platformu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 121);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 23;
            label3.Text = "Oyun Platformu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 69);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 22;
            label2.Text = "Oyun Türü";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 21;
            label1.Text = "Oyun Adı";
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new Point(512, 270);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(41, 29);
            btnOpenFileDialog.TabIndex = 20;
            btnOpenFileDialog.Text = "...";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click;
            // 
            // txtCoverImage
            // 
            txtCoverImage.Location = new Point(198, 272);
            txtCoverImage.Name = "txtCoverImage";
            txtCoverImage.Size = new Size(308, 27);
            txtCoverImage.TabIndex = 19;
            // 
            // numericGamePlayTime
            // 
            numericGamePlayTime.Location = new Point(198, 219);
            numericGamePlayTime.Name = "numericGamePlayTime";
            numericGamePlayTime.Size = new Size(355, 27);
            numericGamePlayTime.TabIndex = 18;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(198, 167);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(355, 27);
            dtpReleaseDate.TabIndex = 17;
            // 
            // cbGamePlatform
            // 
            cbGamePlatform.FormattingEnabled = true;
            cbGamePlatform.Items.AddRange(new object[] { "PC", "XBox", "Play Station", "Nintendo" });
            cbGamePlatform.Location = new Point(198, 121);
            cbGamePlatform.Name = "cbGamePlatform";
            cbGamePlatform.Size = new Size(355, 28);
            cbGamePlatform.TabIndex = 16;
            // 
            // txtGameGenre
            // 
            txtGameGenre.Location = new Point(198, 69);
            txtGameGenre.Name = "txtGameGenre";
            txtGameGenre.Size = new Size(355, 27);
            txtGameGenre.TabIndex = 15;
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(198, 21);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(355, 27);
            txtGameName.TabIndex = 14;
            // 
            // btnEditGame
            // 
            btnEditGame.Location = new Point(459, 338);
            btnEditGame.Name = "btnEditGame";
            btnEditGame.Size = new Size(94, 29);
            btnEditGame.TabIndex = 27;
            btnEditGame.Text = "Güncelle";
            btnEditGame.UseVisualStyleBackColor = true;
            btnEditGame.Click += btnEditGame_Click;
            // 
            // ofdCoverImage
            // 
            ofdCoverImage.FileName = "openFileDialog1";
            // 
            // EditGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(btnEditGame);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOpenFileDialog);
            Controls.Add(txtCoverImage);
            Controls.Add(numericGamePlayTime);
            Controls.Add(dtpReleaseDate);
            Controls.Add(cbGamePlatform);
            Controls.Add(txtGameGenre);
            Controls.Add(txtGameName);
            Name = "EditGame";
            Text = "Oyun Güncelle";
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnOpenFileDialog;
        private TextBox txtCoverImage;
        private NumericUpDown numericGamePlayTime;
        private DateTimePicker dtpReleaseDate;
        private ComboBox cbGamePlatform;
        private TextBox txtGameGenre;
        private TextBox txtGameName;
        private Button btnEditGame;
        private OpenFileDialog ofdCoverImage;
    }
}