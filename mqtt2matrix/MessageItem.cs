namespace mqtt2matrix;

public class Topic 
{
    public string roomid { get; set; }
    public string topic { get; set; }
}
//{
//"roomid": "!hhLRgoyFSLKlgPhgHF:matrix.c3re.de",
//"topic": "TestMe"
//}
public class Name 
{
    public string roomid { get; set; }
    public string name { get; set; }
}
public class Avatar 
{
    public string roomid { get; set; }
    public string url { get; set; }
}
public class Message 
{
    public string roomid { get; set; }
    public string message { get; set; }
}