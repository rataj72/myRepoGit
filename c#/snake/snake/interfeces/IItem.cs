using System.Windows.Forms;

namespace snake.interfeces
{
    public interface IItem<T> : IBase
    {
        T MakeButton(Form1 f1, int posX, int posY);
    }
}