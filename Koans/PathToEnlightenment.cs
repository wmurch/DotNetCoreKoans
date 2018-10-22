using System;
using DotNetCoreKoans.Engine;

namespace DotNetCoreKoans.Koans
{
    public class PathToEnlightenment : Path
    {
        public PathToEnlightenment()
        {
            Types = new Type[] {
                // START: Adventure Mode
                typeof(AboutAsserts),
                typeof(AboutNull),
                typeof(AboutArrays),
                typeof(AboutArrayAssignment),
                typeof(AboutStrings),
                typeof(AboutFloats),
                typeof(AboutControlStatements),
                typeof(AboutMethods),
                // END: Adventure Mode

                // START: Explorer mode
                // typeof(AboutLambdas),
                // typeof(AboutLinq),
                // typeof(AboutInheritance),
                // END: Explorer Mode

                // START: Epic mode
                // typeof(AboutDelegates),
                // typeof(AboutGenericContainers),
                // typeof(AboutBitwiseAndShiftOperator),
                };
        }
    }
}