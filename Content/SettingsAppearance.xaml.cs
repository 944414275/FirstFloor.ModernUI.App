using FirstFloor.ModernUI.Presentation;
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
using System.Drawing;

namespace FirstFloor.ModernUI.App.Content
{
    /// <summary>
    /// Interaction logic for SettingsAppearance.xaml
    /// </summary>
    public partial class SettingsAppearance : UserControl
    {
        public SettingsAppearance()
        {
            InitializeComponent();

            // a simple view model for appearance configuration
            this.DataContext = new SettingsAppearanceViewModel();
            
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            int i = 0;
            foreach (System.Drawing.FontFamily ff in fonts.Families)
            {
                if (ff.Name.Equals("宋体"))
                {
                    this.fontFamilies.Text = ff.Name;
                    this.fontFamilies.SelectedIndex = i;
                }
                this.fontFamilies.Items.Add(ff.Name);
                i++;
            }
        }
    }
}
