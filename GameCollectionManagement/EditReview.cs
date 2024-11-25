using GameCollectionManagement.Models;
using GameCollectionManagement.Services;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class EditReview : Form
    {
        private readonly IReviewService _reviewService;
        private readonly IGameService _gameService;
        private Review _review;
        private readonly ReviewList _reviewList;
        public EditReview(int id, ReviewList reviewList)
        {

            InitializeComponent();
            _reviewService = new ReviewService();
            _gameService = new GameService();
            _review = _reviewService.GetById(id);
            cmdGame.DataSource = _gameService.GetAll();
            cmdGame.DisplayMember = nameof(Game.Name);
            cmdGame.ValueMember = nameof(Game.Id);
            cmdGame.SelectedItem = _review.GameId;
            txtReview.Text = _review.ReviewText;
            numRating.Value = _review.Rating;
            _reviewList = reviewList;




        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var selectedGame = cmdGame.SelectedItem as Game;
                if (selectedGame is null)
                {
                    MessageBox.Show("Sistemsel bir hata oluştu");
                }
                
                _review.ReviewText = txtReview.Text.Trim();
                _review.Rating = (int)numRating.Value;
               
                _review.GameId = selectedGame.Id;
                try
                {
                    _reviewService.Update(_review);
                    MessageBox.Show("Yorumunuz güncellendi");
                    _reviewList.LoadReviews();
                    Close();
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

        }

        private bool ValidateInput()
        {
            if (cmdGame.SelectedItem == null)
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
