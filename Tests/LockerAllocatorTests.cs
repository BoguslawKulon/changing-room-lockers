using ChangingRoomLocker.Modules.Lockers;
using ChangingRoomLocker.Modules.Lockers.Models;

namespace Tests;

public class LockerAllocatorTests
{
    [Fact]
    public void AllocateRight()
    {
        var rooms = PrepareChangingRooms();
        var allocator = new LockerAllocator(rooms);
        var men = new Client(1, "Ben", new ClientNumber(123), Gender.Men);

        var locker = allocator.ChooseLocker(men);

        Assert.NotNull(locker);
    }

    private ChangingRoomCollection PrepareChangingRooms()
    {
        var collection = new ChangingRoomCollection();
        collection.AddRoom(new ChangingRoom("A", Gender.Men, 2, 10));

        return collection;
    }
}
