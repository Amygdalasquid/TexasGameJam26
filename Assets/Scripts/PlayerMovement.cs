using System.IO;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public Rigidbody2D body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
 
        Vector2 direction = new Vector2(xinput, 0).normalized;
        body.linearVelocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Killbox"))
        {
          
            DeathSystem.instance.EnableDeathScreen();
        }
    }
}
