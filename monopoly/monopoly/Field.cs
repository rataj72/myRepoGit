using System;
using System.Drawing;
using System.Windows.Forms;

namespace monopoly
{
    public class Field
    {
        public string NameField;
        public int SizeX;
        public int SizeY;
        public int PointX;
        public int PointY;

        public Field(int pointX, int pointY, int sizeX, int sizeY, string name)
        {
            PointX = pointX;
            PointY = pointY;
            SizeX = sizeX;
            SizeY = sizeY;
            NameField = name;

           
        }

        public Button makeField()
        {
            Button button = (Button) new Button();
            button.Location = new Point(PointX,PointY);
            button.Size = new Size(SizeX,SizeY);
            button.Name = NameField;
            button.Click +=ButtonOnClick;
            return button;
            
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var a = (Button) sender;
            var b = a.GetType();
            a.BackColor = Color.Aqua;
            a.Location = new Point(100,100);
            a.BringToFront();
        }
    }
}