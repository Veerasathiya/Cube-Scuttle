using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    private PlayerMoment movement;

    public GameObject cylinder;
    



    void Start()
    {
        movement = GetComponent<PlayerMoment>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "collisionWithDef")    
        {
            
            movement.enabled = false;
            //cylinder.GetComponent<CylinderMoving>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }


}
