using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToDestroy : MonoBehaviour
{

    float timeToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        timeToDestroy = 25;
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToDestroy -= Time.deltaTime;
        if (timeToDestroy <= 0.0f) Destroy(gameObject);
        
    }
}
