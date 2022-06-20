
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour
{
    public GameObject[] cloneObs;

    public GameObject coin;
    public GameObject boost;
    public GameObject personagem;
    private int i;

    public float delayInicial, delayObj, delayObj2;

    private void Start()
    {
        InvokeRepeating(nameof(GerarClone), delayInicial, delayObj);
        InvokeRepeating(nameof(GerarCloneCoin), delayInicial, delayObj2);
        InvokeRepeating(nameof(GerarCloneBoost), 10, 20f);
    }

    private void GerarClone()
    {
        i = Random.Range(0, cloneObs.Length);
        var x = personagem.transform.position.x + 10f;
        var y = cloneObs[i].transform.position.y;
        var spawnObs = new Vector2(x, y);
        Instantiate(cloneObs[i], spawnObs, Quaternion.identity);
    }

    private static bool IsPositionAwayFromObstacles(Vector2 spawnCol)
    {
        var obstaculos = GameObject.FindGameObjectsWithTag("Obstacle");

        foreach (var obstaculo in obstaculos)
        {
            var distancia = Vector2.Distance(obstaculo.transform.position, spawnCol);

            if (distancia < 2)
            {
                return true;
            }
        }

        return false;
    }

    private void GerarCloneCoin()
    {
        var x = personagem.transform.position.x + 12f;
        var y = -3.2f;

        var spawnPosition = new Vector2(x, y);

        // Pegar todos os objetos que são inimigos (com a tag Obstacle)
        // Se a distância entre todos os objetos e o spawnCol for menor que 2, não spawna o objeto
        if (IsPositionAwayFromObstacles(spawnPosition))
        {
            return;
        }

        Instantiate(coin, spawnPosition, Quaternion.identity);
    }

    private void GerarCloneBoost()
    {
        var x = personagem.transform.position.x + 13f;
        var y = -3.3f;

        var spawnPosition = new Vector2(x, y);

        if (IsPositionAwayFromObstacles(spawnPosition))
        {
            return;
        }

        Instantiate(boost, spawnPosition, Quaternion.identity);
    }
}
