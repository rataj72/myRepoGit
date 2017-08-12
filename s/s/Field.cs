using System;
using System.Drawing;
using System.Windows.Forms;

namespace s
{
    public class Field : Button
    {
        public Button CreateButton(int SizeX, int SizeY, int PointX, int PointY)
        {
            Button button = new Button();
            button.Size = new Size(SizeX,SizeY);
            button.Location = new Point(PointX,PointY);
            button.Click += ButtonOnClick;
            Controls.Add(button);
            return button;
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var Figura = (Button) sender;
            Figura.Text = "W";
            if (myItems.flaga % 2 == 0)
            {
                myItems.wherIWas[Figura.Size.Width / 50 - 1, Figura.Size.Height / 50 - 1] = new Rook();
                Figura = new Button();
                Figura = CreateButton(Figura.Size.Width, Figura.Size.Height, 50, 50);
                Figura.Text = "";
            }
            else
            {
                myItems.whereIGo[Figura.Size.Width / 50 - 1, Figura.Size.Height / 50 - 1] = new Rook();
                Figura.Location = new Point(Figura.Size.Width, Figura.Size.Height);
                Figura.Size = new Size(50,50);
            }
            myItems.flaga++;


        }
    }
}