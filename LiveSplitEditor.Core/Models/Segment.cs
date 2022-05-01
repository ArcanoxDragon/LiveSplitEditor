using System.Collections.Generic;

namespace LiveSplitEditor.Core.Models;

public class Segment
{
	public string?         Name            { get; set; }
	public List<SplitTime> SplitTimes      { get; set; } = new();
	public Time?           BestSegmentTime { get; set; }
}