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
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Pase4
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<string> image = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            LoadSettings();
            image.Add("D:/hoge.jpg");
            image.Add("D:/cabu.jpg");

            DataContext = image;
        }

        private void LoadSettings()
        {
            //ImagePath.Text = Properties.Settings.Default.SelectImagePath;
            Left = Properties.Settings.Default.WindowLeft;
            Top = Properties.Settings.Default.WindowTop;
            Width = Properties.Settings.Default.WindowWidth;
            Height = Properties.Settings.Default.WindowHeight;
        }

        private void SaveSettings()
        {
            //Properties.Settings.Default.SelectImagePath = ImagePath.Text;
            Properties.Settings.Default.WindowLeft = Left;
            Properties.Settings.Default.WindowTop = Top;
            Properties.Settings.Default.WindowWidth = Width;
            Properties.Settings.Default.WindowHeight = Height;
            Properties.Settings.Default.Save();
        }

        private void MainWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveSettings();
        }


    }

}
