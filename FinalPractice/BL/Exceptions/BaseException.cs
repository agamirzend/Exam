namespace BL.Exceptions;

public class BaseException : Exception
{
    public BaseException(Exception mes) : base("Something went wrong")
    {

    }
}
