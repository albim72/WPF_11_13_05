using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoCommands
{
    internal class MessageBus
    {
        private static readonly List<Action<RunnerSavedMessage>> RunnerSavedHandlers = new();

        public static void Subscribe(Action<RunnerSavedMessage> handler)
        {
            RunnerSavedHandlers.Add(handler);
        }

        public static void Send(RunnerSavedMessage message)
        {
            foreach (var handler in RunnerSavedHandlers.ToArray())
            {
                handler(message);
            }
        }
    }
    public record RunnerSavedMessage(string RunnerName);
}

// File: IsExternalInit.cs
// Add this to your project to provide the missing type when targeting older frameworks/SDKs.
namespace System.Runtime.CompilerServices
{
    // The compiler looks for this type to enable 'init' accessors and record support.
    internal static class IsExternalInit { }
}
