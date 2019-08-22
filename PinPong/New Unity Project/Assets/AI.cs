using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float followSpeed;
    public Vector3 ballPosition;
    private GameObject ball;

    // Start is called before the first frame update

    private void Start()
    {
        ball = GameObject.Find("Ball");
    }
    void Update()
    {
        ballPosition = ball.transform.position;
          
    }


    
}