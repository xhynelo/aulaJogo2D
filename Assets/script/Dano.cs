using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour
{
        public float tempo = 2;
        void OnTriggerStay2D(Collider2D other)
        {
        
            RubyController controller = other.GetComponent<RubyController>();
            if(controller != null)
            {
                tempo = tempo - Time.deltaTime;
                Debug.Log(tempo);
                if(controller.health > 0 && tempo < 0)
                {
                    controller.updateHealth(-1);
                    tempo = 2;
                }
                
            }
        }
}
