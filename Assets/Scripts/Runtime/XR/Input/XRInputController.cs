using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.Runtime.XR.Input
{
    [DefaultExecutionOrder(-50)]
    public class XRInputController : MonoBehaviour, IXRControllerValue
    {
        [SerializeField] private InputActionReference xrPositionInputActionRef;
        [SerializeField] private InputActionReference xrRotationInputActionRef;

        [SerializeField] private InputActionReference xrTriggerInputActionRef;
        [SerializeField] private InputActionReference xrGripInputActionRef;

        [SerializeField] private GameObject visualizedControllerObject;

        public Vector3 ControllerWorldPosition {get;private set;}
        public Quaternion ControllerWorldRotation { get; private set; }
        public bool IsGripActivated {get;private set;}
        public bool IsGripActivatedAtFrame {get;private set;}
        public bool IsTriggerActivated {get;private set;}
        public bool IsTriggerActivatedAtFrame {get;private set;}


        private void Update()
        {
            var xrPos = xrPositionInputActionRef.action.ReadValue<Vector3>();
            ControllerWorldPosition = xrPos;
            var xrRot = xrRotationInputActionRef.action.ReadValue<Quaternion>();
            ControllerWorldRotation = xrRot;
        }
    }
}