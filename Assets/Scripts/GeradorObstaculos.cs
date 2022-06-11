using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour
{
    public GameObject [] cloneObs;

    public GameObject coin;
    public GameObject boost;
    public GameObject personagem;
    private int i;
    public float delayInicial, delayObj, delayObj2;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("GerarClone", delayInicial, delayObj);
        InvokeRepeating("GerarCloneCoin", delayInicial, delayObj2);
        InvokeRepeating("GerarCloneBoost", 10, 20f);
    }
    // Update is called once per frame
    void GerarClone()
    {
        i = Random.Range(0, cloneObs.Length);
        float x = personagem.transform.position.x+10f;
        float y = cloneObs[i].transform.position.y;
        var spawnObs = new Vector2(x, y);
        Instantiate(cloneObs[i], spawnObs,Quaternion.identity);
    }
    
    void GerarCloneCoin()
    {
        float x = personagem.transform.position.x + 12f;
        float y = -3.2f;
        var spawnCol = new Vector2(x, y);       
        Instantiate(coin, spawnCol, Quaternion.identity);
    }
    void GerarCloneBoost()
    {
        float x = personagem.transform.position.x + 13f;
        float y = -3.3f;
        var spawnCol = new Vector2(x, y);
        //posicaoAleatoria = CheckDistanciaObstaculos();
        Instantiate(boost, spawnCol, Quaternion.identity);
    }
   
    
}
