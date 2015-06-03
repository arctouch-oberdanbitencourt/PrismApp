using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Util
{
    static class ResourcesHelper
    {
        public static string GetStringFrom(string resource)
        {
            return Windows.ApplicationModel.Resources.Core.ResourceManager.Current.MainResourceMap.GetValue(resource).ValueAsString;
        }
    }
}