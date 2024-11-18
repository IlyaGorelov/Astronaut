using UnityEngine;
using YG;

public class SetListenerVolumeInMenu : MonoBehaviour
{
    [SerializeField] GameObject bUnmute;

    private void OnEnable()
    {
        YandexGame.GetDataEvent += Load;
    }

    private void OnDisable()
    {
        YandexGame.GetDataEvent -= Load;
    }

    private void Start()
    {
        if (YandexGame.SDKEnabled) Load();
    }

    private void Load()
    {
        int i = YandexGame.savesData.isMuted;

        if (i == 1)
        {
            bUnmute.SetActive(true);
            AudioListener.volume = 0;
        }

        else AudioListener.volume = 1;
    }


}
