using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public static bool canChangePos = false;
    [SerializeField] AttachToPlanet attach;

    private void Update()
    {
        if (canChangePos)
        {
            transform.position = new Vector3(0, attach.planet.transform.position.y+4, -1);
            canChangePos = false;
        }
    }
}
