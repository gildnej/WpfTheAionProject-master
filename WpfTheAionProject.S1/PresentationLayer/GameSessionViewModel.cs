using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTheAionProject.Models;

namespace WpfTheAionProject.PresentationLayer
{
   public class GameSessionViewModel
    {

        #region Fields


        #endregion

        #region Properties
        public Player Player { get; set; }
        public List<string> Messeges { get; set; }



        #endregion

        #region Constructors
        public GameSessionViewModel()
        {
            
        }
        public GameSessionViewModel(
            Player player,
            List<string> initalMessages)
        {
            Player = player;
            Messeges = initalMessages;
        }
        #endregion

        #region Methods

        #endregion
    }
}
