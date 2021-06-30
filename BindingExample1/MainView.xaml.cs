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

namespace BindingExample1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainView : Window
    {
        private MainViewModel _viewModel = new MainViewModel();

        public MainView()
        {
            InitializeComponent();
            DataContext = _viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.時刻 = DateTime.Now;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_viewModel.時刻.ToString("HH:mm:ss:fff"));
        }
    }
}
