using UnityEngine;

public class SpawnScoreCoins : MonoBehaviour
{
    [SerializeField] GameObject ScoreCoins;

    void Start()
    {
        int rand = Random.Range(0, 3);
        if (rand == 1)
            ScoreCoins.SetActive(true);
        
    }
}
