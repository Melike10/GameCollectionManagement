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
    public partial class AddGame : UserControl
    {
        private readonly IGameService _gameService;
        private readonly GameList _gameList;
        public AddGame()
        {
            _gameService = new GameService();
            InitializeComponent();
        }

        public AddGame(GameList gameList)
        {
            _gameService = new GameService();
            InitializeComponent();
            _gameList = gameList;
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Name = txtGameName.Text.Trim();
            game.Genre = txtGameGenre.Text.Trim();
            game.Platform = cbGamePlatform.SelectedItem?.ToString();
            game.ReleaseDate = dtpReleaseDate.Value;
            game.PlayTime = (int)numericGamePlayTime.Value;
            game.CoverImage = _selectedCoverImage;
            try
            {
               
                _gameService.Add(game);
                MessageBox.Show("Kayıt başarılı şekilde oluştu");
                if(_gameList is not null)
                {
                    _gameList.LoadGames();
                    _gameList.LoadGenres();
                    ((Form)Parent.Parent).Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

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
    }
}
