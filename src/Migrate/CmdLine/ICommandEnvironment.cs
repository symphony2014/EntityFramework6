// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace CmdLine
{
    internal interface ICommandEnvironment
    {
        string CommandLine { get; }

        string[] GetCommandLineArgs();

        string Program { get; }
    }
}
