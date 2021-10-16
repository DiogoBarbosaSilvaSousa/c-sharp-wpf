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

namespace WpfTextBoxProperty
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

        private void txtQuatro_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            txtStatus.Text = "A seleção começa no caractere #" + textBox.SelectionStart + Environment.NewLine;
            txtStatus.Text += "A seleção é  " + textBox.SelectionLength + " caractere(s) mais longo" + Environment.NewLine;
            txtStatus.Text += "Texto selecionado: '" + textBox.SelectedText + "'";
        }
    }
}
