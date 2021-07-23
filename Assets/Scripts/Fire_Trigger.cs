using UnityEngine;

public class Fire_Trigger : MonoBehaviour
{
    public GameObject fireDef;
    public GameObject playerMoment;


    void OnTriggerEnter(Collider other)
    {
        fireDef.SetActive(true);
        playerMoment.GetComponent<PlayerMoment>().enabled = false;
        FindObjectOfType<GameManager>().EndGame();
    }
}
