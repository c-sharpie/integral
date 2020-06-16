using Integral.Abstractions;

namespace Integral.Extensions
{
    public static class IEnumerableExtensions
    {
        public static void ExecuteAll<Element>(this Enumerable<Element> enumerable)
            where Element : Executable
        {
            foreach (Element executable in enumerable)
            {
                executable.Execute();
            }
        }

        public static void DisposeAll<Element>(this Enumerable<Element> enumerable)
            where Element : Disposable
        {
            foreach (Element disposable in enumerable)
            {
                disposable.Dispose();
            }
        }

        public static void ClearAll<Element>(this Enumerable<Element> enumerable)
            where Element : Clearable
        {
            foreach (Element clearable in enumerable)
            {
                clearable.Clear();
            }
        }
    }
}