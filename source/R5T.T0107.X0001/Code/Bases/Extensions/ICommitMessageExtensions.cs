using System;

using R5T.T0107;
using R5T.T0107.X0001;


namespace System
{
    public static class ICommitMessageGeneratorExtensions
    {
        [Obsolete("See R5T.Z0036.ICommitMessage.AddGitIgnoreFile")]
        public static string AddGitIgnoreFile(this ICommitMessage _)
        {
            return CommitMessages.AddGitIgnoreFile;
        }

        [Obsolete("See R5T.Z0036.ICommitMessage.AddInitialSolution")]
        public static string AddInitialSolution(this ICommitMessage _)
        {
            return CommitMessages.AddInitialSolution;
        }

        [Obsolete("See R5T.Z0036.ICommitMessage.InitialSourceStubCommit.")]
        public static string InitialSourceStubCommit(this ICommitMessage _)
        {
            return CommitMessages.InitialSourceStubCommit;
        }
    }
}
