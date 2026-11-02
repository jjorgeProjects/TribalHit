using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal"); // -1 a 1

        transform.position += Vector3.right * horizontal * speed * Time.deltaTime;

        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("He detectado una interacción.");

        //Eliminar la fruta
        if(collision.gameObject.tag == "Fruit")
        {
            Debug.Log("Es una piña");
           
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

            /*rb.linearVelocityY = 0f;*/
            
            rb.AddForce(new Vector3(UnityEngine.Random.Range(-0.5f,0.5f),1,0) * 15f, ForceMode2D.Impulse);
            
        }
    }
}
