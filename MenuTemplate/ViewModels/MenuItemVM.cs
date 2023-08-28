using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuTemplate.ViewModels
{
    public class MenuItemVM
    {
        public string? Header { get; set; }
        public IList<MenuItemVM>? Items { get; set;}

        public bool? IsChecked { get; set; } = null;
    }
}
