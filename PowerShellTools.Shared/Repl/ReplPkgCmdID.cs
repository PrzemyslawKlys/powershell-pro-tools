﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

// PkgCmdID.cs
// MUST match PkgCmdID.h

namespace PowerShellTools.Repl
{
    public static class PkgCmdIDList
    {
        public const uint cmdidSmartExecute = 0x103;
        public const uint cmdidBreakRepl = 0x104;
        public const uint cmdidResetRepl = 0x105;
        public const uint cmdidReplHistoryNext = 0x0106;
        public const uint cmdidReplHistoryPrevious = 0x0107;
        public const uint cmdidReplClearScreen = 0x0108;
        public const uint cmdidBreakLine = 0x0109;
        public const uint cmdidReplSearchHistoryNext = 0x010A;
        public const uint cmdidReplSearchHistoryPrevious = 0x010B;
        public const uint cmdidEnterSession = 0x010C;
        public const uint cmdidExitSession = 0x010D;
        public const uint cmdidOpenConsole = 0x010E;
        public const uint menuIdReplToolbar = 0x2000;

        public const uint comboIdReplScopes = 0x3000;
        public const uint comboIdReplScopesGetList = 0x3001;
    };
}
