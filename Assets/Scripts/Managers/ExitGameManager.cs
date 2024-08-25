using UnityEngine;

namespace Managers
{
    public class ExitGameManager : MonoBehaviour
    { 
        public void ExitGame()
        {
#if UNITY_EDITOR
        
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}