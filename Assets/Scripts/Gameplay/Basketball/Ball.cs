using UnityEngine;

namespace XR_Project_Example.Gameplay.Basketball
{
    public class Ball : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody _rigidbody;

        public void ResetVelocity()
        {
            _rigidbody.linearVelocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
        }
    }
}