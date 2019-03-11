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
        Player _player = new Player();
        List<string> _messages = new List<string>();

        //constructor
        public GameBusiness()
        {
            InitializeDataSet();
            InstantiateAndShowView();
        }

        //**************
        public void InitializeDataSet()
        {
            _player = GameData.PlayerData();
            _messages = GameData.InitialMessages();
        }

        public void InstantiateAndShowView()
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
