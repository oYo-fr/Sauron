using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sauron.Commands
{
    public enum PtzCommandTypeEnum
    {
        Up,
        Down,
        Left,
        Right,
        ZoomTele,
        ZoomWide,
        FocusNear,
        FocusFar,
        IrisLarge,
        IrisSmall,
        GotoPreset,
        SetPreset,
        ClearPreset,
        StartTour,
        StopTour,
        LeftUp,
        RightUp,
        LeftDown,
        RightDown,
        AddTour,
        DelTour,
        ClearTour,
        AutoPanOn,
        AutoPanOff,
        SetLeftLimit,
        SetRightLimit,
        AutoScanOn,
        AutoScanOff,
        SetPatternBegin,
        SetPatternEnd,
        StartPattern,
        StopPattern,
        ClearPattern,
        AlarmSearch,
        Position,
        AuxOn,
        AuxOff,
        Menu,
        Exit,
        Enter,
        MenuUp,
        MenuDown,
        MenuLeft,
        MenuRight,
        Reset,
        LightController,
        PositionABS,
        PositionReset,
        Continuously
    }
}
