using UnityEngine;

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private float _smoothing = 0.1f;
        private Vector3 _touchPosition;
        private bool _isDragging = false;
    
        private Camera _mainCamera;
    
        private void Start()
        {
            _mainCamera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _isDragging = true;
            }
            if (Input.GetMouseButtonUp(0))
            {
                _isDragging = false;
            }

            if (_isDragging)
            {
                _touchPosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
                _touchPosition.z = 0;
            
                var clampedPosition = _touchPosition;
                clampedPosition.x = Mathf.Clamp(clampedPosition.x, -_mainCamera.orthographicSize * _mainCamera.aspect, _mainCamera.orthographicSize * _mainCamera.aspect);
                var orthographicSize = _mainCamera.orthographicSize;
                clampedPosition.y = Mathf.Clamp(clampedPosition.y, -orthographicSize, orthographicSize);
            
                transform.position = Vector3.Lerp(transform.position, clampedPosition, _smoothing);
            }
        }
    }
}