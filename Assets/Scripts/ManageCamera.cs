using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCamera : MonoBehaviour
{
    private Transform playerTransform;
    private Transform mainCamera;
    private float zPos = 10;
    [Range(0,1)] [SerializeField]
    private float cameraSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.GetComponent<Transform>();
        mainCamera = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = playerTransform.position;
        pos.z -= zPos;
        Vector3 lerpPosition = Vector3.Lerp(transform.position, pos, cameraSpeed);
        mainCamera.position = lerpPosition;
    }
}
