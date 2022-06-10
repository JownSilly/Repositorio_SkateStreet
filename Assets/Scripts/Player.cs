using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Phisics")]
    
    [SerializeField]
    float torqueAmount = 1f;
    [SerializeField]
    float jumpAmount = 1f;

    private float boosterMultiplier;
    private float boosterTimer;
    
    private float timerControll;
    private SurfaceEffector2D effector;
    private bool boosted = false;

    float coinsAmount = 0;
    bool isJumping = false;
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        effector = GameObject.Find("Platform Shape").GetComponent<SurfaceEffector2D>();
    }
  
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount * Time.deltaTime);
        } 
        else if (Input.GetKeyDown(KeyCode.Space) && !isJumping)       
        {
           setJumping(true);
           rb2d.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);           
        }

        if (boosted){
            timerControll -= Time.deltaTime;
            
            if (timerControll <= 0){
                effector.speed /= boosterMultiplier;
                boosted = false;
            }
        }     
    }

    public void setJumping(bool isJumping){
        this.isJumping = isJumping;
    }

    public void captureCoin(){
        coinsAmount += 1;
    }

    public float getScore(){
        return coinsAmount;
    }

    public void boost(float multiplier, float timer){
        boosterMultiplier = multiplier;
        boosterTimer = timer;

        if (!boosted){
            boosted = true;
            timerControll = boosterTimer;
            effector.speed *= boosterMultiplier;
        }   
    }
}
