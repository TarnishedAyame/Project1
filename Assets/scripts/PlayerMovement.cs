using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private AudioSource collectsoundeffect;

    private Rigidbody2D rb;
    float XMove;
    //float yMove;
    public float speed = 100;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        

    }

    // Update is called once per frame
    void Update()
    {
        XMove = Input.GetAxisRaw("Horizontal");
        //yMove = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(XMove,0) * (speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Collided with: " + collision.gameObject.name);
       
        if (collision.gameObject.tag == "Memes")
        {
            collectsoundeffect.Play();
            Destroy(collision.gameObject);

            gameManager.AddScore();
            // Code is specific to collision with enemies
        }

        print("Collision Triggered" + collision.gameObject.name);
    }
}
