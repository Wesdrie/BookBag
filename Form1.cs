using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBag
{
    public partial class MenuWindow : Form
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        //ON BUTTON CLICK FOR NAVIGATION, OPEN FORM2 & HIDES FORM1
        private void SortButton_Click(object sender, EventArgs e)
        {
            //PRINT FOR DEBUG
            //Console.WriteLine("SORTING GAME");

            SortingWindow sortingWindow = new SortingWindow();
            sortingWindow.Show();

            this.Hide();
        }

        private void MenuWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ENSURE APPLICATION ENDS
            System.Windows.Forms.Application.Exit();
        }

        private void NotesButton_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "C:\\BookBag\\TextFile1.txt");
        }
    }
}
