using UnityEngine;
using UnityEngine.UI;

namespace System
{
    public class TimerSystem : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private GameObject _complite;
        [SerializeField] private GameObject _gameObject;
    
        private float _timeRemaining = 60f;
        private bool _isTimerRunning;

        private void Start()
        {
            _slider.maxValue = _timeRemaining;
            _slider.value = _timeRemaining;
            _isTimerRunning = true;
            Time.timeScale = 1f;
        }

        private void Update()
        {
            if (_isTimerRunning)
            {
                if (_timeRemaining > 0)
                {
                    _timeRemaining -= Time.deltaTime;
                    _slider.value = _timeRemaining;
                }
                else
                {
                    _timeRemaining = 0;
                    _isTimerRunning = false;
                    _complite.SetActive(true);
                    _gameObject.SetActive(false);
                    Time.timeScale = 0f;
                }
            }
        }
    }
}