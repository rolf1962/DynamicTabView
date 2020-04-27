using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTabView.ViewModels
{
    public abstract class TabControlUserControlViewModel : ViewModelBase
    {
        public List<object> TabPageViewModels { get; } = new List<object>();
    }
}
