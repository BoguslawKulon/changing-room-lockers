namespace ChangingRoomLocker.Modules.Lockers.Models;

public class TimeRange
{
    public DateTime TimeStart { get; }
    public DateTime TimeEnd { get; }

    public TimeRange(DateTime timeStart, DateTime timeEnd)
    {
        TimeStart = timeStart;
        TimeEnd = timeEnd;
    }
}
