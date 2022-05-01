namespace LiveSplitEditor.Core.Models;

public class Attempt
{
	public int             Id              { get; set; }
	public DateTimeOffset? Started         { get; set; }
	public bool            IsStartedSynced { get; set; }
	public DateTimeOffset? Ended           { get; set; }
	public bool            IsEndedSynced   { get; set; }
	public Time?           AttemptTime     { get; set; }
}