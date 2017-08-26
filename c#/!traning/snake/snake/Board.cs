using System.Drawing;
using System.Windows.Forms;
using snake.baseClass;

namespace snake
{
    public class Board
    {
        public int sizeX;
        public int sizeY;

        public Board(int sizeX, int sizeY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            makeBoard();
        }

        BaseFields bf = new BaseFields();

        public void makeBoard()
        {
            for (int i = 0; i < sizeY; i++)
            {
                for (int j = 0; j < sizeX; j++)
                {
                    Button buton = bf.makeButton(i * 10 + j, j * 50, i * 50);
                    buton.BackColor = Color.CadetBlue;
                    this.Controls.Add(buton);
                }
            }
            
        }
    }
}