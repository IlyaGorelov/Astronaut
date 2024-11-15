using UnityEngine;

public class FreezeTime : MonoBehaviour
{
    [SerializeField] GameObject[] UIs;

    private void Update()
    {
        int i = 0;
        foreach (GameObject go in UIs) 
        {
            if (go.activeSelf) i++;
        }
        if(i>0)
            Time.timeScale = 0;
        else Time.timeScale = 1;
    }
}
