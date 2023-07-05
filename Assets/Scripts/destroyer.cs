using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    public string parentName;


    void Update()
    {
        parentName = transform.name;
        StartCoroutine(Destroysection());
    }

    IEnumerator Destroysection()
    {
        yield return new WaitForSeconds(50);
        if (parentName == "Level1 SECTION1(Clone)")
        {
            Destroy(gameObject);
        }
        if (parentName == "Boss1(Clone)")
        {
            Destroy(gameObject);
        }
        if (parentName == "startsection")
        {
            Destroy(gameObject);
        }
        if (parentName == "Level2 SECTION 1(Clone)")
        {
            Destroy(gameObject);
        }
        if (parentName == "Level2 SECTION 2(Clone)")
        {
            Destroy(gameObject);
        }
        if (parentName == "Boss2(Clone)")
        {
            Destroy(gameObject);
        }

    }
}
