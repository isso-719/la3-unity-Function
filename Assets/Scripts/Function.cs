using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(3 + 4);

        //Sum();

        //Sum(5);

        //Sum(5, 3);

        HelloYourName("Life is Tech!");

        int number = Sum(5, 3);
        Debug.Log(number);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void Sum()
    //{
    //    Debug.Log(3 + 4);
    //}

    //void Sum(int x)
    //{
    //    Debug.Log(x + 4);
    //}

    //void Sum(int x, int y)
    //{
    //    Debug.Log(x + y);
    //}

    void HelloYourName(string name)
    {
        string message = "Hello " + name;
        Debug.Log(message);
    }

    int Sum(int x, int y)
    {
        return x + y;
    }
}
