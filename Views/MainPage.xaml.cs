using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using ReactiveUI;
using TabViewTest.ViewModels;
using System.Reactive.Disposables;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.
using ReactiveMarbles.ObservableEvents;
using DynamicData;
using System.Threading;
using System.Windows.Controls;

namespace TabViewTest.Views
{
    public class ReactiveMainPage : ReactivePage<MainPageViewModel> { }
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : ReactiveMainPage
    {
        public MainPage()
        {
            ViewModel = new MainPageViewModel();
            this.InitializeComponent();
            
            this.WhenActivated((disposables) =>
            {
                this.OneWayBind(ViewModel,vm=>vm.DisplayItem,v => v.TabView.TabItemsSource)
                .DisposeWith(disposables);

                TabView.Events()
                .TabDragCompleted
                .Subscribe(x =>
                {
                    
                });

                TabView.Events()
                .DataContextChanged
                .Subscribe(x =>
                {

                });
            
            });
        }
    }
}
