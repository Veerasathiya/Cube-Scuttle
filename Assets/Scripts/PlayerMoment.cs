using UnityEngine;

public class PlayerMoment : MonoBehaviour
{
    private Rigidbody rb;

    private bool canJumb;

    public int forceCount = 1;
    public float forward = 1000f;
    public float ControllLF = 500f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //Controlls
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forward * Time.deltaTime);

        if(canJumb)
        {
            canJumb = false;
            rb.AddForce(0, forceCount, 0, ForceMode.Impulse);
            
        }

        

        if(Input.GetKey("a"))
        {
            rb.AddForce(-ControllLF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if (Input.GetKey("d"))
        {
            rb.AddForce(ControllLF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            canJumb = true;
        }
    }
}
