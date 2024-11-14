using UnityEngine;

public class AttachToPlanet : MonoBehaviour
{
    public GameObject planet;
    private bool isFirstTime = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            if(!isFirstTime)
            MoveCamera.canChangePos = true;
            else isFirstTime = false;
            planet= collision.gameObject;
            SpawnPlanets.canSpawn = true;
            collision.gameObject.GetComponentInParent<AttractionByPlanet>().force = 0;
            gameObject.transform.SetParent(collision.transform);
            gameObject.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            Vector2 rotDir = transform.position - collision.transform.position;
 
            float ang = Vector2.Angle(rotDir, transform.up);
            Vector3 rotA = new Vector3(0, 0, -ang);
            transform.Rotate(rotA);
            while (ang != 0)
            {
                 ang = Vector2.Angle(rotDir, transform.up);
                Vector3 rotAq = new Vector3(0, 0, -ang);
                transform.Rotate(rotAq);
            }
        }
    }

    

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            gameObject.transform.SetParent(null);
        }
    }

    
}
