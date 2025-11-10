using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // 1
    void OnTriggerEnter(Collider other)
    {
        // 2
        if (other.name == "Player")
        {
            Debug.Log("Enemy encounter");
        }
    }

    // 3
    void OnTriggerExit(Collider other)
    {
        // 4
        if(other.name == "Player")
        {
            Debug.Log("Enemy encounter over");
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
