using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    // private Transform cameraTransform;
    // private Vector3 lastCameraPosition;
    

    // void Start() {
    //     cameraTransform = GameObject.Find("CM Follow Camera").transform;
    //     lastCameraPosition = cameraTransform.position;
    // }

    // void LateUpdate(){
    //     Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
    //     transform.position += deltaMovement;
    //     lastCameraPosition = cameraTransform.position;
    // }


    private float startPos;
    private float length;
    private GameObject cam;
    [SerializeField] private float parallaxEffect;
    [SerializeField] private bool endless = true;

    void Start()
    {
        cam = GameObject.Find("Main Camera");
        startPos = transform.position.x;
        length = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void LateUpdate()
    {
        float distance = cam.transform.position.x * parallaxEffect;
        float temp = cam.transform.position.x * (1 - parallaxEffect);
        
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        if (endless)
        {
            if (temp > startPos + length)
            {
                startPos += length;
            } else if (temp < startPos - length)
            {
                startPos -= length;
            }
        }
    }
}
