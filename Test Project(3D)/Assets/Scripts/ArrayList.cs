using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    private int[] Numbers = new int[5];
    List<int> NumberList = new List<int>();
    void Start()
    {
        Numbers[0] = 100;
        Numbers[1] = 200;
        Numbers[2] = 300;
        Numbers[3] = 400;

        NumberList.Add(800);
        NumberList.Add(700);
        NumberList.Add(600);

        Debug.Log(Numbers[0]);
        Debug.Log(Numbers[1]);
        Debug.Log(Numbers[2]);
        Debug.Log(Numbers[3]);

        Debug.Log(NumberList[0]);
        Debug.Log(NumberList[1]);
        Debug.Log(NumberList[2]);

    }

    // Update is called once per frame
    void Update()
    {
  

    }
}
