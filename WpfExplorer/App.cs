using Jamesnet.Wpf.Controls;
using System.Windows;
using WpfExplorer.Support.UI.Units;
using WpfExplorer.Forms.UI.Views;

namespace WpfExplorer
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new ExplorerWindow();
            //return new DarkThemeWindow();
            //return new Window();            
        }
    }
}
