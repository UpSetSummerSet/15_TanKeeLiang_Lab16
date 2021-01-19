using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int enemyscore = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            ScoreTracker.scoreValue += 100;
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
