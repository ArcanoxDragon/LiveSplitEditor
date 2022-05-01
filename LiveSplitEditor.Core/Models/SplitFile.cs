using System.Collections.Generic;

namespace LiveSplitEditor.Core.Models;

public class SplitFile
{
	public string?       Version        { get; set; }
	public string?       GameName       { get; set; }
	public string?       CategoryName   { get; set; }
	public List<Attempt> AttemptHistory { get; set; } = new();
	public List<Segment> Segments       { get; set; } = new();
}