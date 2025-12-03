using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

namespace XR_Project_Example.XR
{
    public class HandAnimatorController : MonoBehaviour
    {
        [SerializeField]
        private InputActionReference _gripAction;
        [SerializeField]
        private InputActionReference _triggerAction;

        [SerializeField]
        private Animator _animator;

        private void OnEnable()
        {
            SubscribeOnEvents();
        }

        private void OnDisable()
        {
            UnsubscribeFromEvents();
        }

        private void SubscribeOnEvents()
        {
            _gripAction.action.performed += WriteGripValue;
            _gripAction.action.canceled += WriteGripValue;

            _triggerAction.action.performed += WriteTriggerValue;
            _triggerAction.action.canceled += WriteTriggerValue;
        }

        private void UnsubscribeFromEvents()
        {
            _gripAction.action.performed -= WriteGripValue;
            _gripAction.action.canceled -= WriteGripValue;

            _triggerAction.action.performed -= WriteTriggerValue;
            _triggerAction.action.canceled -= WriteTriggerValue;
        }

        private void WriteGripValue(CallbackContext callbackContext)
        {
            _animator.SetFloat("Grip", callbackContext.ReadValue<float>());
        }

        private void WriteTriggerValue(CallbackContext callbackContext)
        {
            _animator.SetFloat("Trigger", callbackContext.ReadValue<float>());
        }
    }
}