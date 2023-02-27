using UnityEngine;

public class BeGripped : MonoBehaviour
{
    public Transform hand;

    Rigidbody rb;

    int tCount;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tCount = 0;

    }

    private void OnTriggerEnter(Collider other)
    {
        tCount++;
        if (tCount >= 3)
        {
            transform.parent = hand;
            Destroy(rb);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        tCount = 0;
        transform.parent = null;
        if(gameObject.GetComponent<Rigidbody>() == null){
            rb = gameObject.AddComponent<Rigidbody>(); 
        } 
    }
}



