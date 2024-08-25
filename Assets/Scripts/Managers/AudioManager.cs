using Other;
using UnityEngine;
using UnityEngine.Audio;

namespace Managers
{
    public class AudioManager : MonoBehaviour
    {
        [SerializeField] private AudioMixer audioMixer;

        public void SetMusicVolume(float volume)
        {
            audioMixer.SetFloat(GlobalConstants.MUSIC_NAME, volume);
        }

        public void SetSoundVolume(float volume)
        {
            audioMixer.SetFloat(GlobalConstants.SOUND_NAME, volume);
        }
    }
}