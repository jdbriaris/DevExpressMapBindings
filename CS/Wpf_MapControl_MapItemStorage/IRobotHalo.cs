// Copyright (C) 2019 Koffi Co. - All Rights Reserved
// Created 30/05/2019 at 9:02 PM
// Last updated 30/05/2019 at 9:02 PM by James Briaris

using DevExpress.Xpf.Map;

namespace Wpf_MapControl_MapItemStorage
{
    public interface IRobotHalo
    {
        GeoPoint Location { get; set; }

        bool IsActive { get; set; }

        double Thickness { get; set; }
    }
}