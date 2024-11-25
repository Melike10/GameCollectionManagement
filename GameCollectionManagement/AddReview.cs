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
    public partial class AddReview : UserControl
    {
        private readonly IReviewService _reviewService;
        private readonly User _user;
        private readonly IGameService _gameService;
        private ReviewList _reviewList;
        public AddReview(User user)
        {
            InitializeComponent();
            _reviewService = new ReviewService();
            _user = user;
            _gameService=new GameService();
            var games = _gameService.GetAll();
            cmdGame.DataSource = games;
            cmdGame.DisplayMember = "Name";
            cmdGame.ValueMember = "Id";
        }
        public AddReview(User user,ReviewList reviewList)
        {
            InitializeComponent();
            _reviewService = new ReviewService();
            _user = user;
            _gameService = new GameService();
            var games = _gameService.GetAll();
            cmdGame.DataSource = games;
            cmdGame.DisplayMember = "Name";
            cmdGame.ValueMember = "Id";
            _reviewList = reviewList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput()) {
                var selectedGame = cmdGame.SelectedItem as Game;
                if (selectedGame is null)
                {
                    MessageBox.Show("Sistemsel bir hata oluştu");
                }
                Review review = new Review();
                review.ReviewText=txtReview.Text.Trim();
                review.Rating = (int)numRating.Value;
                review.UserId = _user.Id;
                review.GameId = selectedGame.Id;
                try
                {
                    _reviewService.Add(review);
                    MessageBox.Show("Yorumunuz eklendi");
                    if(_reviewList is not null)
                    {
                        _reviewList.LoadReviews();
                        ((Form)Parent.Parent).Close();
                    }
                    ClearInputs();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
             
            }

        }
        private void ClearInputs()
        {
            foreach(var control in Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if(control is ComboBox)
                {
                    ((ComboBox)control).SelectedItem = null;
                }
                else if(control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = numRating.Minimum;
                }

            }
        }
        private bool ValidateInput()
        {
            if(cmdGame.SelectedItem == null)
            {
                MessageBox.Show("Bir oyun seçmelisiniz");
                return false;
            }
            if (numRating.Value < 1 || numRating.Value > 5)
            {
                MessageBox.Show("Puanlama 1-5 arasında olmalı");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtReview.Text)) 
            {
                MessageBox.Show("Yorum kısmı boş bırakılamaz");
                return false;
            }
            return true;
        }
    }
}
