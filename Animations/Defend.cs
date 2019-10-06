using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend : MonoBehaviour
{
    public Animator anim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pickaxe")
        {
            anim.Play("Defend");
        }
    }
}
