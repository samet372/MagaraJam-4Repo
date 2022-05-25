using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    public float yatayHareket;
    public float hareketHizi;
    public float ziplamaHizi;
    Animator anim;
    Rigidbody2D rb;
    
    public bool faceright = true;
    public bool KarakterYerde = true;
    private AudioSource mySource;
    
    
    
        void Awake()
        {
            rb = GetComponent<Rigidbody2D>(); 
            anim = GetComponent<Animator>();
            mySource = GetComponent<AudioSource>();
        }
    

    
   void FixedUpdate()
   {

        yatayHareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayHareket * hareketHizi* 100 * Time.deltaTime, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && KarakterYerde == true)
        {
            anim.SetTrigger("Zıplama");
            rb.velocity = Vector2.up * ziplamaHizi * 100 * Time.deltaTime;
            KarakterYerde = false;
            mySource.Play();
        }

         if(yatayHareket > 0 && faceright == false)
        {
            turn();
        }
        if(yatayHareket < 0 && faceright == true)
        {
            turn();
        }

        if (yatayHareket != 0)
        {
            anim.SetBool("YürümeBool" ,true);
        }
        else
        {
            anim.SetBool("YürümeBool" ,false);
        }


   }

        void OnCollisionEnter2D(Collision2D temas)
        {
            if(temas.gameObject.tag == "zemin")
            {
                KarakterYerde = true;
            }
            

        }



        void turn()
        {
            faceright = !faceright;
            Vector2 yeniscale = transform.localScale;
            yeniscale.x *= -1;
            transform.localScale = yeniscale;
        }

       

}
