using DynamicTabView.TabPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicTabView.ViewModels
{
    public static class UserControlSelector
    {
        public static UserControl SelectUserControl(object item)
        {
            if (item != null)
            {
                if (item is ContactsUserControlViewModel)
                {
                    return new ContactsUserControl() { DataContext = item };
                }
                if (item is ContactsAddressesUserControlViewModel)
                {
                    return new ContactsAddressesUserControl() { DataContext = item };
                }
                if (item is ContactsCommunicationsUserControlViewModel)
                {
                    return new ContactsCommunicationsUserControl() { DataContext = item };
                }
                if (item is SettingsColorsUserControlViewModel)
                {
                    return new SettingsColorsUserControl() { DataContext = item };
                }
                if (item is SettingsPathsUserControlViewModel)
                {
                    return new SettingsPathsUserControl() { DataContext = item };
                }
            }

            return null;
        }
    }
}
