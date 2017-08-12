using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        myButton Button = new myButton();

        public Form1()
        {
            InitializeComponent();
            makeIt();
        }

        public void makeIt()
        {
            Controls.Add( Button.makeButton(50,50,0,0));
            Controls.Add( Button.makeButton(50,50,100,100));
        }
    }
}
