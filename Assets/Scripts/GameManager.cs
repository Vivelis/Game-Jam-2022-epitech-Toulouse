using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
        if (player.Length != 1)
        {
            Debug.Log(player.Length + "Players, error");
            Application.Quit();
        }
    }
}
