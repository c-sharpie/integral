using System;
using System.Diagnostics;

namespace Integral.Diagnostics
{
    public static class Log
    {
        public static event Action<string>? OnWriteInformation;

        public static event Action<Exception>? OnWriteException;

        [Conditional("DEBUG")]
        public static void Write(string message) => OnWriteInformation?.Invoke(message);

        [Conditional("TRACE")]
        public static void Write(Exception exception) => OnWriteException?.Invoke(exception);
    }
}