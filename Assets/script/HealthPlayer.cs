using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
        
        void OnTriggerEnter2D(Collider2D other)
        {
        
            RubyController controller = other.GetComponent<RubyController>();
            if(controller != null)
            {
                if(controller.health < controller.maxHealth)
                {
                    controller.updateHealth(1);
                    Destroy(gameObject);
                }
                
            }
            Debug.Log("peguei um item de saude");

        }
}
