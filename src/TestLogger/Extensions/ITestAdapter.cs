// Copyright (c) Spekt Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Spekt.TestLogger.Extensions
{
    using System.Collections.Generic;
    using Spekt.TestLogger.Core;

    public interface ITestAdapter
    {
        List<TestResultInfo> TransformResults(
            List<TestResultInfo> results,
            List<TestMessageInfo> messages);
    }
}