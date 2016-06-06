﻿/*============================================================================
 * Copyright (C) Microsoft Corporation, All rights reserved.
 *============================================================================
 */

using System;
using Microsoft.Management.Infrastructure.Native;

namespace Microsoft.Management.Infrastructure.Internal
{
    internal static class InstanceHandleExtensionMethods
    {
        public static MI_Instance Clone(this MI_Instance handleToClone)
        {
            if (handleToClone == null || handleToClone.IsNull)
            {
                throw new ArgumentNullException();
            }

            MI_Instance clonedHandle;
            MI_Result result = handleToClone.Clone(out clonedHandle);
            CimException.ThrowIfMiResultFailure(result);
            return clonedHandle;
        }
    }
}