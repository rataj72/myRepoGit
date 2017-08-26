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
            makeFigures();
            makeChessBoard();
        }

        public void makeChessBoard()
        {
            int licznik = 0;
            Color color =new Color();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (licznik % 2 == 0)
                    {
                         color = Color.White;
                    }
                    else
                    {
                        color = Color.Black;
                    }
                    Button button = field.CreateChessboardButton(j * 50, i * 50, 50, 50);
                    button.BackColor = color;
                    Controls.Add(button);
                    licznik++;
                }
                licznik++;
            }
        }

        public void makeFigures()
        {
            Button Rook1 = field.CreateFigureButton(0, 0, 50, 50,"WhiteROOK");
            Rook1.BackgroundImage = Image.FromFile(@"C:\Users\piotr\Desktop\myRepoGit\s\s\szachuFigury\rW.png");
            Controls.Add(Rook1);
            myItems.allMyFigure[0, 0] = "WhiteROOK1";

            Button Rook3 = field.CreateFigureButton(350, 0, 50, 50, "WhiteROOK");
            Rook3.BackgroundImage = Image.FromFile(@"C:\Users\piotr\Desktop\myRepoGit\s\s\szachuFigury\rW.png");
            Controls.Add(Rook3);
            myItems.allMyFigure[7, 0] = "WhiteROOK2";

            Button Rook2 = field.CreateFigureButton(350, 350, 50, 50,"BlackROOK");
            Rook2.BackgroundImage = Image.FromFile(@"C:\Users\piotr\Desktop\myRepoGit\s\s\szachuFigury\rB.png");
            Controls.Add(Rook2);
            myItems.allMyFigure[7,7] = "BlackROOK1";

            Button Rook4 = field.CreateFigureButton(0, 350, 50, 50,"BlackROOK");
            Rook4.BackgroundImage = Image.FromFile(@"C:\Users\piotr\Desktop\myRepoGit\s\s\szachuFigury\rB.png");
            Controls.Add(Rook4);
            myItems.allMyFigure[0,7] = "BlackROOK2";


            
            
        }

        public void makeItShimeForMe()
        {
            
        }
    }
}
