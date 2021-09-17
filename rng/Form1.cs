using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rng
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")] //Used to hide carat blinking when typing in the cheat textbox
        static extern bool HideCaret(IntPtr hWnd); //Used in accordance with above, for the cheat textbox

        bool cheatOn = false; //Used to determine whether the program should show the cheat value or not

        public Form1()
        {
            InitializeComponent();
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void From_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Happens when the 'generate' button is clicked
        {
            if (btnGenerate.Focus()) //Prevents the 'generate' button from getting a blue border when it has been selected
                label1.Focus();      //This is useful as the blue border disappears when a hidden cheat interface is clicked, removing the illusion of a normal program

            if (cheatOn)
            {
                string cheatNumber = cheatText.Text; //Reads input from the hidden cheat textbox
                shownNumber.Text = cheatNumber;
                cheatOn = false;
                cheatText.Text = null;
            }

            else
            {
                if (fromText.Text == null | toText.Text == null)
                {
                    shownNumber.Text = "Enter a valid range.";
                }

                else
                {
                    int range1 = int.Parse(fromText.Text); //Reads the input value in the 'from' textbox
                    int range2 = int.Parse(toText.Text); //Reads from the 'to' textbox
                    int randomNumber;
                    int upperRange = Math.Max(range1, range2) + 1; //Takes the highest number, +1 is used to make sure that the highest number can be hit in the rng
                    int lowerRange = Math.Min(range1, range2);
                    Random rand = new Random();

                    randomNumber = rand.Next(lowerRange, upperRange);
                    shownNumber.Text = randomNumber.ToString();
                }                
            }
        }

        private void loadCheat_Click(object sender, EventArgs e)
        {
            cheatOn = true;
        }

        private void cheatText_TextChanged(object sender, EventArgs e)
        {
            HideCaret(cheatText.Handle); //Used to hide flashing | when typing
            
            //Makes sure that the cursor is shown even if the program tries to hide it
            if (Cursor.Current == null)
            {
                Cursor.Current = Cursors.Default; 
            }
        }
    }
}
