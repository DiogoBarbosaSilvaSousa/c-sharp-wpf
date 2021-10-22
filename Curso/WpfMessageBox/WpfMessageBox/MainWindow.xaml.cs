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

namespace WpfMessageBox
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
        private void btnSimpleMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Olá, mundo!");
        }

        private void btnMessageBoxWithTitle_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Olá, mundo!", "Meu Aplicativo");
        }

        private void btnMessageBoxWithButtons_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Este MessageBox tem opções extras.\n\nOlá, mundo?", "Meu aplicativo", MessageBoxButton.YesNoCancel);
        }

        private void btnMessageBoxWithResponse_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Você gostaria de saudar o mundo com um \"Olá, mundo\"?", "Meu Aplicativo", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Olá para você também!", "Meu Aplicativo");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Bem, que pena!", "Meu Aplicativo");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Deixa pra lá então...", "Meu Aplicativo");
                    break;
            }
        }

        private void btnMessageBoxWithIcon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Olá, mundo!", "Meu Aplicativo", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnMessageBoxWithDefaultChoice_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Olá, mundo?", "Meu Aplicativo", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
        }
    }
}
