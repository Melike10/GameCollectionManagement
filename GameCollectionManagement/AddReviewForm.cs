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
    public partial class AddReviewForm : Form
    {
        private readonly IReviewService _reviewService;
        private User _user;
        private readonly ReviewList _reviewList;
        public AddReviewForm(User user, ReviewList reviewList)
        {
            InitializeComponent();
            _reviewService = new ReviewService();
            _user = user;
            _reviewList = reviewList;
        }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {
            AddReview addReview = new AddReview(_user,_reviewList);
            panelContainer.Controls.Add(addReview);
        }
    }
}
