using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bam : MonoBehaviour
{
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
        if (collision.tag == "Player")
        {
            Instantiate(bamHit, transform.position, Quaternion.identity);
        }
    }
}
