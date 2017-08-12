using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class myButton
    {
        public Button makeButton(int x, int y, int a , int b)
        {
            Button button = new Button();
            button.Size = new Size(x,y);
            button.Location = new Point(a,b);
            button.BackColor =Color.BlueViolet;
            button.Click += ButtonOnClick;
            return button;
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var x = (Button) sender;
            x.BackColor = Color.Aqua;
            x.Location = new Point(100,100);
        }
    }
}