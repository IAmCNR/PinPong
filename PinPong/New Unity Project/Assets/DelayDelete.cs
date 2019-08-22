using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayDelete : MonoBehaviour
{
    public float deleteTime;

    void Update()
    {
        Destroy(gameObject, deleteTime);
    }
}
