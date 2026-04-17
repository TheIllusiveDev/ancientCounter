// Copyright (c) [Your Name/Username]. 
// Licensed under the Mozilla Public License 2.0.
// Stargate and related elements are trademarks of MGM.

namespace CountdownTimerGUI;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}