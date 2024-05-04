﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

namespace Snap.Hutao.Win32.Graphics.Direct3D11;

internal enum D3D11_FILTER
{
    D3D11_FILTER_MIN_MAG_MIP_POINT = 0,
    D3D11_FILTER_MIN_MAG_POINT_MIP_LINEAR = 1,
    D3D11_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT = 4,
    D3D11_FILTER_MIN_POINT_MAG_MIP_LINEAR = 5,
    D3D11_FILTER_MIN_LINEAR_MAG_MIP_POINT = 16,
    D3D11_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 17,
    D3D11_FILTER_MIN_MAG_LINEAR_MIP_POINT = 20,
    D3D11_FILTER_MIN_MAG_MIP_LINEAR = 21,
    D3D11_FILTER_ANISOTROPIC = 85,
    D3D11_FILTER_COMPARISON_MIN_MAG_MIP_POINT = 128,
    D3D11_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR = 129,
    D3D11_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT = 132,
    D3D11_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR = 133,
    D3D11_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT = 144,
    D3D11_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 145,
    D3D11_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT = 148,
    D3D11_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR = 149,
    D3D11_FILTER_COMPARISON_ANISOTROPIC = 213,
    D3D11_FILTER_MINIMUM_MIN_MAG_MIP_POINT = 256,
    D3D11_FILTER_MINIMUM_MIN_MAG_POINT_MIP_LINEAR = 257,
    D3D11_FILTER_MINIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT = 260,
    D3D11_FILTER_MINIMUM_MIN_POINT_MAG_MIP_LINEAR = 261,
    D3D11_FILTER_MINIMUM_MIN_LINEAR_MAG_MIP_POINT = 272,
    D3D11_FILTER_MINIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 273,
    D3D11_FILTER_MINIMUM_MIN_MAG_LINEAR_MIP_POINT = 276,
    D3D11_FILTER_MINIMUM_MIN_MAG_MIP_LINEAR = 277,
    D3D11_FILTER_MINIMUM_ANISOTROPIC = 341,
    D3D11_FILTER_MAXIMUM_MIN_MAG_MIP_POINT = 384,
    D3D11_FILTER_MAXIMUM_MIN_MAG_POINT_MIP_LINEAR = 385,
    D3D11_FILTER_MAXIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT = 388,
    D3D11_FILTER_MAXIMUM_MIN_POINT_MAG_MIP_LINEAR = 389,
    D3D11_FILTER_MAXIMUM_MIN_LINEAR_MAG_MIP_POINT = 400,
    D3D11_FILTER_MAXIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 401,
    D3D11_FILTER_MAXIMUM_MIN_MAG_LINEAR_MIP_POINT = 404,
    D3D11_FILTER_MAXIMUM_MIN_MAG_MIP_LINEAR = 405,
    D3D11_FILTER_MAXIMUM_ANISOTROPIC = 469,
}