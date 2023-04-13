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

namespace LostAdventure
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;
        public Form1()
        {
            InitializeComponent();

            // Display initial message and options
            
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 2
            
            if (page == 1) 
            {
                page = 2;
                
            }
            else if (page == 2) 
            {
                page = 3;    
            }
            else if (page == 3) 
            {
                page = 10;
            }
            else if (page == 4) 
            {
              page = 5;
            }
            else if (page == 5) 
            {
             page = 6;           
            }
            else if (page == 6) 
            {
                page = 10;
            }
            else if (page == 7) 
            {
                page = 12; 
            }

            else if (page == 8)
            { 
            
            
            }
            else if (page == 9)
            {


            }
            else if (page == 10)
            {
                page = 11;

            }
            else if (page == 11)
            {


            }
            else if (page == 12)
            {
           
            }

            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    outputLabel.Text = "you walked down a hallway and ended up here";
                    option1Label.Text = "GO here";
                    option2Label.Text = "GO there";
                    break;
                case 2:
                    outputLabel.Text = "You woke up and ended up here";
                    option1Label.Text = "GO here";
                    option2Label.Text = "GO there";
                    imageBox.Image = Properties.Resources.too_late_now;
                    break;
                case 3:
                    imageBox.Image = Properties.Resources.tower;
                    option1Label.Text = "go down the shortcut";
                    break;
                case 4:
                    imageBox.Image = Properties.Resources.titleoftitleoftitle;
                    outputLabel.Text = "You need to escape";
                    break;
                case 5:
                    imageBox.Image = Properties.Resources.danger;
                    outputLabel.Text = "You're so close";
                    break;
                case 6:
                    imageBox.Image = Properties.Resources.huh;
                    SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.where_did_you_take_them);
                    outputLabel.Text = "a house";
                    break;
                case 7:
                    imageBox.Image = Properties.Resources.Please_forgive_me;
                    SoundPlayer tumbling = new SoundPlayer(Properties.Resources.h);
                    tumbling.PlayLooping();
                    SoundPlayer player = new SoundPlayer(Properties.Resources.imsorry);
                    player.PlayLooping();
                    outputLabel.Text = "the abyss";
                    break;
                case 8:
                    outputLabel.Text = "goofy goober";
                    break;
                case 9:
                    break;
                case 10:
                    imageBox.Image = Properties.Resources.hello;
                    outputLabel.Text = "I CAN`T";
                    option1Label.Text = "TURN AROUND";
                    option2Label.Text = "TURN AROUND";
                    SoundPlayer icantfeelmybones = new SoundPlayer(Properties.Resources.crying);
                    break;
                case 11:
                    imageBox.Image= Properties.Resources.you_will_fail_no_matter_what; 
                    SoundPlayer iiiiiiiii = new SoundPlayer(Properties.Resources.where_did_you_take_them);
                    outputLabel.Text = "thatisnotanoptionanymore";
                    break;
                case 12:
                    imageBox.Image = Properties.Resources.Please_forgive_me;
                    outputLabel.Text = "Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry";
                    SoundPlayer elayer = new SoundPlayer(Properties.Resources.imsorry);
                    elayer.PlayLooping();
                    break;
                case 99:
                    break;
                default:
                    break;
            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 12;

            }
            else if (page == 2)
            {
                page = 10;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 10;
            }
            else if (page == 5)
            {
                page = 10;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {

            }

            else if (page == 8)
            {


            }
            else if (page == 9)
            {


            }
            else if (page == 10)
            {
                page = 11;

            }
            else if (page == 11)
            {


            }
            else if (page == 12)
            {

            }

            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    outputLabel.Text = "you walked down a hallway and ended up here";
                    option1Label.Text = "GO here";
                    option2Label.Text = "GO there";
                    // option2Button = 
                    imageBox.Image = Properties.Resources.tower;
                    break;
                case 2:
                    outputLabel.Text = "You woke up and ended up here";
                    option1Label.Text = "GO here";
                    option2Label.Text = "GO there";
                    imageBox.Image = Properties.Resources.too_late_now;
                    break;
                case 3:
                    imageBox.Image = Properties.Resources.tower;
                    break;
                case 4:
                    imageBox.Image = Properties.Resources.titleoftitleoftitle;
                    outputLabel.Text = "You need to escape";
                    break;
                case 5:
                    imageBox.Image = Properties.Resources.danger;
                    outputLabel.Text = "You're so close";
                    break;
                case 6:
                    imageBox.Image = Properties.Resources.huh;
                    SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.where_did_you_take_them);
                    outputLabel.Text = "a house";
                    break;
                case 7:
                    imageBox.Image = Properties.Resources.Please_forgive_me;
                    SoundPlayer tumbling = new SoundPlayer(Properties.Resources.h);
                    tumbling.PlayLooping();
                    SoundPlayer player = new SoundPlayer(Properties.Resources.imsorry);
                    player.PlayLooping();
                    outputLabel.Text = "the abyss";
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                     imageBox.Image = Properties.Resources.hello;
                    outputLabel.Text = "I CAN`T";
                    option1Label.Text = "TURN AROUND";
                    option2Label.Text = "TURN AROUND";
                    break;
                case 11:
                    imageBox.Image = Properties.Resources.you_will_fail_no_matter_what;
                    SoundPlayer iiiiiiiii = new SoundPlayer(Properties.Resources.where_did_you_take_them);
                    outputLabel.Text = "thatisnotanoptionanymore";
                    break;
                case 12:
                    imageBox.Image = Properties.Resources.Please_forgive_me;
                    outputLabel.Text = "Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry Im sorry";
                    SoundPlayer clayer = new SoundPlayer(Properties.Resources.imsorry);
                    clayer.PlayLooping();
                    break;
                case 99:
                    break;
                default:
                    break;
            }
        }


        private void option1Label_Click(object sender, EventArgs e)
        {
            if (page == 1) ;
            option1Label.Text = "GO HERE";
        }

        private void imageBox_Click(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void option2Label_Click(object sender, EventArgs e)
        {
            if (page == 1) ;
            option2Label.Text = "GO THERE";
            
        }
    }
}
