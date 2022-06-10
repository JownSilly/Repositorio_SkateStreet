using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private Player _player;
    private bool active = true;

    void Start()
    {
        _player = GameObject.Find("Personagem").GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && active)
        {
            _player.captureCoin();
            active = false;

            Destroy(gameObject);
        }
    }
    
}
