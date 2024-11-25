namespace GameCollectionManagement
{
    partial class GameList
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSearch = new Button();
            cbGenre = new ComboBox();
            cbPlatform = new ComboBox();
            txtName = new TextBox();
            btnAddGame = new Button();
            btnDelete = new Button();
            btnGameList = new Button();
            btnUpdateGame = new Button();
            panel2 = new Panel();
            dgvGames = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(cbGenre);
            panel1.Controls.Add(cbPlatform);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(btnAddGame);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnGameList);
            panel1.Controls.Add(btnUpdateGame);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 121);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 12);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 10;
            label3.Text = "Oyun Türü";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 12);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 9;
            label2.Text = "Platform";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 8;
            label1.Text = "Oyun Adı";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(617, 45);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbGenre
            // 
            cbGenre.FormattingEnabled = true;
            cbGenre.Location = new Point(460, 44);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(151, 28);
            cbGenre.TabIndex = 6;
            // 
            // cbPlatform
            // 
            cbPlatform.FormattingEnabled = true;
            cbPlatform.Items.AddRange(new object[] { "PC", "XBox", "Play Station", "Nintendo" });
            cbPlatform.Location = new Point(287, 43);
            cbPlatform.Name = "cbPlatform";
            cbPlatform.Size = new Size(151, 28);
            cbPlatform.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(17, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(248, 27);
            txtName.TabIndex = 4;
            // 
            // btnAddGame
            // 
            btnAddGame.Location = new Point(210, 86);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(94, 29);
            btnAddGame.TabIndex = 3;
            btnAddGame.Text = "Oyun Ekle";
            btnAddGame.UseVisualStyleBackColor = true;
            btnAddGame.Click += btnAddGame_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(517, 86);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGameList
            // 
            btnGameList.Location = new Point(323, 86);
            btnGameList.Name = "btnGameList";
            btnGameList.Size = new Size(188, 29);
            btnGameList.TabIndex = 1;
            btnGameList.Text = "Oyunları Listele";
            btnGameList.UseVisualStyleBackColor = true;
            btnGameList.Click += btnGameList_Click;
            // 
            // btnUpdateGame
            // 
            btnUpdateGame.Anchor = AnchorStyles.Right;
            btnUpdateGame.Location = new Point(617, 86);
            btnUpdateGame.Name = "btnUpdateGame";
            btnUpdateGame.Size = new Size(94, 29);
            btnUpdateGame.TabIndex = 0;
            btnUpdateGame.Text = "Güncelle";
            btnUpdateGame.UseVisualStyleBackColor = true;
            btnUpdateGame.Click += btnUpdateGame_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvGames);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(716, 303);
            panel2.TabIndex = 1;
            // 
            // dgvGames
            // 
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Dock = DockStyle.Fill;
            dgvGames.Location = new Point(0, 0);
            dgvGames.Name = "dgvGames";
            dgvGames.RowHeadersWidth = 51;
            dgvGames.Size = new Size(716, 303);
            dgvGames.TabIndex = 0;
            // 
            // GameList
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GameList";
            Size = new Size(716, 424);
            Load += GameList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnUpdateGame;
        private DataGridView dgvGames;
        private Button btnGameList;
        private Button btnDelete;
        private Button btnAddGame;
        private Button btnSearch;
        private ComboBox cbGenre;
        private ComboBox cbPlatform;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
