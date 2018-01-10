using Microsoft.Win32;
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

namespace NewsPublishApp
{
    /// <summary>
    /// Логика взаимодействия для CreateNewsPAge.xaml
    /// </summary>
    public partial class CreateNewsPAge : Page
    {
        public CreateNewsPAge()
        {
            InitializeComponent();
        }

        private void BrowseButtonClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            //dialog.DefaultExt = ".png";
            dialog.ShowDialog();

            string filePath = dialog.FileName;

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(filePath);
            image.EndInit();

            imageContainer.Source = image;
        }
    }
}
