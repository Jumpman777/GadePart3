using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] level1Sections;
    public GameObject[] level2Sections;
   

    public int sectionCounter = 0;
    public bool createSection = false;

    public float sectionInterval = 7f;
    public float sectionXSpacing = -4f;

    private float zPosition = 50f;
    private bool stopSpawning = false;
    private int currentLevel = 1;
    


    void Update()
    {
        if (!createSection && !stopSpawning)
        {
            createSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        GameObject newSection = null;

        if (currentLevel == 1)
        {
            if (sectionCounter < 3)
            {
                newSection = Instantiate(level1Sections[0], new Vector3(sectionXSpacing, 0f, zPosition), Quaternion.Euler(-90f, 0f, 0f));
                zPosition += 50f;

                yield return new WaitForSeconds(sectionInterval);

                sectionCounter++;
            }
            else if (sectionCounter >= 3 && sectionCounter < 5)
            {
                newSection = Instantiate(level1Sections[1], new Vector3(sectionXSpacing, 0f, zPosition), Quaternion.Euler(-90f, 0f, 0f));
                zPosition += 50f;

                yield return new WaitForSeconds(sectionInterval);

                sectionCounter++;
            }
            else
            {
                sectionCounter = 0;
                currentLevel = 2;
            }
        }
        else if (currentLevel == 2)
        {
            if (sectionCounter < 3)
            {
                newSection = Instantiate(level2Sections[0], new Vector3(sectionXSpacing, 0f, zPosition), Quaternion.Euler(-90f, 0f, 0f));
                zPosition += 50f;

                yield return new WaitForSeconds(sectionInterval);

                sectionCounter++;
            }
            else if (sectionCounter == 3)
            {
                newSection = Instantiate(level2Sections[1], new Vector3(-4f, 0f, zPosition), Quaternion.Euler(-90f, 0f, 0f));
                zPosition += 50f;

                yield return new WaitForSeconds(sectionInterval);

                sectionCounter++;
            }
            else if (sectionCounter == 4)
            {
                newSection = Instantiate(level2Sections[2], new Vector3(sectionXSpacing, 0f, zPosition), Quaternion.Euler(-90f, 0f, 0f));
                zPosition += 50f;

                // Start shooting bullets when Level 2 section 3 spawns
             

                yield return new WaitForSeconds(sectionInterval);

                sectionCounter++;
            }
            else
            {
                sectionCounter = 0;
                currentLevel = Random.Range(1, 3);
            }
        }
        else
        {
            int randomLevel = Random.Range(1, 3);

            if (randomLevel == 1)
            {
                int randomSectionIndex = Random.Range(0, level1Sections.Length);
                newSection = Instantiate(level1Sections[randomSectionIndex], new Vector3(sectionXSpacing, 0f, zPosition), Quaternion.Euler(-90f, 0f, 0f));
            }
            else if (randomLevel == 2)
            {
                int randomSectionIndex = Random.Range(0, level2Sections.Length);
                newSection = Instantiate(level2Sections[randomSectionIndex], new Vector3(sectionXSpacing, 0f, zPosition), Quaternion.Euler(-90f, 0f, 0f));
            }

            zPosition += 50f;
            yield return new WaitForSeconds(sectionInterval);
            sectionCounter++;
        }

        createSection = false;
    }

  
}