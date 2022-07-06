using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float velx = 3;
    public int health = 5;
    public int maxHealth = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x = position.x + Input.GetAxis("Horizontal") * Time.deltaTime * velx;
        position.y = position.y + Input.GetAxis("Vertical") * Time.deltaTime * velx;
        transform.position = position;
    }

    public void updateHealth(int value)
    {

        health = Mathf.Clamp(health + value, 0 , maxHealth);
        Debug.Log(health);
    }
}
