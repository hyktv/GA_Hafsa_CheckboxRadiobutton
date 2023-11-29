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

namespace GA_Hafsa_CheckboxRadiobutton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDisplayInfo_Click(object sender, RoutedEventArgs e)
        {
            //we will keep appending to this string before
            //we display it to our rich text box
            string formattedString = "";

            //grabbing checkbox information
            bool isRaining = chkIsRaining.IsChecked.Value;
            bool isTimeSensitive = chkIsTimeSensitive.IsChecked.Value;
            bool useMailingAddress = chkUseAddress.IsChecked.Value;

            //here we are appending the results from our checkbox
            formattedString += $"Is Raining : {isRaining}\n\n";
            formattedString += $"Is Time Sensitive : {isTimeSensitive}\n\n";
            formattedString += $"Using Mailing Address : {useMailingAddress}\n\n";

            //which color
            bool isRed = rbRed.IsChecked.Value;
            bool isGreen = rbGreen.IsChecked.Value;
            bool isBlack = rbBlack.IsChecked.Value;

            formattedString += "Your favorite color is ";

            //using an if else statement, we display which color is the users favorite
            if (isRed) { formattedString += "red\n"; }
            else if(isGreen) { formattedString += "green\n"; }
            else { formattedString += "blue\n"; }

            //replace this with your code 
            //which app
            bool netflix = rbNetflix.IsChecked.Value;
            bool tiktok = rbTiktok.IsChecked.Value;
            bool youtube = rbYoutube.IsChecked.Value;

            formattedString += "\nYour go to app is ";

            if (netflix) { formattedString += "netflix\n"; }
            else if (tiktok) { formattedString += "tiktok\n"; }
            else { formattedString += "youtube\n"; }

            //here we assign our formattedString to our rich text box
            rtbDisplay.Text = formattedString;
        } //btnDisplayInfo_Click()
    }
}
