using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    Vector3 speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = new Vector3(0.0f, 0.0f, 7);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime);
    }
}
