using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullMovement : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.Translate(-transform.forward * speed * Time.deltaTime);
    }
}
