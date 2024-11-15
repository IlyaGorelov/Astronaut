using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(0, 0, speed*Time.deltaTime);
    }
}
