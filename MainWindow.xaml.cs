using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using Hardcodet.Wpf.TaskbarNotification;
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
using System.Windows.Shapes;

namespace FirstFloor.ModernUI.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        private TaskbarIcon ntfiMain;
        public MainWindow()
        {
            InitializeComponent();
            this.msg.DisplayName = "111111111";
            CommandBinding cb = new CommandBinding();
            cb.Command = CustomCommands.CustomCommand;
            cb.Executed += new ExecutedRoutedEventHandler(OnCloseCommands);
            this.CommandBindings.Add(cb);
            this.ntfiMain = new TaskbarIcon();
            //this.ntfiMain.Icon = Properties.Resources.ccmp;
            this.ntfiMain.ShowBalloonTip("欢迎", "欢迎使用该系统", BalloonIcon.Info);
            this.ntfiMain.TrayBalloonTipClicked += new RoutedEventHandler(this.ntfiMain_BalloonTipClicked);
            this.ntfiMain.TrayLeftMouseDown += new RoutedEventHandler(this.ntfiMain_Click);
            this.ntfiMain.Visibility = Visibility.Hidden;
        }
        private void OnCloseCommands(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("响应自定义命令MyCommand"); 
            SystemCommands.CloseWindow(this);
        }
        private void ntfiMain_Click(object sender, RoutedEventArgs e)
        {

            this.ntfiMain.Visibility = Visibility.Hidden;
            this.Visibility = Visibility.Visible;
            this.WindowState = System.Windows.WindowState.Normal;
            this.Show();
        }

        private void ntfiMain_BalloonTipClicked(object sender, RoutedEventArgs e)
        {
            this.ntfiMain.Visibility = Visibility.Hidden;
            this.Visibility = Visibility.Visible;
            this.WindowState = System.Windows.WindowState.Normal;

            //this.tabCtrMain.SelectedIndex = 2;

        }
    }
}
