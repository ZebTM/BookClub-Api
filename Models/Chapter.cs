
namespace BookClub.Models;

public class Chapter
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public String? Title { get; set; } = String.Empty;
    public UInt16 ChapterIndex { get; set; } = 0;
}
