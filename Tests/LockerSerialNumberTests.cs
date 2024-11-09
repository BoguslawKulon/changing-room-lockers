using ChangingRoomLocker.Modules.Lockers.Models;

namespace Tests;

public class LockerSerialNumberTests
{
    [Fact]
    public void LockerSerialNumber_SetValue_GetSameSerialNumber()
    {
        var lockerSerialNumber = new LockerSerialNumber("abc");

        var result = lockerSerialNumber.SerialNumber;

        Assert.Equal("abc", result);
    }
}