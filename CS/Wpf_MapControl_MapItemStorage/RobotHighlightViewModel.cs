// Copyright (C) 2019 Koffi Co. - All Rights Reserved
// Created 30/05/2019 at 8:40 PM
// Last updated 30/05/2019 at 8:40 PM by James Briaris

using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;

namespace Wpf_MapControl_MapItemStorage
{
    public class RobotHighlightViewModel : ViewModelBase
    {
        public ObservableCollection<IRobotHalo> ViewModels { get; }

        public RobotHighlightViewModel()
        {
            ViewModels = new ObservableCollection<IRobotHalo>();
        }

        public void Add(IRobotHalo robotHalo)
        {
            ViewModels.Add(robotHalo);
        }

        public void Clear()
        {
            ViewModels.Clear();
        }

        public void UpdateThickness()
        {
            ViewModels.ForEach(x => x.Thickness = 20);
        }
    }
}