using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s
{
    public class Field
    {
        FigureMoves Moves = new FigureMoves();

        public Button CreateChessboardButton(int PointX, int PointY, int SizeX, int SizeY)
        {
            Button button = new Button();
            button.Size = new Size(SizeX, SizeY);
            button.Location = new Point(PointX, PointY);
            button.Click += Moves.ChessboardButtonOnClick;
            return button;
        }
        
        public Button CreateFigureButton(int PointX, int PointY, int SizeX, int SizeY, string name)
        {
            Button button = new Button();
            button.Name = name;
            button.Size = new Size(SizeX, SizeY);
            button.Location = new Point(PointX, PointY);
            button.BringToFront();
            button.Click += Moves.FigureButtonOnClick;
            return button;
        }
    }
}