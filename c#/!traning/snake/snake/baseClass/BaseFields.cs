using System;
using System.Drawing;
using System.Windows.Forms;
using snake.i;

namespace snake.baseClass
{
    public class BaseFields : IField<int,int,int,Button>
    {
        public Button makeButton(int name, int pointX, int pointY, int sizeX = 50, int sizeY = 50)
        {
            Button button = new Button();
            button.Name = name.ToString();
            button.Size = new Size(sizeX, sizeY);
            button.Location = new Point(pointX, pointY);
            button.Click += ChessboardButtonOnClick;
            return button;
        }

        public virtual void ChessboardButtonOnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}