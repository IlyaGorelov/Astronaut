using UnityEngine;
using YG;

public class ActDifMenu : MonoBehaviour
{
    [SerializeField] GameObject DesktopUI;
    [SerializeField] GameObject PhoneUI;
    
        private void Start()
    {
        if(YandexGame.EnvironmentData.deviceType == "desktop")
        {
            DesktopUI.SetActive(true);
        }else 
            PhoneUI.SetActive(true);
    }

}
