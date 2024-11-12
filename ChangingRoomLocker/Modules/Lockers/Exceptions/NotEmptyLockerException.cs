namespace ChangingRoomLocker.Modules.Lockers.Exceptions;

[Serializable]
public class NotEmptyLockerException : Exception
{
    public NotEmptyLockerException()
    {
    }

    public NotEmptyLockerException(string? message) : base(message)
    {
    }

    public NotEmptyLockerException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}