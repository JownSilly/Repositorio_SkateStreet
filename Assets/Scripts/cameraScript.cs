using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{

    public GameObject Personagem;
    void Update()
    {
        float x = Personagem.transform.position.x+1.2f;
        transform.position = new Vector3(x, -2, -1);
    }
}
