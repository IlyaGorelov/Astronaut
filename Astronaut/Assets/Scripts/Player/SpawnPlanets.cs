using UnityEngine;

public class SpawnPlanets : MonoBehaviour
{
    [SerializeField] Transform spawnHeight;
    [SerializeField] GameObject[] planet;
    [SerializeField] float left;
    [SerializeField] float right;
    public static bool canSpawn=false;
    [SerializeField] float delta=9;


    private void Update()
    {
        if(canSpawn)
        Spawn();
    }

    private void Spawn()
    {
        spawnHeight.position += new Vector3(0,delta,0);
        canSpawn = false;
        int r = Random.Range(0, planet.Length);
        float r2 = Random.Range(left, right);

        Vector2 spawnpoint = new Vector2(r2, spawnHeight.transform.position.y);
         Instantiate(planet[r], spawnpoint, Quaternion.identity);
        
    }
}
