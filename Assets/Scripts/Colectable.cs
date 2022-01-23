using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectable : MonoBehaviour
{
    private Collider2D col;
    [SerializeField]
    private GameObject[] elementsToActiveArr;
    private string element;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        element = col.name;
    }

    void OnTriggerEnter2D(Collider2D _collision)
    {
        if (_collision.tag == "Player")
        {
            ManagePlayer playerScript = _collision.gameObject.GetComponent<ManagePlayer>();
            if (playerScript != null)
                playerScript.SetElement(element);
            else
                Debug.Log("error: player don't have ManagePlayer script");
            foreach (GameObject elementToActive in elementsToActiveArr)
                elementToActive.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}