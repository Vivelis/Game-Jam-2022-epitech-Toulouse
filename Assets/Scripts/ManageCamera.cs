using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCamera : MonoBehaviour
{
    private Transform playerTransform;
    private Transform mainCamera;
    [Range(1, 100)]
    public float zPos = 10;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.GetComponent<Transform>();
        mainCamera = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = playerTransform.position;
        pos.z -= zPos;
        mainCamera.SetPositionAndRotation(pos, playerTransform.rotation);
    }
}
