﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Microsoft.UI.Xaml.Data;
using Snap.Hutao.Core.ExceptionService;

namespace Snap.Hutao.UI.Xaml.Data.Converter;

internal sealed class Int32ToBoolConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        return value is not null and not 0;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw HutaoException.NotSupported();
    }
}