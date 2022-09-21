using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBag
{
    public partial class SortingWindow : Form
    {
        //ACCESS TO ALL
        String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Attempts.mdf;Integrated Security=True";
        //ISSUE WITH DATETIME FROMAT
        String insertCommand = "INSERT INTO ATTEMPTS (ATTEMPTS_DATE, ATTEMPTS_TIME, ATTEMPTS_SCORE) VALUES (@A, @B, @C);";
        String readCommand = "SELECT MIN(ATTEMPTS_TIME) AS DISPLAYTIME FROM ATTEMPTS;";
        SqlConnection sqlConnection = new SqlConnection();

        Tools wrench = new Tools();

        List<string> randomCallNumbers = new List<string>();
        List<string> sortedCallNumbers = new List<string>();
        List<string> userSortedCallNumbers = new List<string>();

        //ITEMS TO ADD TO DATABASE
        int timerTick;
        int userScore;
        DateTime dateTime = DateTime.Now;

        public SortingWindow()
        {
            InitializeComponent();
        }

        //WHEN WINDOW LOADS PREFORM TASKS
        private void SortingWindow_Load(object sender, EventArgs e)
        {
            //FORCE LISTBOXS TO ALLOW DROP
            UnsortedList.AllowDrop = true;
            SortedList.AllowDrop = true;

            //START TIMER
            UserTimer.Start();

            try
            {
                //GENERATE 10 BOOKS NUMBERS FOR USER
                for (int i = 0; i < 10; i++)
                {
                    //ADDS ITEM TO LIST FOR MINIPULATION
                    randomCallNumbers.Add(wrench.GenerateDeweyItem());
                    //NUMBER GENERATOR IS NOT GOOD - NEED BREAK TO GET RANDOM VALUES
                    System.Threading.Thread.Sleep(10);
                    //ADDS ITEM TO DISPLAY
                    UnsortedList.Items.Add(randomCallNumbers[i]);
                    //WAIT AGIAN
                    System.Threading.Thread.Sleep(10);
                    //PRINT FOR DEBUG
                    //Console.WriteLine(callNumbers[i]);

                    //TIME-TO-BEAT
                    sqlConnection.ConnectionString = connectionString;
                    SqlCommand sqlCommand = new SqlCommand(readCommand, sqlConnection);
                    sqlConnection.Open();

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    //QUERIES LEAST AMOUNT OF TIME & DISPLAYS
                    sqlDataReader.Read();
                    DatabaseTimeLabel.Text = sqlDataReader["DISPLAYTIME"].ToString();

                    //CLOSE CONNECTION
                    sqlConnection.Close();
                }

                //SORT LIST USING SORT METHOD - DESIGNED FOR NUMERICAL SORT - NO DISCTENTICON BETWEEN XXX.XXX AAA and XXX.XXX AAB
                randomCallNumbers.Sort();

                //PRINT FOR DEBUG
                //foreach (string callNumber in callNumbers)
                //{
                    //Console.WriteLine(callNumber);
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //TAKE SELECTED ITEM FROM UNSORTED LIST AND COPY DATA TO SORTED LIST
        private void UnsortedList_MouseDown(object sender, MouseEventArgs e)
        {
            SortedList.DoDragDrop(UnsortedList.SelectedItem, DragDropEffects.Copy);
        }

        //CHECK DATA IS VALID, THEN COPY DATA
        private void SortedList_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //DISPLAY DATA IN SORTED LIST
        private void SortedList_DragDrop(object sender, DragEventArgs e)
        {
            SortedList.Items.Add(e.Data.GetData(DataFormats.Text));
        }

        //BUTTON UP & DOWN UNTIL DRAG IMPLEMENTED
        private void ItemUpButton_Click(object sender, EventArgs e)
        {
            //CHECK ITEM IS SELECTED
            if(SortedList.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select An Item To Move", "Note", MessageBoxButtons.OK);
            }
            else
            {
                //STORE DESIRED INDEX LOCATION
                int indexValue = SortedList.SelectedIndex - 1;

                if(indexValue < 0)
                {
                    //IF INDEX IS ZERO, DO NOTHING
                }
                else
                {
                    //STORE SELECTED ITEM
                    object selectedItem = SortedList.SelectedItem;

                    //REMOVE ITEM & REPLACE AT SAVED INDEX LOCATION
                    SortedList.Items.Remove(selectedItem);
                    SortedList.Items.Insert(indexValue, selectedItem);

                    //SELECTS CURRENT POSTION OF ITEM
                    SortedList.SetSelected(indexValue, true);
                }
            }
        }

        private void ItemDownButton_Click(object sender, EventArgs e)
        {
            //CHECK ITEM IS SELECTED
            if (SortedList.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select An Item To Move", "Note", MessageBoxButtons.OK);
            }
            else
            {
                //STORE DESIRED INDEX LOCATION
                int indexValue = SortedList.SelectedIndex + 1;

                if (indexValue >= SortedList.Items.Count)
                {
                    //IF INDEX IS ZERO, DO NOTHING
                }
                else
                {
                    //STORE SELECTED ITEM
                    object selectedItem = SortedList.SelectedItem;

                    //REMOVE ITEM & REPLACE AT SAVED INDEX LOCATION
                    SortedList.Items.Remove(selectedItem);
                    SortedList.Items.Insert(indexValue, selectedItem);

                    //SELECTS CURRENT POSTION OF ITEM
                    SortedList.SetSelected(indexValue, true);
                }
            }

        }

        //TIMER TICKS & DISPLAYS
        private void UserTimer_Tick(object sender, EventArgs e)
        {
            timerTick++;
            TimeLabel.Text = timerTick.ToString() + " Seconds";
            //PRINT FOR DEBUG
            //Console.WriteLine(timerTick);

            /*MOVE THE ADDING ITEMS TO LIST HERE TO CONSTANTLY UPDATE & COMPARE*/
            //CLEAR LIST BEFORE ADDING NEX LIST ELEMENTS
            userSortedCallNumbers.Clear();
            sortedCallNumbers.Clear();

            //ADD ITEMS TO LIST FOR MINIPULATION
            //TO INCREASE USERS POINTS ACCURACY COMPARE TO USERS OWN SORTED LIST AND NOT 10 ITEM SORTED LIST
            foreach (var item in SortedList.Items)
            {
                userSortedCallNumbers.Add(item.ToString());
                sortedCallNumbers.Add(item.ToString());

                //PRINT FOR DEBUG
                //Console.WriteLine(item.ToString());
            }

            sortedCallNumbers.Sort();

            //CHECK ITEMS ARE CORRECT THEN UPDATE SCORE
            try
            {
                userScore = wrench.CustomCheck(sortedCallNumbers, userSortedCallNumbers);
                ScoreLabel.Text = userScore.ToString();

                //REMOVES DUPLICATES
                foreach(var item in sortedCallNumbers)
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //ON COMPLETE SAVE SCORE & PRINT CERTIFICATE
        private void FinishButton_Click(object sender, EventArgs e)
        {
            //IF USER HAS 10 POINTS - COMPLETE & SAVE
            if (userScore == 10)
            {
                //STOP TIMER
                UserTimer.Stop();

                try
                {
                    //SAVE DATABASE METRICS - NEED TO INCREASE DATA INTEGERITY
                    sqlConnection.ConnectionString = connectionString;
                    SqlCommand sqlCommand = new SqlCommand(insertCommand, sqlConnection);

                    //OPEN CONNECTION
                    sqlConnection.Open();

                    //ADD VALUES OF CURRENT USER SESSION
                    sqlCommand.Parameters.AddWithValue("@A", dateTime);
                    sqlCommand.Parameters.AddWithValue("@B", timerTick);
                    sqlCommand.Parameters.AddWithValue("@C", userScore);
                    
                    //HOW MANY ROWS AFFECTED
                    int row = sqlCommand.ExecuteNonQuery();

                    //CLOSE CONNECTION
                    sqlConnection.Close();

                    //MESSAGE ON SUCCESS
                    if(row != 0)
                    {
                        MessageBox.Show("Attempt Was Recorded", "Note", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Attempt Was NOT Recorded", "Note", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //DISABLE COMPLETE BUTTON
                FinishButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("You Have NOT Reached The Requiered Score To Complete The Activity", "Note", MessageBoxButtons.OK);
            }
        }

        //UNUSED FOR NOW - REPLACED WIHT TIMER
        private void SortedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //IF USER PRESSES 'X' BRING BACK TO MAIN MENU
        private void SortingWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            //PRINT FOR DEBUG
            //Console.WriteLine("MENU");

            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();

            this.Hide();

        }

        //CLEARS SORTED LIST
        private void ClearButton_Click(object sender, EventArgs e)
        {
            SortedList.Items.Clear();
        }
    }
}
