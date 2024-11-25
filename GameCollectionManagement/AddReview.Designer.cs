namespace GameCollectionManagement
{
    partial class AddReview
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
            cmdGame = new ComboBox();
            numRating = new NumericUpDown();
            txtReview = new TextBox();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // cmdGame
            // 
            cmdGame.FormattingEnabled = true;
            cmdGame.Location = new Point(113, 36);
            cmdGame.Name = "cmdGame";
            cmdGame.Size = new Size(227, 28);
            cmdGame.TabIndex = 0;
            // 
            // numRating
            // 
            numRating.Location = new Point(113, 86);
            numRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(227, 27);
            numRating.TabIndex = 1;
            numRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtReview
            // 
            txtReview.Location = new Point(113, 139);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(227, 114);
            txtReview.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(246, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 36);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 4;
            label1.Text = "Oyun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 93);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 5;
            label2.Text = "Puan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 139);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 6;
            label3.Text = "Yorum";
            // 
            // AddReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(txtReview);
            Controls.Add(numRating);
            Controls.Add(cmdGame);
            Name = "AddReview";
            Size = new Size(388, 341);
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmdGame;
        private NumericUpDown numRating;
        private TextBox txtReview;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
