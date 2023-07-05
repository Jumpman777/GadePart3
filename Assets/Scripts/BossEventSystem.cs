using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventSystem : MonoBehaviour
{
    public UnityEvent onObstaclePassed;
    

    public void ObstaclePassed()
    {
        onObstaclePassed.Invoke();
    }
}

