using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Runtime.XR.Input
{
    interface IXRControllerValue
    {
        Vector3 ControllerWorldPosition { get; }
        Quaternion ControllerWorldRotation { get; }

        bool IsGripActivated { get; }
        bool IsGripActivatedAtFrame { get; }
        bool IsTriggerActivated { get; }
        bool IsTriggerActivatedAtFrame { get; }
    }
}
