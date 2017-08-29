using System.Net.Security;
using System.Windows.Forms;

namespace snake.i
{
    public interface IField<T,T1,T2, T3>
    {
        T3 makeButton(T2 name,T pointX, T pointY, T1 sizeX, T1 sizeY);
    }
}