using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLevel : MonoBehaviour
{

    public GameObject[] curves, plataformes, trampes;
    public GameObject monedaPrefab, torrePrefab;
    // Start is called before the first frame update
    void Start()
    {
        //float posX, posZ,rotY;
        //posX = posZ = rotY =0;
        //GameObject obj;
        //for(uint i = 0; i < 10; ++i)
        //{
        //    if(i == 4 || i == 7)
        //    {
        //        obj = (GameObject)Instantiate(trampes[i % 4]);
        //    }
        //    else
        //    {
        //        obj = (GameObject)Instantiate(plataformes[i % 4]);
        //    }
            
        //    obj.transform.Translate(0.0f, 0.0f, i * 6f);
        //    obj.transform.parent = transform;
           
        //}
        //posZ = 10 * 6f;
        //obj = (GameObject)Instantiate(curves[(int)UnityEngine.Random.value % 2]);
        //obj.transform.Translate(0.0f, 0.0f, posZ);
        //obj.transform.parent = transform;
        

        //for (uint i = 0; i < 15; ++i)
        //{
        //    if (i == 4 || i == 7 || i == 13)
        //    {
        //        obj = (GameObject)Instantiate(trampes[i % 4]);
        //    }
        //    else
        //    {
        //        obj = (GameObject)Instantiate(plataformes[i % 4]);
        //    }

        //    obj.transform.Translate((i+1)*6f, 0.0f, posZ);
        //    obj.transform.Rotate(0f, 90f, 0f, Space.World);
        //    obj.transform.parent = transform;
            
        //}
        //posX = 16 * 6f;
        //obj = (GameObject)Instantiate(curves[(int)UnityEngine.Random.value % 2]);
        //obj.transform.Translate(posX, 0.0f, posZ);
        //obj.transform.Rotate(0f, 180f, 0f, Space.World);
        //obj.transform.parent = transform;
        //posZ += 6f;
        //for (uint i = 0; i < 5; ++i)
        //{
            
        //    obj = (GameObject)Instantiate(plataformes[i % 4]);
        //    obj.transform.Translate(posX, 0.0f, (i*6f) + posZ);
        //    //obj.transform.Rotate(0f, -90f, 0f, Space.World);
        //    obj.transform.parent = transform;

        //}
        //posZ += 5 * 6f;
        //obj = (GameObject)Instantiate(torrePrefab);
        //obj.transform.Translate(posX, 0.0f, posZ + 12f);
        //obj.transform.Rotate(0f, 180, 0f, Space.World);
        //obj.transform.parent = transform;


        //obj = (GameObject)Instantiate(curves[(int)UnityEngine.Random.value % 2]);
        //obj.transform.Translate(posX, 0.0f, posZ);
        //obj.transform.Rotate(0f, 90f, 0f, Space.World);
        //obj.transform.parent = transform;
        //posX -= 6f;
        //for (uint i = 0; i < 25; ++i)
        //{
        //    if (i == 4 || i == 7 || i == 13 || i == 15 || i == 20)
        //    {
        //        obj = (GameObject)Instantiate(trampes[i % 4]);
        //    }
        //    else
        //    {
        //        obj = (GameObject)Instantiate(plataformes[i % 4]);
        //    }

        //    obj.transform.Translate(posX - i*6f, 0.0f, posZ);
        //    obj.transform.Rotate(0f, 90f, 0f, Space.World);
        //    obj.transform.parent = transform;

        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
