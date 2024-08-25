using System.Collections;
using Other;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controllers
{
    public class LoadingSceneController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _loadingText;
        private float _dotTimer;
        private int _dotCount;
        private const float DOT_INTERVAL = 0.5f;

        private void Start()
        {
            StartCoroutine(LoadMainScene(GlobalConstants.MENY_SCENE));
        }

        private IEnumerator LoadMainScene(string nameScene)
        {
            var asyncOperation = SceneManager.LoadSceneAsync(nameScene);

            asyncOperation.allowSceneActivation = false;

            while (!asyncOperation.isDone)
            {
                UpdateLoadingText();
                
                if (asyncOperation.progress >= 0.9f)
                {
                        asyncOperation.allowSceneActivation = true;
                }

                yield return null;
            }
        }

        private void UpdateLoadingText()
        {
            _dotTimer += Time.deltaTime;

            if (_dotTimer >= DOT_INTERVAL)
            {
                _dotCount = (_dotCount + 1) % 4;
                var dots = new string('.', _dotCount);
                _loadingText.text = "Loading" + dots;
                _dotTimer = 0f;
            }
        }
    }
}