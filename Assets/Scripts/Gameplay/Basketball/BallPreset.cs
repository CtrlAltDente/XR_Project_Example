using System;
using UnityEngine;

namespace XR_Project_Example.Gameplay.Basketball
{
    [Serializable]
    public struct BallPreset
    {
        public Ball Ball;
        public Transform PositionPoint;

        public void ResetBall()
        {
            Ball.gameObject.SetActive(true);
            Ball.ResetVelocity();
            Ball.transform.position = PositionPoint.position;
        }
    }
}