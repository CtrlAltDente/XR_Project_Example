using TMPro;
using UnityEngine;
using XR_Project_Example.Core.Objects;

namespace XR_Project_Example.Gameplay.Basketball
{
    public class BasketballManager : MonoBehaviour
    {
        [SerializeField]
        private BallPreset[] _ballPresets; 

        [SerializeField]
        private TextMeshProUGUI _scoreLabel;

        private int _score;

        private void Start()
        {
            ResetGame();
        }

        public void AddScore()
        {
            _score++;
            DisplayScore();
        }

        public void ResetGame()
        {
            _score = 0;
            DisplayScore();

            foreach(var ballPreset in _ballPresets)
            {
                ballPreset.ResetBall();
            }
        }

        private void DisplayScore()
        {
            _scoreLabel.SetText($"Score: {_score}");
        }
    }
}