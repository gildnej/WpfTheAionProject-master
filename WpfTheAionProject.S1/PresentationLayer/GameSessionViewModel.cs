using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTheAionProject.Models;

namespace WpfTheAionProject.PresentationLayer
{
    class GameSessionViewModel
    {



        #region Fields
        private Player _player;
        private List<string> _messeges;


        #endregion

        #region Properties
        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }
        public List<string> Messeges
        {
            get { return _messeges; }
            set { _messeges = value; }
        }



        #endregion

        #region Constructors
        public GameSessionViewModel()
        {
            
        }
        public GameSessionViewModel(
            Player player,
            List<string> initalMessages)
        {
            _player = player;
            _messeges = initalMessages;
        }
        #endregion

        #region Methods

        #endregion
    }
}
