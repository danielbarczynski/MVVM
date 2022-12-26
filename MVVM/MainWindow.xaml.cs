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

namespace MVVM
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

        private void TextBoxFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateFullName();
        }

        private void TextBoxLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateFullName();
        }

        void UpdateFullName()
        {
            TextBlockFullName.Text = $"{TextBoxFirstName.Text} {TextBoxLastName.Text}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBoxFirstName.Text = "";
            TextBoxLastName.Text = "";
        }
    }
}
