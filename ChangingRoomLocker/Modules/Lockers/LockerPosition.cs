namespace ChangingRoomLocker.Modules.Lockers;

/// <summary>
/// Locker position
/// </summary>
/// <param name="row">Row starts from bottom (one based)</param>
/// <param name="column">Column starts from left (one based)</param>
public record LockerPosition(int row, int column)
{
    private const int BOTTOM_ROW = 1;

    public bool EasyAccess => row == BOTTOM_ROW;
}