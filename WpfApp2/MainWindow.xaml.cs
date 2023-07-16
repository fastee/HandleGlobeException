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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindowViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ExceptionSetting();

            ViewModel = new();
            DataContext = ViewModel;

        }
        protected override void OnClosing(CancelEventArgs e)
        {

            Hide();
            e.Cancel = true;
        }

        private void ExceptionSetting()
        {
            Dispatcher.UnhandledException += (s, e) =>
            {
                e.Handled = true;
                MessageBox.Show(e.Exception.ToString(), "UI线程异常");
            };

            TaskScheduler.UnobservedTaskException += (s, e) =>
            {
                MessageBox.Show(e.Exception.ToString(), "Task线程异常");
                e.SetObserved();
            };

            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                StringBuilder sb = new();
                if (e.ExceptionObject is Exception ex)
                {
                    sb.Append(ex.ToString());
                }
                else
                {
                    sb.Append(e.ExceptionObject);
                }
                MessageBox.Show(sb.ToString(), "非UI线程异常");
            };

        }
    }
}
