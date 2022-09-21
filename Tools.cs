using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBag
{
    internal class Tools
    {
        //GENERATES DEWEY DECIMAL ITEM FORMAT(XXX.XXX XXX) - NEED TO CHECK FOR DUPLICATES
        public String GenerateDeweyItem()
        {
            Random random = new Random();
            List<String> characters = new List<String>();

            int valueOne;
            char valueTwo;
            String valueThree, deweyValue;

            //3 RANDOM NUMBERS
            for (int i = 0; i < 3; i++)
            {
                characters.Add(random.Next(0, 9).ToString());
            }

            //DOT SEPERATOR
            characters.Add(".");

            //3 RANDOM NUMBERS
            for (int y = 0; y < 3; y++)
            {
                characters.Add(random.Next(0, 9).ToString());
            }

            //SPACE SEPERATOR
            characters.Add(" ");

            //3 RANDOM NUMBERS CONVERT TO CHARACTERS
            for (int x = 0; x < 3; x++)
            {
                valueOne = random.Next(65, 90);
                valueTwo = (char)valueOne;
                characters.Add(valueTwo.ToString());
            }

            //JOIN LIST AS A SIGNLE STRING VALUE
            deweyValue = String.Join("", characters);

            return deweyValue;
        }

        //CUSTOM SORT METHOD FOR CALLNUMBERS
        public void CustomSort()
        {
            //COULD USE DISCTIONARY TO STORE PERPARED VALUES< THEN ASSIGN VALUE AS GREATER OR LESS THAN
        }

        //CHECKS TWO LISTS TO CONFIRM IF LISTS ARE CORRECT
        public int CustomCheck(List<String> controlList, List<String> userList)
        {
            List<int> checkList = new List<int>();
            int valueOne = 0;

            checkList.Clear();

            //INCASE OF USER INPUT ERROR USE USERLIST LENGTH
            for(int i = 0; i < userList.Count; i++)
            {
                if(controlList[i].Equals(userList[i]))
                {
                    checkList.Add(1);
                    //Console.WriteLine("C: " + controlList[i]);
                    //Console.WriteLine("I: " + userList[i]);
                }
                else
                {
                    checkList.Add(0);
                    //Console.WriteLine("C: " + controlList[i]);
                    //Console.WriteLine("I: " + userList[i]);
                }
            }

            foreach(int check in checkList)
            {
                valueOne = valueOne + check;
                Console.WriteLine(check);
                Console.WriteLine(valueOne);
            }

            return valueOne;
        }
    }
}
