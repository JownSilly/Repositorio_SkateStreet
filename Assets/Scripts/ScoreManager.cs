using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text textScore;
    private Player _player;

    void Start(){
        _player = GameObject.Find("Personagem").GetComponent<Player>();
    }

    void Update(){
        textScore.text = "Score: "+_player.getScore().ToString() + "";
    }
}
