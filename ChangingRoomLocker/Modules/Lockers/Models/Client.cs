namespace ChangingRoomLocker.Modules.Lockers.Models;

public record Client(
    int Id,
    string Name,
    ClientNumber Number,
    Gender Gender,
    ClientType Type = ClientType.Adult
);
