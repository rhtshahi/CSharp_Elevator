namespace ElevatorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timerOpen_Tick(object sender, EventArgs e)
        {
         
            if (pictureBoxElevator.Location.Y >= 382)
            {
                pictureBoxDoorLeftDown.Location = new Point(pictureBoxDoorLeftDown.Location.X - 1, pictureBoxDoorLeftDown.Location.Y);
                pictureBoxDoorRightDown.Location = new Point(pictureBoxDoorRightDown.Location.X + 1, pictureBoxDoorRightDown.Location.Y);
                timerOpen.Enabled = true;

                if (pictureBoxDoorLeftDown.Location.X<=136 && pictureBoxDoorRightDown.Location.X >= 297)
                {
                    timerOpen.Enabled = false;
                }
            }

            else if(pictureBoxElevator.Location.Y == 92)
            {
                pictureBoxDoorLeftUp.Location = new Point(pictureBoxDoorLeftUp.Location.X - 1, pictureBoxDoorLeftUp.Location.Y);
                pictureBoxDoorRightUp.Location = new Point(pictureBoxDoorRightUp.Location.X + 1, pictureBoxDoorRightUp.Location.Y);
                timerOpen.Enabled = true;

                if (pictureBoxDoorLeftUp.Location.X <= 136 && pictureBoxDoorRightUp.Location.X >= 297)
                {
                    timerOpen.Enabled = false;
                    
                }

            }
      
            
            btnOpen.Enabled = false;
            btnClose.Enabled = true;


        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (timerClose.Enabled == false)
            {
                timerOpen.Enabled = true;
            }
            
            /*if (pictureBoxDoorLeftUp.Location.X <= 136 && pictureBoxDoorRightUp.Location.X >= 297)
            {
                timerOpen.Enabled = false;
            }*/

        }

        private void timerClose_Tick(object sender, EventArgs e)
        {

            if (pictureBoxElevator.Location.Y >= 382)
            {
                pictureBoxDoorLeftDown.Location = new Point(pictureBoxDoorLeftDown.Location.X + 1, pictureBoxDoorLeftDown.Location.Y);
                pictureBoxDoorRightDown.Location = new Point(pictureBoxDoorRightDown.Location.X - 1, pictureBoxDoorRightDown.Location.Y);
                //timerClose.Enabled = true;

                //pictureBoxDoorLeftDown.Location.X >= 190 && pictureBoxDoorRightDown.Location.X <= 243

                if (pictureBoxDoorLeftDown.Location.X == 217)
                {
                    timerClose.Enabled = false;
                }
            }

            else if (pictureBoxElevator.Location.Y == 92)
            {
                pictureBoxDoorLeftUp.Location = new Point(pictureBoxDoorLeftUp.Location.X + 1, pictureBoxDoorLeftUp.Location.Y);
                pictureBoxDoorRightUp.Location = new Point(pictureBoxDoorRightUp.Location.X - 1, pictureBoxDoorRightUp.Location.Y);
                //timerClose.Enabled = true;

                if (pictureBoxDoorLeftUp.Location.X == 217)
                {
                    timerClose.Enabled = false;

                }

            }



            btnOpen.Enabled = true;
            btnClose.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (timerOpen.Enabled == false)
            {
                timerClose.Enabled = true;
            }
            
            /*if (pictureBoxDoorLeftDown.Location.X >= 190 && pictureBoxDoorRightDown.Location.X <= 243)
            {
                timerClose.Enabled = false;
            }*/
        }
    }
}