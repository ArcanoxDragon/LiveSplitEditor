using LiveSplitEditor.ViewModels;

namespace LiveSplitEditor.DesignData;

public class Segments
{
	public static readonly SegmentViewModel FirstSegment = new() { Index = 0, Name = "First Segment", BestSegmentTime = new TimeSpan(0, 3, 10) };
	public static readonly SegmentViewModel SecondSegment = new() { Index = 2, Name = "Second Segment", BestSegmentTime = new TimeSpan(0, 4, 6) };
	public static readonly SegmentViewModel ThirdSegment = new() { Index = 3, Name = "Third Segment", BestSegmentTime = new TimeSpan(0, 1, 43) };
}