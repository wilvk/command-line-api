﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace System.CommandLine.Binding
{
    internal class SystemConsoleFactory : IConsoleFactory
    {
        public IConsole CreateConsole(BindingContext invocationContext) => new SystemConsole();
    }
}