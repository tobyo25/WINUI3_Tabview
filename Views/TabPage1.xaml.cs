using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TabViewTest.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TabViewTest.Views
{
    public class ReactiveTabPage1 : ReactivePage<TabPage1ViewModel> { }
    public sealed partial class TabPage1 : ReactiveTabPage1
    {
        private bool isHit = false;
        public TabPage1()
        {
            ViewModel = new TabPage1ViewModel();           
            this.InitializeComponent();

            this.WhenActivated((disposables) =>
            {
                this.BindCommand(ViewModel, vm => vm.IncrementCommand, v => v.Button_Send).DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.Message, v => v.Message.Text).DisposeWith(disposables);                
            });

        }               
    }
}
