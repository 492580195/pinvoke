﻿// Copyright (c) to owners found in https://github.com/AArnott/pinvoke/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

using System;
using System.IO;
using PInvoke;
using Xunit;
using static PInvoke.Kernel32;

public partial class Kernel32
{
    [Fact]
    public void Win32Exception_NativeErrorCode()
    {
        Win32ErrorCode error = Win32ErrorCode.ERROR_ALREADY_FIBER;
        var ex = new Win32Exception(error);
        Assert.Equal(error, ex.NativeErrorCode);
    }

    [Fact]
    public void Win32Exception_Message()
    {
        Win32ErrorCode error = Win32ErrorCode.ERROR_INVALID_LABEL;
        var ex = new Win32Exception(error);
        Assert.Equal("Indicates a particular Security ID may not be assigned as the label of an object", ex.Message);
    }

    [Fact]
    public void Win32Exception_CodeAndMessage()
    {
        Win32ErrorCode error = Win32ErrorCode.ERROR_ALREADY_FIBER;
        var ex = new Win32Exception(error, "msg");
        Assert.Equal(error, ex.NativeErrorCode);
        Assert.Equal("msg", ex.Message);
    }
}
