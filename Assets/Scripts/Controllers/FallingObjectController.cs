using UnityEngine;

namespace Controllers
{
    public class FallingObjectController : MonoBehaviour
    {
        private readonly float _fallSpeed = 3f;
        private readonly float _spawnXRange = 2.5f;

        private void Start()
        {
            var randomX = Random.Range(-_spawnXRange, _spawnXRange);
            if (Camera.main != null) transform.position = new Vector3(randomX, Camera.main.orthographicSize + 1, 0);
        }

        private void Update()
        {
            transform.Translate(Vector3.down * _fallSpeed * Time.deltaTime);
        
            if (Camera.main != null && transform.position.y < -Camera.main.orthographicSize - 1)
            {
                Destroy(gameObject);
            }
        }
    }
}