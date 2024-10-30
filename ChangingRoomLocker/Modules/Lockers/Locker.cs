namespace ChangingRoomLocker.Modules.Lockers
{
    public class Locker
    {
        public int Id { get; set; }
        public LockerStatus LockerStatus { get; set; }
        public LockerSerialNumber SerialNumber { get; set; }
        public int OrderNumber { get; set; }
        public LockerPosition Position { get; set; }
    }
}
