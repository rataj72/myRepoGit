using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s
{
    public class Field
    {
        public Button CreateChessboardButton(int PointX, int PointY, int SizeX, int SizeY)
        {
            Button button = new Button();
            button.Size = new Size(SizeX, SizeY);
            button.Location = new Point(PointX, PointY);
            button.Click += ChessboardButtonOnClick;
            return button;
        }
        TaskCompletionSource<bool> tsc = null;

        private async void FigureButtonOnClick(object sender, EventArgs eventArgs)
        {
            var pole = (Button)sender;                  //0
            
            myItems.wherIWas[pole.Location.X / 50, pole.Location.Y / 50] = "rook";
            tsc = new TaskCompletionSource<bool>();
            await tsc.Task;
            pole.Location = new Point(myItems.whereIGoX,myItems.whereIGoY);
            //a.Location = new Point(myItems.whereIGoX[0]*50, myItems.whereIGoY[0]*50);
            myItems.flaga++;
        }

        private void ChessboardButtonOnClick(object sender, EventArgs eventArgs)
        {
            var pole = (Button)sender;          //1
                myItems.whereIGoX = pole.Location.X;
                myItems.whereIGoY = pole.Location.Y;
                tsc?.TrySetResult(true);
            
            myItems.flaga++;
        }

        public Button CreateFigureButton(int PointX, int PointY, int SizeX, int SizeY)
        {
            Button button = new Button();
            button.Size = new Size(SizeX, SizeY);
            button.Location = new Point(PointX, PointY);
            button.BringToFront();
            button.Click += FigureButtonOnClick;
            return button;
        }



/*
        private void FigureButtonOnClick(object sender, EventArgs eventArgs)
        {
            var figura = (Button)sender;
            if (myItems.flaga % 2 == 0)
            {
                myItems.wherIWas[figura.Location.X / 50, figura.Location.Y / 50] = "rook";
                figura.();
            }
            else
            {
                myItems.whereIGo[figura.Location.X / 50, figura.Location.Y / 50] = "rook";
                figura.

            }

        }*/
    }
}