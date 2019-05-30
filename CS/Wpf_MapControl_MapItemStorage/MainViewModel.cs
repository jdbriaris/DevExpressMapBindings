// Copyright (C) 2019 Koffi Co. - All Rights Reserved
// Created 30/05/2019 at 9:11 PM
// Last updated 30/05/2019 at 9:11 PM by James Briaris

using DevExpress.Mvvm;
using DevExpress.Xpf.Map;
using DevExpress.XtraRichEdit.Commands;

namespace Wpf_MapControl_MapItemStorage
{
    // This will be similar to ProvingGroundMapViewModel
    public class MainViewModel : ViewModelBase
    {
        public DelegateCommand ClearCommand { get; set; }
        public DelegateCommand ShowCommand { get; set; }
        public DelegateCommand UpdateCommand { get; set; }

        public RobotHighlightViewModel RobotHighlightViewModel { get; }

        public MainViewModel()
        {
            RobotHighlightViewModel = new RobotHighlightViewModel();

            ClearCommand = new DelegateCommand(() => RobotHighlightViewModel.Clear());
            ShowCommand = new DelegateCommand(Show);
            UpdateCommand = new DelegateCommand(() => RobotHighlightViewModel.UpdateThickness());
        }

        public void Show()
        {
            var halo1 = new RobotHalo(1, new GeoPoint(51.30, 0.07));
            var halo2 = new RobotHalo(2, new GeoPoint(52.31, 13.23));
            var halo3 = new RobotHalo(3, new GeoPoint(41.54, 12.3));
            var halo4 = new RobotHalo(4, new GeoPoint(40.23, -3.43));

            RobotHighlightViewModel.Add(halo1);
            RobotHighlightViewModel.Add(halo2);
            RobotHighlightViewModel.Add(halo3);
            RobotHighlightViewModel.Add(halo4);
        }
    }
}