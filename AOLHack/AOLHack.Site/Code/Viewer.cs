using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLHack.Site
{
    public enum ViewerType
    {
        Curator,
        Viewer
    }

    public class Viewer : AOLHack.Domain.User
    {
        public ViewerType Type { get; set; }
    }
}