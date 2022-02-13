using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // x は横の長さ
        // y は高さ
        Debug.Log("x = 10, y = 10 の三角形の面積");
        Debug.Log(TriangleArea(10, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float TriangleArea(float x, float y)
    {
        return (x * y) / 2;
    }
}
