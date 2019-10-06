using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    public GameObject bamHit;
    public AudioSource hit;
    private void Start()
    {
        Destroy(gameObject, 2f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Instantiate(bamHit, transform.position, Quaternion.identity);
            hit.Play();
            Destroy(gameObject);
            Move.health -= 10;
        }   
    }
}
