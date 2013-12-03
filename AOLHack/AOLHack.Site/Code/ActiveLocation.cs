using AOLHack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLHack.Site
{
    public class ActiveLocation : Location
    {
        public IList<Viewer> Viewers { get; set; }
        public IList<Video> Playlist { get; set; }
        public Video CurrentlyPlayed { get; set; }

        public void JoinIn()
        {
            if (!Viewers.Contains(StateAgent.CurrentViewer))
                Viewers.Add(StateAgent.CurrentViewer);
        }

        public void Leave()
        {
            if (Viewers.Contains(StateAgent.CurrentViewer))
                Viewers.Remove(StateAgent.CurrentViewer);
        }
    }
}