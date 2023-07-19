using DynamicData.Binding;
using Microsoft.UI.Xaml.Controls;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabViewTest.Views;
using Windows.Foundation.Collections;

namespace TabViewTest.ViewModels
{
    public class MainPageViewModel:ReactiveObject
    {
        [Reactive]public ObservableCollection<TabViewItem> DisplayItem { get;set; }
        public MainPageViewModel()
        {
            DisplayItem = new ObservableCollection<TabViewItem>();
            for(int i = 0; i < 2; i++) 
            {
                TabViewItem item = new TabViewItem()
                {
                    Header = $"Page {i+1}",
                };

                Frame frame = new Frame();
                if (i == 0)                
                    frame.Content = new TabPage1();
                if (i == 1)               
                    frame.Content = new TabPage2();

                item.Content = frame;

                DisplayItem.Add(item);
            }          
        }
    }
}
