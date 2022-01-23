using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] elementsArray;
    [SerializeField]
    private float waitTime = 5f;
    private bool noneIsActive = true;
    private GameObject noneElement;

    private void Start()
    {
        int childNbr = gameObject.transform.childCount;
        for (int childIndex = 0; childIndex < childNbr; childIndex++)
            elementsArray[childIndex] = gameObject.transform.GetChild(childIndex).gameObject;
        foreach (GameObject element in elementsArray)
        {
            if (element.name == "None")
                noneElement = element;
        }
    }

    private void Update()
    {
        if (noneElement != null)
        {
            if (noneIsActive == true)
            {
                if (noneElement.activeSelf == false)
                {
                    noneIsActive = false;
                    StartCoroutine(ActivateElement("None"));
                }
            }
        }
    }

    IEnumerator ActivateElement(string _elementName)
    {
        yield return new WaitForSeconds(waitTime);
        foreach (GameObject element in elementsArray)
        {
            if (element.name == _elementName)
            {
                element.SetActive(true);
                noneIsActive = true;
                yield break;
            }
        }
        Debug.Log("unknown element");
    }
}
