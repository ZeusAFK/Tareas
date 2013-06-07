using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CheckersGame.Code
{
    public class GameEngine
    {
        /// <summary>
        /// Método que obtiene una instancia 'Player' a partir de un Ellipse
        /// </summary>
        /// <param name="ellipse">Instancia Ellipse que será representada como clase 'Player'</param>
        /// <returns>Instancia Player</returns>
        public static Player GetMovingPlayer(Ellipse ellipse)
        {
            Player currentPlayer = new Player();
            // Se obtiene el color del ellipse
            SolidColorBrush brush = ellipse.Fill as SolidColorBrush;
            // Color que se comparará con el del Ellipse
            Color colorToCompare = new Color()
            {
                A=255,
                B=170,
                G=178,
                R=32
            };

            if (brush.Color == colorToCompare)
            {
                // Es el jugador 1
                currentPlayer.PlayerNumber = PlayerNum.PlayerOne;
            }
            else
            {
                // Es el jugador 2
                currentPlayer.PlayerNumber = PlayerNum.PlayerTwo;
            }
            // Se guarda el Ellipse en la instancia Player
            currentPlayer.Shape = ellipse;

            return currentPlayer;
        }
    }
}
