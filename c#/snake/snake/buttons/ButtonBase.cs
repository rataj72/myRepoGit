using System.Drawing;
using System.Windows.Forms;
using snake.interfeces;

namespace snake.buttons
{
    public abstract class ButtonBase : IItem<Button>
    {
        public const int sizeX = 30;
        public const int sizeY = 30;

        public static int basePositionX = 30;
        public static int basePositionY = 30;

        public abstract Button MakeButton(Form1 form1, int posX, int posY);
    }
}