using System.Collections.Generic;
using NzbDrone.Core.Datastore;

namespace NzbDrone.Core.Movies
{
    public class Member : IEmbeddedDocument
    {
        public Member()
        {
            Images = new List<MediaCover.MediaCover>();
        }

        public string Name { get; set; }
        public string Job { get; set; }
        public List<MediaCover.MediaCover> Images { get; set; }
    }
}