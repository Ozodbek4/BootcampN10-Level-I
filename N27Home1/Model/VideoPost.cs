
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace N27Home1.Model
{
    internal class VideoPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public Topics Topics { get; set; }

        private List<VideoPost> _videoPosts = new List<VideoPost>();
        
        public void Add(string tittle, string description, int like, int dislike, Topics topic)
        {
            _videoPosts.Add(new VideoPost() { Id = Guid.NewGuid(), Title = tittle,
                Description = description, Like = like, Dislike = dislike, Topics = topic });
        }
    }
}
