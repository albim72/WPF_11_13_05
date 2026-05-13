using System;
using System.Collections.Generic;

namespace WpfDay3Exercise05;

public static class MessageBus
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
