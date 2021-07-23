using UnityEngine;

public class CylinderMoving : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 m_EulerAngleVelocity;
    public float MoveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_EulerAngleVelocity = new Vector3(0, 0, 100);
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0 , 0 , -MoveSpeed * Time.deltaTime, ForceMode.VelocityChange);
    }
}
