using System.Drawing;
using System.Windows.Forms;

namespace s
{
    public class Field : Button
    {
        public Button CreateButton(int SizeX, int SizeY, int PointX, int PointY, Color Color)
        {
            Button button = new Button();
            button.Size = new Size(SizeX,SizeY);
            button.Location = new Point(PointX,PointY);
            button.BackColor = Color;
            Controls.Add(button);
            return button;
        }
        
    }
}