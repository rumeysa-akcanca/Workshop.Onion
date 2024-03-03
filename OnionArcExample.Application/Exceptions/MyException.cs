

namespace OnionArcExample.Application.Exceptions
{
    //custom exception
    public class MyException : Exception  //istisna , kuraldışılık
    {
        public MyException() : base("My error occured") { }
        public MyException(string message) : base(message) { }
        public MyException(Exception exception) : this(exception.Message) { }
      
    }
}
