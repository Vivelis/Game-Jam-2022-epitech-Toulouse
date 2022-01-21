using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectable : MonoBehaviour
{
    private Collider2D col;
    public string element = "None";

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        ManagePlayer playerScript = col.gameObject.GetComponent<ManagePlayer>();
        if (playerScript != null)
            playerScript.SetElement(element);
        else
            Debug.Log("error: player don't have ManagePlayer script");
        col.gameObject.SetActive(false);
    }
}
