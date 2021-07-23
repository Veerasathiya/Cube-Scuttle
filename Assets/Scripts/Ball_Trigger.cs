using UnityEngine;

public class Ball_Trigger : MonoBehaviour
{

    public GameObject leftBall;
    public GameObject rightBall;



    void OnTriggerEnter()
    {
        leftBall.GetComponent<MovingBall>().enabled = true;
        rightBall.GetComponent<Right_Ball>().enabled = true;
        FindObjectOfType<MovingBall>().enabled = true;
        FindObjectOfType<Right_Ball>().enabled = true;
    }

}
