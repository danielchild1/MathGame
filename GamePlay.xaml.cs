using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MathGame
{
    /// <summary>
    /// Interaction logic for GamePlay.xaml
    /// </summary>
    public partial class GamePlay : Window
    {
        private bool gameStarted;
        private game Game;
        private readonly DispatcherTimer dispatcherTimer;
        public GamePlay()
        {
            #region TymerSetUp
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            #endregion
            InitializeComponent();
            TbAnswer.Text = "";
            
        }

        /// <summary>
        /// controls the timer and keeps the game class up to date on the seconds
        /// </summary>
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                LbTimerz.Content = Game.updateTime().ToString();
            }
            catch (Exception ex)
            {
                dispatcherTimer.Stop();
                this.Hide();
            }
            if (Game.getNumQuestions() <= 0)
                dispatcherTimer.Stop();


        }


        #region ThingsthatCallNext
        /// <summary>
        /// calles next
        /// </summary>
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                next();
            }
            
        }
        /// <summary>
        /// calles next
        /// </summary>
        private void BtNext_Click(object sender, RoutedEventArgs e)
        {
            next();
        }


        #endregion

        /// <summary>
        /// calls the game.checkAnswer and then updates scoreboard
        /// </summary>
        private void next()
        {
            if (gameStarted)
            {
                try
                {
                    int answer = int.Parse(TbAnswer.Text.ToString());
                    Game.checkAnswer(answer);
                }
                catch (Exception ex)
                {
                    Game.checkAnswer(0);
                }
                

                if (Game.getNumQuestions() <= 0)
                {
                    this.Hide();
                }

                LbMathProblem.Content = Game.equasion();
                LbCorrect.Content = Game.getCorrectScore();
                LbIncorrect.Content = Game.getIncorrectScore();
                LbQl.Content = Game.getNumQuestions();
                TbAnswer.Text = "";
            }
           
        }

        /// <summary>
        /// starts game then hides the start game button
        /// </summary>
        private void BtStartz_Click(object sender, RoutedEventArgs e)
        {
            Game = new game();
            gameStarted = true;
            dispatcherTimer.Start();
            BtStartz.Visibility = Visibility.Hidden;
            BtCancel.Visibility = Visibility.Visible;
            LbMathProblem.Content = Game.equasion();

        }

        /// <summary>
        /// how to close the game instructions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)//why is this dark??
        {
            e.Cancel = true;
            this.Hide();
        }

        /// <summary>
        /// The button to end the game early 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            this.Hide();
        }
    }
}

