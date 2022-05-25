using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DüşmanScripts : MonoBehaviour
{
    public Transform Karakter;
    public bool HareketIzni;
    public float KarakterHiz;
    Animator anim;
    public GameObject KaybettinizPanel;

    void Start()
    {
        anim = GetComponent<Animator>();
        KaybettinizPanel.SetActive(false);
    }

    void Update()
    {
        if(HareketIzni)
        {
            KarakterKovalama();
        }

        if (HareketIzni == true)
        {
            anim.SetBool("yürü" ,true);
        }
        else
        {
            anim.SetBool("yürü" ,false);
        }
    }
    
    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "Karakter")
        {
            KaybettinizPanel.SetActive(true);
            
        }    
    }

    void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.tag == "Karakter")
        {
            HareketIzni = true;
        }
    }

    void OnTriggerExit2D(Collider2D temas)
    {
        if(temas.tag == "Karakter")
        {
            HareketIzni = false;
        }
    }

    void KarakterKovalama()
    {
        transform.position = Vector3.MoveTowards(transform.position,Karakter.position,KarakterHiz * Time.deltaTime);

    }
}
