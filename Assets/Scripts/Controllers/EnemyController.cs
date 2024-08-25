using Managers;
using Other;
using UnityEngine;

namespace Controllers
{
    public class EnemyController: MonoBehaviour
    { 
        private AudioSource _audioSource;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag(GlobalConstants.PLAYER_TAG))
            {
                    _audioSource.Play();
                    GetComponent<Renderer>().enabled = false; 
                    GetComponent<Collider2D>().enabled = false;
                    GameManager.Instance.LoseLife(); 
                    Destroy(gameObject, _audioSource.clip.length);
            }
        }
    }
}