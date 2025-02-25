using TMPro;
using UnityEngine;
using YG;
using YG.Utils.LB;

public class GetRecord : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI recText;
    [SerializeField] TextMeshProUGUI rankText;
    private int rec;

    private void OnEnable()
    {
        YandexGame.GetDataEvent += Load;
        YandexGame.onGetLeaderboard += GetRank;
    }

    private void OnDisable()
    {
        YandexGame.GetDataEvent -= Load;
        YandexGame.onGetLeaderboard -= GetRank;
    }

    private void Start()
    {
        if (YandexGame.SDKEnabled)
            Load();
        recText.text = rec.ToString();
        ScoreState.score=0;
    }

    private void GetRank(LBData data)
    {
        print("get");
        rankText.text = data.thisPlayer.rank.ToString();
    }

    public void GoToDevelop()
    {
        Application.OpenURL("https://yandex."+YandexGame.EnvironmentData.domain+"/games/developer/104556");
    }

    private void Load()
    {
        rec = YandexGame.savesData.record;
    }
}
