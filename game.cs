using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
   public class game
    {
        private UInt16 gameType = 0;
        private Int16 numQuestions = 10;
        private int firstNumber;
        private int secondNumber;

        private Random rand;
        private SoundPlayer buzzerSound, applause;

        /*  Game type guid
         *  1 = addition
         *  2 = subtraction
         *  3 = multiplication
         *  4 = division
         */
        
        /// <summary>
        /// constructor
        /// </summary>
        public game()
        {
            rand = new Random();
            user.correctScore = 0;
            user.incorrectScore = 0;
            this.gameType = user.gameMode;
            numQuestions = 10;
            firstNumber = rand.Next(1, 11);
            secondNumber = rand.Next(1, 11);
            buzzerSound = new SoundPlayer("Buzzer.wav");
            applause = new SoundPlayer("applause.wav");
            setEquation();
        }
         
        /// <summary>
        /// Keeps track of the time
        /// </summary>
        /// <returns>UInt64 of how many seconds has passed</returns>
        public UInt64 updateTime()
        {
            if (numQuestions > 0)
            {
                user.TimeinSeconds++;
                return user.TimeinSeconds;
            }

            return user.TimeinSeconds;
        }

        /// <summary>
        /// generates the new equation but does not display it
        /// </summary>
        public void setEquation()
        {
            firstNumber = rand.Next(1, 11);
            secondNumber = rand.Next(1, 11);

            if (user.gameMode == 2 || user.gameMode == 4)
            {
                if (user.gameMode == 2)
                {
                    bool moveOn = false;
                    do
                    {
                        int z = firstNumber - secondNumber;
                        if (z < 0)
                        {
                            moveOn = true;
                            firstNumber = rand.Next(1, 11);
                            secondNumber = rand.Next(1, 11);
                        }
                        else
                        {
                            moveOn = false;
                        }
                    } while (moveOn);
                }
                else
                {
                    bool stop = false;
                    do
                    {
                        int r = firstNumber % secondNumber;
                        if (r != 0)
                        {
                            stop = true;
                            firstNumber = rand.Next(1, 11);
                            secondNumber = rand.Next(1, 11);
                        }
                        else
                        {
                            stop = false;
                        }
                    } while (stop);
                }
            }

        }

        
        /// <summary>
        /// Returns a char representing the game mode
        /// </summary>
        /// <returns>Char that represents game mode</returns>
        private char getGameTypeChar()
        {
            switch (user.gameMode)
            {
                case 1:
                    return '+';
                    
                case 2:
                    return '-';
                   
                case 3:
                    return 'x';
                    
                case 4:
                    return '/';
                   
                default:
                    return '~';
                   
            }
        }

        /// <summary>
        /// Returns a string representing the question the user is being asked
        /// </summary>
        /// <returns>String</returns>
        public String equasion()
        {
            return firstNumber.ToString() + " " + getGameTypeChar().ToString() + " " +
                   secondNumber.ToString() + " = ";
        }

        /// <summary>
        /// checks the user's answer and anjusts grade accordingly
        /// </summary>
        /// <param name="userAns">int</param>
        public void checkAnswer(int userAns)
        {
            int ans;
            if (user.gameMode == 1)
            {
                ans = firstNumber + secondNumber;
            }
            else if (user.gameMode == 2)
            {
                ans = firstNumber - secondNumber;
            }
            else if (user.gameMode == 3)
            {
                ans = firstNumber * secondNumber;
            }
            else
            {
                ans = firstNumber / secondNumber;
            }

            if (userAns == ans)
            {
                applause.Play();
               user.correctScore++;
            }
            else
            {
                buzzerSound.Play();
                user.incorrectScore++;
            }

            numQuestions--;
            if (numQuestions > 0)
            {
                setEquation();
            }
        }

        #region Getters
        /// <summary>
        /// returns the number of points the user scored
        /// </summary>
        /// <returns>String</returns>
        public String getCorrectScore()
        {
            return user.correctScore.ToString();
        }

        /// <summary>
        /// returns the number of questions the user missed
        /// </summary>
        /// <returns>String</returns>
        public String getIncorrectScore()
        {
            return user.incorrectScore.ToString();
        }
        /// <summary>
        /// How many questions that still need to be answered
        /// </summary>
        /// <returns>int</returns>
        public int getNumQuestions()
        {
            return numQuestions;
        }


        #endregion

    }
}
