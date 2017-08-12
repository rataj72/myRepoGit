using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s
{
    public partial class Form1 : Form
    {
        Field field = new Field();

        public Form1()
        {
            InitializeComponent();
            
            makeIt();
        }

        public void makeIt()
        {
            int licznik = 0;
            Color color =new Color();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (licznik % 2 == 0)
                    {
                         color = Color.White;
                    }
                    else
                    {
                        color = Color.Black;
                    }
                    licznik++;
                    Button button = field.CreateButton(j * 50, i * 50, 50, 50);
                    button.BackColor = color;
                    Controls.Add(button);
                }
            }
        }
    }
}
