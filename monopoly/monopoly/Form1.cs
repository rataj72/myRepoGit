using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monopoly
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            makeMyField();
        }

        public void makeMyField()
        {
            Field b = new Field(50,50,50,50,"6");
            Field bb = new Field(100,100,100,100,"6");
            Controls.Add(b.makeField());
            Controls.Add(bb.makeField());
        }
    }
}
