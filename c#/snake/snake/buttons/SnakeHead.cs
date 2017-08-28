using System;
using System.Drawing;
using System.Windows.Forms;
using snake.interfeces;

namespace snake.buttons
{
    public class SnakeHead : ButtonBase
    {
        private Form1 _f1;
        Timer t = new Timer();

        public SnakeHead(Form1 f1, int posX, int posY)
        {
            _f1 = f1;
            MakeButton(f1, posX, posY);
        }

        public override Button MakeButton(Form1 f1, int posX, int posY)
        {
            Button button = new Button();
            button.Size = new Size(sizeX,sizeY);
            button.Location = new Point(basePositionX,basePositionY);
            button.BackColor = Color.Aqua;
            MyTable.TableButtons[0] = button;
            f1.Controls.Add(button);

            t.Start();
            t.Interval = 500;
            t.Tick += TOnTick;
            
            //button.Dispose();
            return button;
        }

        private void TOnTick(object sender, EventArgs eventArgs)
        {
            MyTable.TableButtons[0].Location=new Point(basePositionX+=15,basePositionY);
            
        }
    }
}