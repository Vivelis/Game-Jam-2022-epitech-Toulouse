using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageEnnemySpawn : MonoBehaviour
{
    private Collider2D zoneCollider;
    private bool isEnter = false;
    [SerializeField]
    private GameObject ennemy;

    void Start()
    {
        //zoneCollider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isEnter && collision.tag == "Player")
        {
            isEnter = true;
            SpawnEnnemy();
        }
    }

    private void SpawnEnnemy()
    {
        if (ennemy != null)
        {
            Instantiate(ennemy, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        }
    }
}
