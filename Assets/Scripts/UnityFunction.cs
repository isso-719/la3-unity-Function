using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityFunction : MonoBehaviour
{

    // Start の前に 1 度だけ
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // 最初に 1 度だけ
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // 毎フレームごとに
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }


    // 一定時間ごとに
    private void FixedUpdate()
    {
        
    }

    // オブジェクトが衝突した瞬間
    private void OnCollisionEnter(Collision collision)
    {
        
    }

    // オブジェクトが接した瞬間
    private void OnCollisionStay(Collision collision)
    {

    }

    // オブジェクトが離れた瞬間
    private void OnCollisionExit(Collision collision)
    {
        
    }
}
