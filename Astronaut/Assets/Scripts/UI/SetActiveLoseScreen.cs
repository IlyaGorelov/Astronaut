using UnityEngine;
using YG;
public class SetActiveLoseScreen : MonoBehaviour
{
    [SerializeField] GameObject LoseScreen;
    private int record;

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
        if (YandexGame.SDKEnabled)
            Load();
    }

    private void Load()
    {
        record = YandexGame.savesData.record;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            if (record < ScoreState.score)
            {
                record=ScoreState.score;
                YandexGame.savesData.record = record;
                YandexGame.SaveProgress();
            }
            ScoreState.score = 0;
            YandexGame.FullscreenShow();
            LoseScreen.SetActive(true);
        }
    }
}
