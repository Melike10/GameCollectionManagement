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
    public partial class AddUser : UserControl
    {
        private IUserService _userService;
        private UserList _userList;
        private bool _fromLoginPage=false;
        public AddUser(bool fromLoginPage=false)
        {
            InitializeComponent();
            _userService = new UserService();
            _fromLoginPage = fromLoginPage;
        }
        public AddUser(UserList userList)
        {
            InitializeComponent();
            _userService = new UserService();
            _userList = userList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                User user = new User();
                user.Name = txtName.Text;
                user.Email = txtEmail.Text;
                user.Password = txtPassword.Text;
                user.Role = txtRole.Text;

                try
                {
                    _userService.Add(user);
                    MessageBox.Show("Kullanıcı eklendi");
                    if(_userList is not null)
                    {
                        _userList.LoadUsers();
                        ((Form)Parent.Parent).Close();
                    }
                    if (_fromLoginPage)
                    {
                        ((Form)Parent.Parent).Close();
                    }
                    ClearForm();


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
