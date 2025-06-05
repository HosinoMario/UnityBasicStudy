using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //private int gold = 0;
   // private int playerLevel = 1;
    private int RandomNumber;
    void Start()
    {
        Random.InitState(2);
        RandomNumber = Random.Range(1, 1001);
        Debug.Log(RandomNumber);


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(RandomNumber);

    }
}

