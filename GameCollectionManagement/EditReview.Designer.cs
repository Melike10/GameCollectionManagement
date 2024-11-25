namespace GameCollectionManagement
{
    partial class EditReview
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtReview = new TextBox();
            numRating = new NumericUpDown();
            cmdGame = new ComboBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 152);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 12;
            label3.Text = "Yorum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 106);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 11;
            label2.Text = "Puan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 49);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 10;
            label1.Text = "Oyun";
            // 
            // txtReview
            // 
            txtReview.Location = new Point(151, 152);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(227, 114);
            txtReview.TabIndex = 9;
            // 
            // numRating
            // 
            numRating.Location = new Point(151, 99);
            numRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(227, 27);
            numRating.TabIndex = 8;
            numRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmdGame
            // 
            cmdGame.FormattingEnabled = true;
            cmdGame.Location = new Point(151, 49);
            cmdGame.Name = "cmdGame";
            cmdGame.Size = new Size(227, 28);
            cmdGame.TabIndex = 7;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(284, 337);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // EditReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 401);
            Controls.Add(btnEdit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtReview);
            Controls.Add(numRating);
            Controls.Add(cmdGame);
            Name = "EditReview";
            Text = "EditReview";
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtReview;
        private NumericUpDown numRating;
        private ComboBox cmdGame;
        private Button btnEdit;
    }
}