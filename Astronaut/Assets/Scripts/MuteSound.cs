using UnityEngine;
using YG;

public class MuteSound : MonoBehaviour
{
    public void Mute()
    {
        if (AudioListener.volume != 0)
        {
            AudioListener.volume = 0;
            YandexGame.savesData.isMuted = 1;
        }
        else
        {
            YandexGame.savesData.isMuted = 0;
            AudioListener.volume = 1;
        }
        YandexGame.SaveProgress();
    }
}
