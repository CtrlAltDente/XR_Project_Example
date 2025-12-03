using UnityEngine;
using UnityEngine.Events;

namespace XR_Project_Example.Core.Triggers
{
    public class TriggerEvents : MonoBehaviour
    {
        [SerializeField]
        private bool _trackEnter;
        [SerializeField]
        private bool _trackStay;
        [SerializeField]
        private bool _trackExit;

        public UnityEvent<Collider> OnTriggerEnterEvent;
        public UnityEvent<Collider> OnTriggerStayEvent;
        public UnityEvent<Collider> OnTriggerExitEvent;

        private void OnTriggerEnter(Collider other)
        {
            if (_trackEnter)
            {
                OnTriggerEnterEvent?.Invoke(other);
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (_trackStay)
            {
                OnTriggerStayEvent?.Invoke(other);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (_trackExit)
            {
                OnTriggerExitEvent?.Invoke(other);
            }
        }
    }
}