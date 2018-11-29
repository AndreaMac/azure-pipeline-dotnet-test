using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvpApp
{
    public interface IView
    {
        String Label { get; set; }
        String TextBox { get; set; }
    }
}