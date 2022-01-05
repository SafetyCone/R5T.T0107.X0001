using System;

using R5T.T0107;
using R5T.T0107.X0001;


namespace System
{
    public static class ICommitMessageGeneratorExtensions
    {
        public static string InitialSourceStubCommit(this ICommitMessage _)
        {
            return CommitMessages.InitialSourceStubCommit;
        }
    }
}
