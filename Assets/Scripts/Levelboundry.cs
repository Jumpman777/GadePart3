using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelboundry : MonoBehaviour
{
    public static float leftSide = -7f;
    public static float rightside = 0.23f;
    public float internalLeft;
    public float internalReft;

    void Update()
    {
        internalLeft = leftSide;
        internalReft = rightside;

    }
}
