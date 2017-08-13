﻿using System;
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
                    Button button = field.CreateChessboardButton(j * 50, i * 50, 50, 50);
                    button.BackColor = color;
                    Controls.Add(button);
                    licznik++;
                }
            }
        }

        public void makeFigures()
        {
            
            Button Rook1 = field.CreateFigureButton(0, 0, 50, 50,"WhiteROOK");
            Rook1.BackgroundImage = Image.FromFile(@"C:\Users\piotr\Desktop\grafika_system\king.png");

            Button figura2 = field.CreateFigureButton(400, 400, 50, 50,"BlackROOK");
            figura2.BackgroundImage = Image.FromFile(@"C:\Users\piotr\Desktop\grafika_system\king.png");


            Controls.Add(Rook1);
            Controls.Add(figura2);
        }
    }
}
