using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject loadUI;
    [SerializeField] Slider slider;
    private int levelId;

    
    public void Load(int level)
    {
        levelId = level;
            loadUI.SetActive(true);
            StartCoroutine(LoadLevelAsync());

        
    }

    

    IEnumerator LoadLevelAsync()
    {
        AsyncOperation load = SceneManager.LoadSceneAsync(levelId);


        while (!load.isDone)
        {
            slider.value = load.progress;

            yield return null;
        }
    }
}
