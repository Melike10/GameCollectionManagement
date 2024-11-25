//using Microsoft.VisualBasic.ApplicationServices;

using GameCollectionManagement.Models;

namespace GameCollectionManagement
{
    public partial class MainForm : Form
    {
        private readonly User _user;
        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
            tsslUserName.Text = _user.Name;
        }

        private void AddControl(UserControl control)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(control);
        }
        private void addGameTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new AddGame());
        }

        private void allGameTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new GameList());
        }

        private void registerTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new AddUser());
        }

        private void allUserTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new UserList());
        }

        private void addReviewTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new AddReview(_user));

        }

        private void allReviewTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new ReviewList(_user));
        }
    }
}
