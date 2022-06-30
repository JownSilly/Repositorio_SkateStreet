using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{

    public void Reiniciar() {
        SceneManager.LoadScene("Fase");
    }
}
