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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MathGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        private GamePlay gamepageFrm;
        private FinalScore scoreWindowForm;
        public MainWindow()
        {
            InitializeComponent();
            LbError.Content = "";
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
           
            //just inits all of the random stuff this page needs
            #region initClasses
            
            
            gamepageFrm = new GamePlay();
            #endregion

            //gameForm.highScores = highScoresForm
        }

        /// <summary>
        /// The button that starts the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtStartGame_Click(object sender, RoutedEventArgs e)
        {
            //this try catch is to prevent the program from crashing 
            #region setAge

            UInt16 age;
            try
            {
                age  = UInt16.Parse(TbAge.Text);
                if (age <= 3 || age >= 10)
                {
                    throw new Exception("OutOfRange");
                }

                user.age = age;
            }
            catch (Exception ex)
            {
                LbError.Content = "Please Enter a Valid Name And Age";
                return;
            }

              

            #endregion

            //validates that there is something in the text box
            #region setName
            if (TbuserName.Text.Length >= 3)
            {
                user.name = TbuserName.Text;
            }
            else //if the string is empty
            {
                LbError.Content = "Please Enter a Valid Name And Age";
                return;
            }


            #endregion

            //gets radioButton data and passes it to game
            #region radioButton

            if (user.gameMode == 0)
            {
                LbError.Content = "Please Select a Game mode";
                return;
            }

            #endregion radioButton



            this.Hide();

            gamepageFrm.ShowDialog();

            //so this way the window will be drawn at the proper time
            scoreWindowForm = new FinalScore();
            scoreWindowForm.ShowDialog();

            //rebuilds the gamePlay window to be played again
            gamepageFrm = new GamePlay();

            this.Show();
        }
        //detects which radio button is selected
        #region radioButtonJunk
        /// <summary>
        /// passes which button you clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbSubtraction_Checked(object sender, RoutedEventArgs e)
        {
            user.gameMode = 2;
            LbError.Content = "";
        }
        /// <summary>
        /// passes which button you clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbAddition_Checked(object sender, RoutedEventArgs e)
        {
            user.gameMode = 1; 
            LbError.Content = "";
        }
        /// <summary>
        /// passes which button you clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbMultiplication_Checked(object sender, RoutedEventArgs e)
        {
            user.gameMode = 3;
            LbError.Content = "";
        }
        /// <summary>
        /// passes which button you clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbDivision_Checked(object sender, RoutedEventArgs e)
        {
            user.gameMode = 4;
            LbError.Content = "";
        }


        #endregion

    }
}
