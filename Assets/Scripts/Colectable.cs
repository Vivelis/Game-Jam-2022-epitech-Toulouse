using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectable : MonoBehaviour
{
    private Collider2D col;

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
        col.gameObject.SetActive(false);
    }
}
