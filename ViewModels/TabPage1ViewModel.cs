using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace TabViewTest.ViewModels
{
    public class TabPage1ViewModel:ReactiveObject
    {
        public ReactiveCommand<Unit,Unit> IncrementCommand { get; set; }
        [Reactive] public string Message { get; set; } = "";
        [Reactive] public bool IsHit { get; set; } = false;
        private int _counter = 0;
        public TabPage1ViewModel()
        {
            IncrementCommand = ReactiveCommand.Create(ToggleButton);   
        }

        private void ToggleButton()
        {
            Message = _counter++.ToString();
        }
    }
}
