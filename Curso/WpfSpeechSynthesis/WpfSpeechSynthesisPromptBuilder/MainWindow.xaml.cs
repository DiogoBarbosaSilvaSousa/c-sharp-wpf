using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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

namespace WpfSpeechSynthesisPromptBuilder
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

        private void btnSayHello_Click(object sender, RoutedEventArgs e)
        {
            PromptBuilder promptBuilder = new PromptBuilder();
            promptBuilder.AppendText("Olá mundo");

            PromptStyle promptStyle = new PromptStyle();
            promptStyle.Volume = PromptVolume.Soft;
            promptStyle.Rate = PromptRate.Slow;
            promptBuilder.StartStyle(promptStyle);
            promptBuilder.AppendText("e olá para o universo também.");
            promptBuilder.EndStyle();

            promptBuilder.AppendText("Neste dia, ");
            promptBuilder.AppendTextWithHint(DateTime.Now.ToShortDateString(), SayAs.Date);

            promptBuilder.AppendText(", estamos reunidos aqui para aprender");
            promptBuilder.AppendText("tudo", PromptEmphasis.Strong);
            promptBuilder.AppendText("sobre");
            promptBuilder.AppendTextWithHint("WPF", SayAs.SpellOut);

            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak(promptBuilder);
        }
    }
}
