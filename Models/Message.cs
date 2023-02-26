namespace Chat.Models;

public class Message
{
    public Message(int id, string text,  DateTime created, int channelId, int userId)
    {
        Id = id;
        Text = text;
        Created = created;
        ChannelId = channelId;
        UserId = userId;
    }
    public int Id { get; set; }
    public string Text { get; set; }
    public string UserName { get; set; }
    public DateTime Created { get; set; }
    public int ChannelId { get; set; }
    public Channel? Channel { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }

}