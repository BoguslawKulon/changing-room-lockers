using ChangingRoomLocker.Modules.Lockers;

namespace Tests;

public class LockerSerialNumberTests
{
    [Fact]
    public void LockerSerialNumber_SetValue_GetSameSerialNumber()
    {
        var lockerSerialNumber = new LockerSerialNumber("abc");

        var result = lockerSerialNumber.serialNumber;

        Assert.Equal("abc", result);
    }
}