using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoardCollision : MonoBehaviour
{
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            player.setJumping(false);
        }else if(collision.gameObject.CompareTag("Obstacle")){
            SceneManager.LoadScene("Fase");
        }else if (collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Fim de Jogo");
        }
    }
    // Update is called once per frame
}
