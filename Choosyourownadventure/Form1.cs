using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Choosyourownadventure
{
    public partial class Form1 : Form
    {
        int page = 1;
        SoundPlayer soundPlayer = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();

            displayPage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 9;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 13;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 18;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 20)
            {
                page = 1;
            }

            displayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //if statements
            if (page == 1)
            {
                Random randomGenrator = new Random();
                int randomValue = randomGenrator.Next(1, 101);

                if (randomValue > 75)
                {
                    page = 8;
                }
                else
                {
                    page = 3;

                }

            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 21;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 10;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 14;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                page = 21;
            }
            else if (page == 12)
            {
                page = 21;
            }
            else if (page == 13)
            {
                page = 17;
            }
            else if (page == 14)
            {
                page = 21;
            }
            else if (page == 15)
            {
                Random randomGenrator = new Random();
                int randomValue = randomGenrator.Next(1, 101);

                if (randomValue > 60)
                {
                    page = 19;
                }
                else
                {
                    page = 20;

                }
            }
            else if (page == 16)
            {
                page = 21;
            }
            else if (page == 17)
            {
                page = 21;
            }
            else if (page == 18)
            {
                page = 21;
            }
            else if (page == 19)
            {
                page = 21;
            }
            else if (page == 20)
            {
                page = 21;
            }

            displayPage();

        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            Visible = true;
            if (page == 13)
            {
                page = 16;
            }

            displayPage();
        }


        public void displayPage()
        {
            switch (page)
            {
                case 1:
                 
                    soundPlayer = new SoundPlayer(Properties.Resources.silent_hill_background);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.pyramind_head;

                   outPutlable.Text = "You wake up in the middle of a road. " +
                        "Looking around you see a sign that reads ''Silent Hill,Main'' ";
                        
                    option1Lable.Text = "walk forwards (up the road)?";
                    option2Lable.Text = "walk back (down the road)?";
                    break;
                case 2:

                    soundPlayer = new SoundPlayer(Properties.Resources.silent_hill_background);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.silent_hil_town;

                    outPutlable.Text = "Going forwards you eventually enter a town. You see two paths, " +
                        "do you go down the path in front of you, or the one to the right? ";

                    option1Lable.Text = "Go forward?";
                    option2Lable.Text = "Go right?";
                    break;
                case 3:

                    soundPlayer = new SoundPlayer(Properties.Resources.silent_hill_background);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.pyramind_head;

                   outPutlable.Text = "You keep walking south down the road, and over and over again you come back to the sign," +
                        " you eventually die of exhaustion, play again?";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    break;
                case 4:

                    soundPlayer = new SoundPlayer(Properties.Resources.silent_hill_background);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.hospital;

                    outPutlable.Text = "Going right you eventually encounter a hospital, do you go in?";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    break;
                case 5:

                    soundPlayer = new SoundPlayer(Properties.Resources.silent_hill_background);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.silent_hill_elementry_school;

                    outPutlable.Text = "Going forwards you eventually encounter an old high school, do you decide to go in?";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    break;
                case 6:

                    soundPlayer = new SoundPlayer(Properties.Resources.radio_interference);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.silent_hill_2_remake_nurse;

                    outPutlable.Text = "Entering the hospital the door slams behind you causing these puppet like nurses" +
                        " to rush towards you ripping you apart, you die cold and alone. play again? ";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    break;
                case 7:

                    soundPlayer = new SoundPlayer(Properties.Resources.silent_hill_background);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.hospital;

                    outPutlable.Text = "Deciding to not enter the hospital you walk away tripping on a rock hitting your head, play again?";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    break;
                case 8:

                    soundPlayer = new SoundPlayer(Properties.Resources.silent_hill_background);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.pyramind_head;

                    outPutlable.Text = "Going south the fog dissipates eventually leading you to your freedom, play again?";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    break;
                case 9:

                    soundPlayer = new SoundPlayer(Properties.Resources.Warning_siren);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.silent_hill_school_gym;

                    outPutlable.Text = "Deciding to enter the school it is immediately apparent that no one has been here in ages. Looking around you enter a gym which almost looks like it was set for a promb, though it looks like very one just dissapperad. " +
                        "After some time you reach the second floor as you do a siren which almost sounds like a fire trucks wails outside though nothing's there," +
                        " do you want to investigate farther.";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    break;
                case 10:

                    soundPlayer = new SoundPlayer(Properties.Resources.radio_interference);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.gaint_bugs;

                    outPutlable.Text = "Deciding not to go into the school, " +
                        "you hear a screech from behind, as these giant bugs rush towards you in a swarm, do you run?";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    break;
                case 11:

                    soundPlayer = new SoundPlayer(Properties.Resources.radio_interference);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.Pryamind_head_and_bugs;


                    outPutlable.Text = "Running from the bugs you eventually reach a church, but just before you reach the church steps a man with a pyramid on his head cleaves you in half, " +
                        "before everything goes black you see someone peek their head out the church doors just to stare, play again?";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    break;
                case 12:

                    soundPlayer = new SoundPlayer(Properties.Resources.radio_interference);
                    soundPlayer.Play();



                    outPutlable.Text = "Deciding not to run you except your fate that it's likely you'll never get home," +
                        " falling to your knees you let the bugs swarm you, play again?";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    break;
                case 13:

                    soundPlayer = new SoundPlayer(Properties.Resources.radio_interference);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.pryamind;

                    outPutlable.Text = "Deciding to investigate further you exit the room only for what seems to be a giant meat cleaver" +
                        " to get caught in the door way above your head. do you run, fight or freeze?";

                    option1Lable.Text = "Run?";
                    option2Lable.Text = "Fight?";
                    option3Lable.Text = "Freez?";
                    option3Button.Visible = true;

                    break;
                case 14:

                    soundPlayer = new SoundPlayer(Properties.Resources.radio_interference);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.nightmare;

                    outPutlable.Text = "Deciding not to investigate further you turn away from the window, " +
                        "only for the world around you to be warped as everything has been covered in a rust-like coating." +
                        " This causes you to rush out of the room only for you to fall, the last thing you see before blacking out is a man with a pyramid headed" +
                        " dragging you away with no lower body. play again?";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    option3Lable.Text = "";
                    option3Button.Visible = false;
                    break;
                case 15:

                    soundPlayer = new SoundPlayer(Properties.Resources.radio_interference);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.nightmare;

                    outPutlable.Text = "Deciding to run for your life you duck under him and you run down the hallway, " +
                        "as you do the world around begins to become warped as everything has been covered in a rust-like coating, " +
                        "continuing to run down the hall you see the main hall is covered in wire with a small hole to the side, and the other is a door that leads around it. which do you pick? ";

                    option1Lable.Text = "Class room door?";
                    option2Lable.Text = "Main hall?";
                    option3Lable.Text = "";
                    option3Button.Visible = false;
                    break;
                case 16:

                    soundPlayer = new SoundPlayer(Properties.Resources.radio_interference);
                    soundPlayer.Play();



                    outPutlable.Text = "You sit there frozen, confused the pyramid headed man pokes you before shrugging and leaving, " +
                        "turns out you were so shocked you had a heart attack and died on the spot. Play again?";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    option3Lable.Text = "";
                    option3Button.Visible = false;
                    break;
                case 17:

                    soundPlayer = new SoundPlayer(Properties.Resources.radio_interference);
                    soundPlayer.Play();



                    outPutlable.Text = "Deciding to fight this man you punch him in the torso hurting your hand so much that you have to take a second to recover, " +
                        "this was enough time for them to unwedge their giant meat cleaver from the door frame and attack you cutting you in two. Play again?  ";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    option3Lable.Text = "";
                    option3Button.Visible = false;
                    break;
                case 18:

                    soundPlayer = new SoundPlayer(Properties.Resources.pulses);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.classroom;

                    outPutlable.Text = "Deciding to duck into the room, " +
                        "you realize that the door leading out of the room is locked, " +
                        "looking back the pryamind headed man is already at the door, and theres no way to get passed him, play again? ";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    option3Lable.Text = "";
                    option3Button.Visible = false;
                    break;
                case 19:

                    soundPlayer = new SoundPlayer(Properties.Resources.pulses);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.nightmare;

                    outPutlable.Text = "Deciding to duck though the hole in the wire, you successfully get though with minimal scratching. " +
                        "Continuing to run you burst out the front doors of the school with the pyramid headed man on your heel,franticly look around you  " +
                        "set eyes on small bar. Hiding in the bar you hear the man walk by covering your mouth hoping he wouldn't find you, " +
                        "you peek over the edge only to meet your own face, but with the body of the pryamide headed man. Play again?";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    option3Lable.Text = "";
                    option3Button.Visible = false;
                    break;
                case 20:

                    soundPlayer = new SoundPlayer(Properties.Resources.radio_interference);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.nightmare;

                    outPutlable.Text = "Deciding to try and duck through the hole in the wire, you get caught on the wire looking back you see the pyramid headed man getting closer, " +
                        "in your struggle to get free the wire digs deeper into your skin causing you to slowly bleed out. play again?  ";

                    option1Lable.Text = "Yes?";
                    option2Lable.Text = "No?";
                    option3Lable.Text = "";
                    option3Button.Visible = false;
                    break;
                case 21:

                    soundPlayer = new SoundPlayer(Properties.Resources.silent_hill_background);
                    soundPlayer.Play();

                    BackgroundImage = Properties.Resources.pyramind_head;

                    outPutlable.Text = "Thank you for playing ";

                    option1Lable.Text = "...";
                    option2Lable.Text = "...";
                    option3Lable.Text = "";
                    option3Button.Visible = false;
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
