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
    public partial class EditUser : Form
    {
        public readonly IUserService _userService;
        private User _user;
        private UserList _userList;
        public EditUser(int id, UserList userList)
        {
            InitializeComponent();
            _userService = new UserService();
            _userList = userList;
            _user = _userService.GetById(id);
            txtEmail.Text = _user.Email;
            txtPassword.Text = _user.Password;
            txtName.Text = _user.Name;
            txtRole.Text = _user.Role;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                _user.Email = txtEmail.Text.Trim();
                _user.Password = txtPassword.Text.Trim();
                _user.Name = txtName.Text.Trim();
                _user.Role = txtRole.Text.Trim();

                try
                {
                    _userService.Update(_user);
                    MessageBox.Show("Kullanıcı güncellendi");
                    _userList.LoadUsers();
                    Close();
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ClearForm()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtName.Clear();
            txtRole.Clear();
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Kullanıcı İsmi  Giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email Giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Şifre Giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("Role Giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
