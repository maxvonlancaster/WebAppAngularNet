using System;

namespace ConsoleAppPlayground.Advancement.Playground
{
    public class ExceptionPlayground
    {
        public void Main()
        {
            ExceptionWork();
        }

        public void MethodThatThrowsCustomException()
        {
            throw new CustomException("sample text");
        }

        public void MethodThatThrowsException()
        {
            throw new Exception("sample text");
        }

        public void ExceptionWork()
        {
            try
            {
                MethodThatThrowsCustomException();
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Custom ex : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General ex : {ex.Message}");
            }
        }
    }

    public class CustomException : Exception
    {
        public CustomException() { }

        public CustomException(string message) : base(message)
        {
        }
    }
}
