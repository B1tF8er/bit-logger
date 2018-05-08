namespace Bit.Logger.Samples
{
    using System;

    internal static class Constants
    {
        internal const string TraceMessage = "TEST TRACE MESSAGE";
        internal const string DebugMessage = "TEST DEBUG MESSAGE";
        internal const string VerboseMessage = "TEST VERBOSE MESSAGE";
        internal const string InformationMessage = "TEST INFORMATION MESSAGE";
        internal const string WarningMessage = "TEST WARNING MESSAGE";
        internal const string ErrorMessage = "TEST ERROR MESSAGE";
        internal const string CriticalMessage = "TEST CRITICAL MESSAGE";

        internal static readonly Exception TraceException = new Exception("TEST TRACE EXCEPTION");
        internal static readonly Exception DebugException = new Exception("TEST DEBUG EXCEPTION");
        internal static readonly Exception VerboseException = new Exception("TEST VERBOSE EXCEPTION");
        internal static readonly Exception InformationException = new Exception("TEST INFORMATION EXCEPTION");
        internal static readonly Exception WarningException = new Exception("TEST WARNING EXCEPTION");
        internal static readonly Exception ErrorException = new Exception("TEST ERROR EXCEPTION");
        internal static readonly Exception CriticalException = new Exception("TEST CRITICAL EXCEPTION");
    }
}