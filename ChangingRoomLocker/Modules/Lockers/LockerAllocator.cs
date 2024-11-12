using ChangingRoomLocker.Modules.Lockers.Models;

namespace ChangingRoomLocker.Modules.Lockers;

public class LockerAllocator
{
    private ChangingRoomCollection _rooms;

    public LockerAllocator(ChangingRoomCollection changingRoomCollection)
    {
        _rooms = changingRoomCollection;
    }

    public Locker ChooseLocker(Client client)
    {
        return _rooms.ChooseOneLocker();
    }
}
