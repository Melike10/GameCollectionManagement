namespace GameCollectionManagement
{
    partial class EditUser
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtRole = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 173);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 15;
            label4.Text = "Rol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 124);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 14;
            label3.Text = "Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 73);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 13;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 12;
            label1.Text = "Kullanıcı İsmi";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(136, 173);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(247, 27);
            txtRole.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(136, 124);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(247, 27);
            txtPassword.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(136, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(136, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 27);
            txtName.TabIndex = 8;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(289, 248);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 316);
            Controls.Add(btnEdit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRole);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "EditUser";
            Text = "EditUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtRole;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtName;
        private Button btnEdit;
    }
}