using System.Windows.Forms;

namespace s
{
    public class Rook : Handler                                                         // brak ograniczenia!!! można skakać przez figury
    {
        public override void MoveH(object sender)
        {
            var rookSender = (Button)sender;
            if (myItems.flag %2 == 0 && myItems.whatsMyName.Substring(0, 5) == "White")           //white move
            {
                AllRocks(rookSender);
            }
            if (myItems.flag % 2 == 1 && myItems.whatsMyName.Substring(0, 5) == "Black")           //black move
            {
                AllRocks(rookSender);
            }
            //else dont move we have a problem
        }

        private void AllRocks(Button rookSender)
        {
            if (myItems.whatsMyName.Substring(5, 4) == "ROOK")
            {
                for (int x = 0; x < 9; x++)
                {
                    if (rookSender.Location.X / 50 == x && myItems.whereIamY == rookSender.Location.Y)
                    {
                        myItems.whereIGoX = rookSender.Location.X;
                        myItems.whereIGoY = rookSender.Location.Y;
                        myItems.flag++;
                        break;
                    }
                    if (rookSender.Location.Y / 50 == x && myItems.whereIamX == rookSender.Location.X)
                    {
                        myItems.whereIGoX = rookSender.Location.X;
                        myItems.whereIGoY = rookSender.Location.Y;
                        myItems.flag++;
                        break;
                    }
                    else
                    {
                        myItems.whereIGoX = myItems.whereIamX;
                        myItems.whereIGoY = myItems.whereIamY;
                    }
                }
            }
        }

        /*public void makeItShine(int x, int y)
        {
            if (myItems.whatsMyName.Substring(5, 4) == "ROOK")
            {

            }
        }*/
    }
}