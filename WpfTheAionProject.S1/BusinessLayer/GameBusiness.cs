using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTheAionProject.DataLayer;
using WpfTheAionProject.Models;
using WpfTheAionProject.PresentationLayer;

namespace WpfTheAionProject.BusinessLayer
{
    public class GameBusiness
    {
        GameSessionViewModel _gameSessionViewModel = new GameSessionViewModel();
        bool _newPlayer = false;
        Player _player = new Player();
        //PlayerSetupView _playerSetupView = null;

        //constructor
        public GameBusiness()
        {
            SetupPlayer();
            InstantiateAndShowView();
        }

        //**************
        private void SetupPlayer()
        {
            _player = GameData.PlayerData();
        }

        private void InstantiateAndShowView()
        {
            _gameSessionViewModel = new GameSessionViewModel(
                _player,
                GameData.InitialMessages());

            GameSessionView gameSessionView = new GameSessionView
            {
                DataContext = _gameSessionViewModel
            };
            gameSessionView.Show();
        }

    }
}
