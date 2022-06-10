using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityBooster : MonoBehaviour
{
    [SerializeField]
    private float boosterMultiplier = 1f;
    [SerializeField]
    private float timer = 5;
    
    private Player player;

    void Start(){
        player = GameObject.Find("Personagem").GetComponent<Player>();
    }
    
    void OnTriggerEnter2D(Collider2D col){
        if (col.CompareTag("Player")){
            player.boost(boosterMultiplier, timer);

            Destroy(gameObject);
        }
    }
}
