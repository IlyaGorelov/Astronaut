using UnityEngine;

public class AttachToPlanet : MonoBehaviour
{
    public GameObject planet;
    [SerializeField] SpawnPlanets spawnPlanets;
    private bool isFirstTime = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 0)
        {
            gameObject.transform.SetParent(collision.transform);
            if (!isFirstTime && collision.gameObject.layer == 6)
            {
                print(collision.gameObject.layer);
                spawnPlanets.Spawn(collision.gameObject.transform);
                MoveCamera.canChangePos = true;
                planet = collision.gameObject;
            }
            else isFirstTime = false;
            Vector2 rotDir = transform.position - collision.transform.position;

            gameObject.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            float ang = Vector2.Angle(rotDir, transform.up);
            Vector3 rotA = new Vector3(0, 0, -ang);
            transform.Rotate(rotA);
            while (ang > 1 || ang < -1)
            {
                ang = Vector2.Angle(rotDir, transform.up);
                Vector3 rotAq = new Vector3(0, 0, -ang);
                transform.Rotate(rotAq);

            }
            PlayerController.isOnPlanet = true;
            collision.gameObject.GetComponentInParent<AttractionByPlanet>().force = 0;

        }
    }





    private void OnCollisionExit2D(Collision2D collision)
    {

        PlayerController.isOnPlanet = false;
        gameObject.transform.SetParent(null);

    }


}
