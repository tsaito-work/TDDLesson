using System;

namespace TDDLesson.UI
{
    public sealed class InputException : Exception
    {
        public InputException(string message) : base(message)
        {

        }
    }
}
