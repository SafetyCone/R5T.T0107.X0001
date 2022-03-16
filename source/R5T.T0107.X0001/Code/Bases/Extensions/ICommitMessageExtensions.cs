using System;

using R5T.T0107;
using R5T.T0107.X0001;


namespace System
{
    public static class ICommitMessageGeneratorExtensions
    {
        public static string AddGitIgnoreFile(this ICommitMessage _)
        {
            return CommitMessages.AddGitIgnoreFile;
        }

        public static string AddInitialSolution(this ICommitMessage _)
        {
            return CommitMessages.AddInitialSolution;
        }

        public static string InitialSourceStubCommit(this ICommitMessage _)
        {
            return CommitMessages.InitialSourceStubCommit;
        }
    }
}
