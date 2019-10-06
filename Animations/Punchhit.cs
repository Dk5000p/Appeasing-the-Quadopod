using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punchhit : MonoBehaviour
{
    public bool hit=false;
    public GameObject bamHit;
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
        if (collision.tag == "Player" && hit == false)
        {
            hit = true;
            Move.health -= 10;
            Instantiate(bamHit, transform.position, Quaternion.identity);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            hit = false;
        }
    }
}
