using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace fyp.Classes
{
  public static  class ControlExtentions
    {
        public static T FindParent<T>(this DependencyObject Child) where T : DependencyObject
        {
            var parentObject = VisualTreeHelper.GetParent(Child);
            if (parentObject == null)
            {
                return null;
            }
            var parent = parentObject as T;
            if (parent ==null)
            {
                return FindParent<T>(parentObject);
            }

            return parent;
        }
    }
}
