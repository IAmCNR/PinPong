using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float clampValue;
    public string axisName;

    // Start is called before the first frame update
    void Update()
    {
        MovePaddle(Input.GetAxis(axisName));
    }

    // Update is called once per frame
    void MovePaddle(float amountToMove)
    {
        Vector3 clampedGameObjectPosition = gameObject.transform.position + new Vector3(amountToMove * speed, 0, 0);
        clampedGameObjectPosition.x = Mathf.Clamp(clampedGameObjectPosition.x, -clampValue, clampValue);

        gameObject.transform.position = clampedGameObjectPosition;
    }
}