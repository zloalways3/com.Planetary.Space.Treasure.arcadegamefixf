using Other;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controllers
{
    public class LoadingScenesController : MonoBehaviour
    {
        public void LoadingBootScreen()
        {
            SceneManager.LoadScene(GlobalConstants.LOADING_SCENE);
        }
        public void LoadingGameScene()
        {
            SceneManager.LoadScene(GlobalConstants.GAME_SCENE);
        }
        
    }
}