using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmHit : MonoBehaviour
{
    public AudioSource hit;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pickaxe")
        {
            Destroy(collision.gameObject);
            hit.Play();
            anim.Play("Move");
            Health_.health -= 10;
        }
    }
}
