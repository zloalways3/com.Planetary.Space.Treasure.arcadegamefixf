using TMPro;
using UnityEngine;

namespace Controllers
{
    public class ScoreController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI[] _scoreText;

        private int _points;
    
        private void Start()
        {
            UpdateScoreText();
        }

        public void AddPoints(int amount)
        {
            _points += amount;
            UpdateScoreText();
        }

        private void UpdateScoreText()
        {
            if (_scoreText != null)
            {
                foreach (var scoreText in _scoreText)
                {
                    scoreText.text = "Points: " + _points.ToString("D3");
                }
            }
        }
    }
}