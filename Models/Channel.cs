using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat.Models
{
    public class Channel
    {
        public Channel(int id, string name, DateTime created, int creatorId)
        {
            Id = id;
            Name = name;
            Created = created;
            CreatorId = creatorId;
            Users = new List<User>();
            Messages = new List<Message>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        [Display(Name = "Created By")]
        public int CreatorId { get; set; }

        [NotMapped]
        public User? Creator { get; set; }

        public List<User>? Users { get; set; }

        public List<Message>? Messages { get; set; }
    }
}
