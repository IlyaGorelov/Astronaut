using System.Collections;
using System.Linq;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public static bool canChangePos = false;
    [SerializeField] AttachToPlanet attach;
    [SerializeField] SpawnPlanets spawns;
    [SerializeField] float moveSpeed;
    private Vector3 target;

    private void Start()
    {
        target = transform.position;
    }

    private void Update()
    {
        if (spawns.planets.Count > 0)
        {

            switch (spawns.planets.Last().type)
            {
                case 0:
                case (PlanetType.planet)2:
                case (PlanetType.planet)4:
                case (PlanetType.planet)6:
                    target = new Vector3(attach.planet.transform.position.x + 5, attach.planet.transform.position.y + 2, -1);
                    transform.position = Vector3.Lerp(transform.position, target, moveSpeed * Time.deltaTime);
                    canChangePos = false;
                    break;
                case (PlanetType.planet)1:
                case (PlanetType.planet)3:
                case (PlanetType.planet)5:
                case (PlanetType.planet)7:
                    target = new Vector3(attach.planet.transform.position.x - 5, attach.planet.transform.position.y + 2, -1);
                    transform.position = Vector3.Lerp(transform.position, target, moveSpeed * Time.deltaTime);
                    canChangePos = false;
                    break;


            }
        }


    }

}
