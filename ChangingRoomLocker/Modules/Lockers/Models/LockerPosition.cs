namespace ChangingRoomLocker.Modules.Lockers.Models;

/// <summary>
/// Locker position
/// </summary>
/// <param name="Row">Row starts from bottom (one based)</param>
/// <param name="Column">Column starts from left (one based)</param>
public record LockerPosition(int Row, int Column)
{
    private const int BOTTOM_ROW = 1;

    public bool EasyAccess => Row == BOTTOM_ROW;
}