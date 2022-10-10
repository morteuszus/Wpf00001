using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf00001.Core
{
    class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object,bool> canExecute;

        public event EventHandler CanExecuteChanged
        {

        }
    }
}
