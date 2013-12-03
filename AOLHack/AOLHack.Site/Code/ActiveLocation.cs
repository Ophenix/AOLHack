using AOLHack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLHack.Site.Code
{
    public class ActiveLocation : Location
    {
        public IList<Viewer> Viewers { get; set; }
        public IList<VideoSuggestion> VideoSuggestions { get; set; }
    }
}