using UnityEngine;

public class GroundScript : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Detectamos si es una fruta

        if(collision.gameObject.tag == "Fruit")
        {
            collision.gameObject.transform.position = spawnPoint.position;
            collision.gameObject.GetComponent<Rigidbody2D>().linearVelocityY = 0f;
        }
    }
}
