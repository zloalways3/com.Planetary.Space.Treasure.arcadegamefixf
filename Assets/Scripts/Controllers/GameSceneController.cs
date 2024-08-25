using Managers;
using TMPro;
using UnityEngine;

namespace Controllers
{
    public class GameSceneController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI[] _levelText;
        
        private int _currentLevel;
        
        private void Start()
        {
            _currentLevel = PlayerPrefs.GetInt("CurrentLevel", 0);
            for (int i = 0; i < _levelText.Length; i++)
            {
                _levelText[i].text = "Level " + _currentLevel;
            }
        }

        public void WinGame()
        {
            PlayerPrefs.SetInt("CurrentLevel", _currentLevel+1);
            PlayerPrefs.Save();
            var levelManager = FindObjectOfType<LevelManager>();
            levelManager.WinLevel(_currentLevel);
        }
    }
}