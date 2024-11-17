using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartLevel : MonoBehaviour
{
    [SerializeField] GameObject loadUI;
    [SerializeField] Slider slider;
    public void Re()
    {
        loadUI.SetActive(true);
        StartCoroutine(LoadLevelAsync());
    }


    IEnumerator LoadLevelAsync()
    {
        int id = SceneManager.GetActiveScene().buildIndex;
        AsyncOperation load = SceneManager.LoadSceneAsync(id);


        while (!load.isDone)
        {
            slider.value = load.progress;

            yield return null;
        }
    }
}
