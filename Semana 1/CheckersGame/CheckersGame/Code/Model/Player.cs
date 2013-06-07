using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace CheckersGame.Code
{
    public class Player
    {
        public PlayerNum PlayerNumber { get; set; }
        public Ellipse Shape { get; set; }

    }

    public enum PlayerNum
    {
        PlayerOne, PlayerTwo
    }
}
