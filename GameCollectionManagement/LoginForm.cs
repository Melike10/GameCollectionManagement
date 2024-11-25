using GameCollectionManagement.Models;
using GameCollectionManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionManagement
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        public bool IsAuthenticated { get; private set; }
        public User User { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz");
            }
            var res = _userService.Login(txtName.Text, txtPassword.Text);
            if (res.isAuthenticated)
            {
                var user = _userService.GetById(res.userId.Value);
                User = user;
                IsAuthenticated = true;
                Close();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı ya da şifre");
            }

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm();
            addUser.ShowDialog();
        }
    }
}
