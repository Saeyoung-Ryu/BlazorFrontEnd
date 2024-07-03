namespace BlazorApp1.Type;

public class Player
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string PlayerName { get; set; }
    public long Suid { get; set; }
    public List<int> ManagingDashBoardList { get; set; }
    public int Level { get; set; } // 현질 유무
}