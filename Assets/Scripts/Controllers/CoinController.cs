using Other;
using UnityEngine;

namespace Controllers
{
    public class CoinController : MonoBehaviour
    {
        [SerializeField] private AudioSource _audioSource;
    
        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }
    
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag(GlobalConstants.PLAYER_TAG))
            {
                _audioSource.Play();
                var scoreController = collision.GetComponent<ScoreController>();
                if (scoreController != null)
                {
                    scoreController.AddPoints(1);
                    GetComponent<Renderer>().enabled = false; 
                    GetComponent<Collider2D>().enabled = false;
                    Destroy(gameObject, _audioSource.clip.length);
                }
            }
        }
    }
}