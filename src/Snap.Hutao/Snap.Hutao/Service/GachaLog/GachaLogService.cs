﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

namespace Snap.Hutao.Service.GachaLog;

/// <summary>
/// 祈愿记录服务
/// </summary>
[Injection(InjectAs.Transient, typeof(IGachaLogService))]
internal class GachaLogService : IGachaLogService
{
    public GachaLogService()
    {

    }


}