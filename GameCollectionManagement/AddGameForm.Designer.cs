namespace GameCollectionManagement
{
    partial class AddGameForm
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
            panelController = new Panel();
            SuspendLayout();
            // 
            // panelController
            // 
            panelController.Dock = DockStyle.Fill;
            panelController.Location = new Point(0, 0);
            panelController.Name = "panelController";
            panelController.Size = new Size(576, 409);
            panelController.TabIndex = 0;
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 409);
            Controls.Add(panelController);
            Name = "AddGameForm";
            Text = "AddGameForm";
            Load += AddGameForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelController;
    }
}