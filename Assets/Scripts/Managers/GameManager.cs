using Controllers;
using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        private int _numberLives = 3;
        
        [SerializeField]
        private SpriteRenderer[] _livesSprites;
        [SerializeField]
        private GameObject _player;
        [SerializeField]
        private GameObject _loseMenu;
        [SerializeField]
        private GameObject _gameMenu;
    
        private void Awake()
        {
            Instance = this;
        }

        public void LoseLife()
        {
            _numberLives--;
            _livesSprites[_numberLives].enabled = false;

            if (_numberLives <= 0)
            {
                EndGame();
            }
        }
    
        private void EndGame()
        {
            _player.GetComponent<PlayerController>().enabled = false;
            _loseMenu.SetActive(true);
            _gameMenu.SetActive(false);
            Time.timeScale = 0;
        }
    }
}