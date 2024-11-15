using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public void Re()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
