using System.Windows.Controls;
using ACT.TTSYukkuri.resources;
using FFXIV.Framework.Globalization;

namespace ACT.TTSYukkuri.Config.Views
{
    /// <summary>
    /// ConfigBaseView.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfigBaseView : UserControl, ILocalizable
    {
        public ConfigBaseView()
        {
            this.InitializeComponent();

            this.SetLocale(Settings.Default.UILocale);
        }

        public void SetLocale(Locales locale) => this.ReloadLocaleDictionary(locale);
    }
}
