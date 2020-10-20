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

namespace MathGame
{
    /// <summary>
    /// Interaction logic for FinalScore.xaml
    /// </summary>
    public partial class FinalScore : Window
    {
        public FinalScore()
        {
            InitializeComponent();
            LbPlayer.Content = user.name + " " + user.age.ToString();
            LbCorrect.Content = user.correctScore.ToString();
            LbIncorrect.Content = user.incorrectScore.ToString();
            LbTime.Content = user.TimeinSeconds.ToString();
            ImageBrush cornerPicture;

            if (user.correctScore >= 8)
            {
                cornerPicture = new ImageBrush(new BitmapImage((new Uri(@"Images/basketball_hoop.png", UriKind.Relative))));
            }
            else if (user.correctScore > 5)
            {
                cornerPicture = new ImageBrush(new BitmapImage((new Uri(@"Images/basketoof.jpg", UriKind.Relative))));
            }
            else
            {
                cornerPicture = new ImageBrush(new BitmapImage((new Uri(@"Images/basketball-Flat.jpg", UriKind.Relative))));
            }

            CanvasCornerImage.Background = cornerPicture;

        }

        /// <summary>
        /// takes user back to the home screen
        /// </summary>
        private void home_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// makes it so that it closes out properly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)//why is this dark??
        {
            e.Cancel = true;
            this.Hide();
            
        }
    }
}
