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
    public partial class GameList : UserControl
    {
        private readonly IGameService _gameService;
        public GameList()
        {
            _gameService = new GameService();
            InitializeComponent();
        }

        public void LoadGames()
        {
            var games = _gameService.GetAll();
            dgvGames.DataSource = games;
            dgvGames.Columns["Id"].Visible = false;
        }

        private void btnGameList_Click(object sender, EventArgs e)
        {
            LoadGames();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGames.SelectedRows.Count > 0)
            {
                int id = (int)dgvGames.SelectedRows[0].Cells["Id"].Value;
                string name = dgvGames.SelectedRows[0].Cells["Name"].Value.ToString();

                if (MessageBox.Show($"{name} isimli oyunu silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _gameService.Delete(id);
                        LoadGames();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Satır Seçmelisiniz");
            }
        }

        private void btnUpdateGame_Click(object sender, EventArgs e)
        {
            if (dgvGames.SelectedRows.Count > 0)
            {
                int id = (int)dgvGames.SelectedRows[0].Cells["Id"].Value;

                EditGame editGame = new EditGame(id);
                editGame.ShowDialog();
                LoadGames();
                LoadGenres();
            }

        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            AddGameForm addGameForm = new AddGameForm(this);
            addGameForm.ShowDialog();
        }
        public void LoadGenres()
        {
            var genres = _gameService.GetGenres();
            cbGenre.Items.Clear();
            cbGenre.Items.AddRange(genres.ToArray());

        }

        private void GameList_Load(object sender, EventArgs e)
        {
            LoadGenres();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = string.Empty;
            if(!string.IsNullOrWhiteSpace(txtName.Text))
                searchTerm = txtName.Text;
            if(cbPlatform.SelectedItem is not null)
                searchTerm = cbPlatform.SelectedItem.ToString();
            if(cbGenre.SelectedItem is not null)
                searchTerm = cbGenre.SelectedItem.ToString();

            var games= _gameService.Search(searchTerm);
            dgvGames.DataSource = games;

        }
    }
}
