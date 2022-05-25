using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketScript : MonoBehaviour
{


    const float hareketGucu = 10;
    const float ziplamaGucu = 500;
    Rigidbody2D rb;

    bool karakterYerde = true;


    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();    
    }




    void Start()
    {
        
    }
    void Update()
    {
        
    }

     void FixedUpdate()
    {

        Vector3 position = transform.position;

        float yatayInput = Input.GetAxis("Horizontal");

            if (yatayInput != 0)
            {
                position.x += yatayInput * hareketGucu * Time.deltaTime;
            }

        transform.position = position;

            if (Input.GetButtonDown("Jump") && karakterYerde == true)
            {
                rb.AddForce (new Vector2(0, ziplamaGucu)); 
            }

            
    }




}
