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

namespace WpfTextBlockCodeBehind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock tb = new TextBlock();
            tb.TextWrapping = TextWrapping.Wrap;
            tb.Margin = new Thickness(10);
            tb.Inlines.Add("Um exemplo em ");
            tb.Inlines.Add(new Run("de controle TextBlock ") { FontWeight = FontWeights.Bold });
            tb.Inlines.Add("usando ");
            tb.Inlines.Add(new Run("formatação de texto ") { Foreground = Brushes.Blue });
            tb.Inlines.Add(new Run("inline ") { FontStyle = FontStyles.Italic });            
            tb.Inlines.Add("a partir de ");
            tb.Inlines.Add(new Run("Code-Behind") { TextDecorations = TextDecorations.Underline });
            tb.Inlines.Add(".");
            this.Content = tb;
        }
    }
}
