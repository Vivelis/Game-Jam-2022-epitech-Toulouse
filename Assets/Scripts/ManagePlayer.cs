using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePlayer : MonoBehaviour
{
    public string myElement = "None";

    public void SetElement(string _element)
    {
        myElement = _element;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
