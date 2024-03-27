using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    public GameObject bulletPrefab;

    
    float minTime, maxTime;
    float timeToNext;
    // Start is called before the first frame update
    void Start()
    {
        minTime = 4;
        maxTime = 6;
        timeToNext = minTime + UnityEngine.Random.value * (maxTime - minTime);  
    }

    // Update is called once per frame
    void Update()
    {
        timeToNext -= Time.deltaTime;
        if (timeToNext <= 0.0f)
        {
            GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.parent = transform;
            //bullet.GetComponent<Move>().speed = new Vector3(speed, 0.0f, 0.0f);
            timeToNext = minTime + UnityEngine.Random.value * (maxTime - minTime);
        }
        
    }
}
