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
    public partial class EditGame : Form
    {
        private readonly IGameService _gameService;
        private Game _game;
        public EditGame(int id)
        {
            InitializeComponent();
            _gameService = new GameService();
            _game = _gameService.GetById(id);

            txtGameName.Text = _game.Name;
            txtGameGenre.Text = _game.Genre;
            cbGamePlatform.SelectedItem = _game.Platform;
            numericGamePlayTime.Value = (decimal)_game.PlayTime;
            dtpReleaseDate.Value = _game.ReleaseDate ?? DateTime.Now;

        }
        private byte[] _selectedCoverImage = null;
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            // bir şey seçilip tamama basılınca
            if (ofdCoverImage.ShowDialog() == DialogResult.OK)
            {
                string imagePath = ofdCoverImage.FileName;
                _selectedCoverImage = File.ReadAllBytes(imagePath);
            }
        }

        private void btnEditGame_Click(object sender, EventArgs e)
        {
            _game.Name = txtGameName.Text.Trim();
            _game.Genre = txtGameGenre.Text.Trim();
            _game.Platform = cbGamePlatform.SelectedItem?.ToString();
            _game.ReleaseDate = dtpReleaseDate.Value;
            _game.PlayTime = (int)numericGamePlayTime.Value;
            _game.CoverImage = _selectedCoverImage;
            try
            {
                _gameService.Update(_game);
                MessageBox.Show("Oyun Güncellendi");
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
