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

namespace _4kTiles_Frontend.MVVM.Views.UserControls
{
    /// <summary>
    /// Interaction logic for CustomModalDialog.xaml
    /// </summary>
    public partial class CustomModalDialog : UserControl
    {
        public CustomModalDialog()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var window = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            window?.Close();
            //this.Visibility = Visibility.Collapsed;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if(txtTitle.Text == "Title")
            {
                txtTitle.Clear();
            }
        }
    }
}
