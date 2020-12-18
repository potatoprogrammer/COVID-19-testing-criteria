/*this project is supposed to guide the user through the new COVID-19 testing criteria 
 *according to the government of Ontario*/

/*
 *Author: Caio Victor Goncalves
 *Date: 2020-10-28
 */

using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = false;
            string answer;
            //loops the questionare
            while (condition == false) {
                Console.WriteLine("New COVID-19 Testing Criteria in Ontario v1.5");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("*** Please reply to the questions as Yes or No or Y or N only. This software will not understand any other responses.\n");

                string[] questions = {
                    "Do you have COVID-19 symptoms? ",
                    "Have you been in contact with someone who tested positive?",
                    "Has public health or the COVID-19 Alert app said you've been exposed?",
                    "Has someone in your household tested positive?",
                    "Are you part of a group targeted for testing by the province ? *"
                };
                int counter = 0;

                //while both condition is false and the counter is lower than the quiestions array lenght it will loop throught the questions
                while (counter < questions.Length)
                {
                    Console.WriteLine(questions[counter]);

                    //this method returns a bool to get out of the loop
                    //the method validates if the answer is correct               
                    counter = counter + YesOrNo(counter);
                }

                //make sure the questionare loops 
                Console.WriteLine("\nThanks for using our software. Please Enter Y to re-run the program");
                answer = Console.ReadLine();
                if (answer == "YES" || answer == "Yes" || answer == "yes" || answer == "Y" || answer == "y")
                {
                    condition = false;
                    Console.WriteLine();
                }
                else {
                    //exit the loop
                    condition = true;
                }
            }

        }

        //this method adds one to the counter if the user anser correct
        private static int YesOrNo(int question)
        {
            string response = Console.ReadLine();
            Console.WriteLine();
            if (question <= 3)
            {
                if (response == "YES" || response == "Yes" || response == "yes" || response == "Y" || response == "y")
                {
                    Console.WriteLine("Go to an assessment centre");

                    return 10;
                }
                else if (response == "NO" || response == "No" || response == "no" || response == "N" || response == "N")
                {
                    return 1;
                }
                else
                {
                    Console.WriteLine("Your entry is invalid, please try again\n");
                    return 0;

                }
            }
            //this part returns different answers for the last question
            else if(question == 4)
            {
                if (response == "YES" || response == "Yes" || response == "yes" || response == "Y" || response == "y")
                {
                    Console.WriteLine("Go to a pharmacy that offers testing");

                    return 1;
                }
                else if (response == "NO" || response == "No" || response == "no" || response == "N" || response == "N")
                {
                    Console.WriteLine("You are not eligible for a test");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Your entry is invalid, please try again\n");
                }

                return 0;
            }
            return 1;
        }
    }
}
