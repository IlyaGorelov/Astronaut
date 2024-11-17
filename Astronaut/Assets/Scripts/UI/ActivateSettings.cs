using UnityEngine;

public class ActivateSettings : MonoBehaviour
{
    [SerializeField] GameObject SettingsUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        { 
            SettingsUI.SetActive(!SettingsUI.activeSelf);

        }
    }
}
