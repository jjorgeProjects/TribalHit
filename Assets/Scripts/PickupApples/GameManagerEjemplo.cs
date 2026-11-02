using UnityEngine;

public class GameManagerEjemplo : MonoBehaviour
{

    [SerializeField] private GameObject enemyGameObject;
    EnemyScriptEjemplo enemyScript;
    Rigidbody2D enemyRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        enemyGameObject = GameObject.FindWithTag("Enemy");

        enemyScript = enemyGameObject.GetComponent<EnemyScriptEjemplo>();

        enemyScript.SetVida(10f);

        enemyRigidbody = enemyGameObject.GetComponent<Rigidbody2D>();
        
        if(enemyScript == null)
        {
            Debug.Log("Cuidado, no tiene Rigidbody2D :(");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyScript != null)
        {
            enemyRigidbody.gravityScale = 10;
        }
    }
}
