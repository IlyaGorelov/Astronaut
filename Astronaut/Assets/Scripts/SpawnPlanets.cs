using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanets : MonoBehaviour
{
    [SerializeField] Transform spawnHeight;
    public List<PlanetType> planets;
    [SerializeField] GameObject[] planet;
    private float left;
    private float right;
    public static bool canSpawn=false;
    [SerializeField] float delta=9;

    private void Start()
    {
        Vector2 width = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        planets = new();
        left =-width.x/4;
        right =width.x/4;
    }

    

    public void Spawn(Transform p)
    {
        canSpawn = false;
        int r = Random.Range(0, planet.Length);

        var a= Instantiate(planet[r], p.position, Quaternion.identity);
        planets.Add(a.GetComponent<PlanetType>());
        if (planets.Count > 4)
        {
            Destroy(planets[0].gameObject);
            planets.RemoveAt(0);
        }
        
    }
}
