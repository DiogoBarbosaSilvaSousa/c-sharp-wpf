using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfBackgroundWorkerCancellation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BackgroundWorker worker = null;

        public MainWindow()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            worker.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            worker.CancelAsync();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                worker.ReportProgress(i);
                System.Threading.Thread.Sleep(250);
            }
            e.Result = 42;
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = "Trabalhando... (" + e.ProgressPercentage + "%)";
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblStatus.Foreground = Brushes.Red;
                lblStatus.Text = "Cancelado pelo usuário...";
            }
            else
            {
                lblStatus.Foreground = Brushes.Green;
                lblStatus.Text = "Pronto... Calc. resultado: " + e.Result;
            }
        }

    }
}
