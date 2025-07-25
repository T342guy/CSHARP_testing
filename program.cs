using Console = Log73.Console;
using Log73;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Options.LogLevel = LogLevel.Debug;
Console.Log("You can");
MessageTypes.Error.Style.Invert = true;
Console.Error("log customized messages");
Console.Warn("with Log73!");

Console.Log("Log73 is a simple logging library for .NET applications.");