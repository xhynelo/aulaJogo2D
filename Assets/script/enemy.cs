using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float vel = 5;
    public bool vertical;

    Rigidbody2D rigidbody2D;
    Animator animator;
    float timer = 0.5f;
    int direction = 1;
    public float changeTime = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;
        if(vertical){
            animator.SetFloat("dirX", 0);
            animator.SetFloat("dirY", direction);
            position.y = position.y + Time.deltaTime * vel * direction;

        }else{
            animator.SetFloat("dirX", direction);
            animator.SetFloat("dirY", 0);
            position.x = position.x + Time.deltaTime * vel * direction;

        }
        rigidbody2D.MovePosition(position);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController>();
        if(player != null)
        {
            if(player.health > 0 )
            {
                player.updateHealth(-1);
            }
             
        }
    }
}
