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

namespace WpfUserControl.User_Controls
{
    /// <summary>
    /// Interaction logic for LimitedInputUserControl.xaml
    /// </summary>
    public partial class LimitedInputUserControl : UserControl
    {
        public LimitedInputUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private string _title = "Título"; 
        public string Title { get { return _title; } set { _title = value; } }

        public int MaxLength { get; set; }
    }
}
