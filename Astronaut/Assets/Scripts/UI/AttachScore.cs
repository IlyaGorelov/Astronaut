using TMPro;
using UnityEngine;

public class AttachScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreInt;

    private void Update()
    {
        scoreInt.text = ScoreState.score.ToString();
    }
}
