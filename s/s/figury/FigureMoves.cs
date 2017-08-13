using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s
{
    public class FigureMoves
    {
        TaskCompletionSource<bool> tsc = null;
        Rook Rook = new Rook();

        public async void FigureButtonOnClick(object sender, EventArgs eventArgs)
        {
            var figure = (Button)sender;
            myItems.whereIamX = figure.Location.X;
            myItems.whereIamY = figure.Location.Y;
            myItems.whatsMyName = figure.Name;
            //Rook.makeItShine(myItems.whereIamX, myItems.whereIamY);
            tsc = new TaskCompletionSource<bool>();
            await tsc.Task;
            figure.Location = new Point(myItems.whereIGoX, myItems.whereIGoY);
        }

        public void ChessboardButtonOnClick(object sender, EventArgs eventArgs)
        {
            var figure = (Button)sender;
            Rook.MoveH(figure);
            tsc?.TrySetResult(true);
        }
    }
}