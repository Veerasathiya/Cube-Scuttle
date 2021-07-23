using UnityEngine;

public class Right_Ball : MonoBehaviour
{
    public float speed = 10f;


    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(-speed * Time.deltaTime * 20, 0 , 0, ForceMode.Impulse);
    }
}
