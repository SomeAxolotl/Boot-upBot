using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Base : MonoBehaviour
{
    public float changeTime = 3.0f;
    public int direction = 0;
    public float timer;
    public float failtimer;
    public float failTime = 3.0f;
    Animator animator;

    
    // Start is called before the first frame update
    void Start()
    {
        timer = changeTime;
        failtimer = failTime;
        animator = GetComponent<Animator>();

    }
 
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        if (timer < 0)
        {
            direction = Random.Range(1,5);
            if(direction == 1)
            {
                Debug.Log("Left");
                timer = changeTime;
                direction = 1;
                animator.SetInteger("direction", 1);
            }
            if(direction == 2)
            {
                Debug.Log("Right");
                timer = changeTime;
                direction = 2;
                animator.SetInteger("direction", 2);
            }
            if(direction == 3)
            {
                Debug.Log("Up");
                timer = changeTime;
                direction = 3;
                animator.SetInteger("direction", 3);
            }
            if(direction == 4)
            {
                Debug.Log("Down");
                timer = changeTime;
                direction = 4;
                animator.SetInteger("direction", 4);
            }
        }
        if(direction == 0)
        {
            timer -= Time.deltaTime;
        }
        if(direction == 1)
            {
               failtimer -= Time.deltaTime;
               if(horizontal < 0)
                {
                    Debug.Log("Correct");
                    direction = 0;
                    failtimer = failTime;
                    animator.SetInteger("direction", 0);
                }

            }
        if(direction == 2)
            {
               failtimer -= Time.deltaTime;
               if(horizontal > 0)
                {
                    Debug.Log("Correct");
                    direction = 0;
                    failtimer = failTime;
                    animator.SetInteger("direction", 0);
                }
            }
        if(direction == 3)
            {
               failtimer -= Time.deltaTime;
               if(vertical > 0)
                {
                    Debug.Log("Correct");
                    direction = 0;
                    failtimer = failTime;
                    animator.SetInteger("direction", 0);
                }
            }
        if(direction == 4)
            {
              failtimer -= Time.deltaTime;
               if(vertical < 0)
                {
                    Debug.Log("Correct");
                    direction = 0;
                    failtimer = failTime;
                    animator.SetInteger("direction", 0);
                }
            }
        if(failtimer < 0)
        {
            Debug.Log("Fail");
        }
 
 
        
        
    }
}
