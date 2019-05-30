// Copyright (C) 2019 Koffi Co. - All Rights Reserved
// Created 30/05/2019 at 9:03 PM
// Last updated 30/05/2019 at 9:03 PM by James Briaris

using DevExpress.Mvvm;
using DevExpress.Xpf.Map;

namespace Wpf_MapControl_MapItemStorage
{
    public class RobotHalo : ViewModelBase, IRobotHalo
    {
        private int _robotId;

        public GeoPoint Location
        {
            get => GetProperty(() => Location);
            set => SetProperty(() => Location, value);
        }

        public bool IsActive
        {
            get => GetProperty(() => IsActive);
            set => SetProperty(() => IsActive, value);
        }

        public double Thickness
        {
            get => GetProperty(() => Thickness);
            set => SetProperty(() => Thickness, value);
        }

        public RobotHalo(int robotId, GeoPoint location)
        {
            _robotId = robotId;
            Location = location;
            Thickness = 10;
        }

        public void OnViewportZoomChanged(int zoomLevel)
        {
            // TODO: Hook into message to perform updates on the fly
        }
    }
}