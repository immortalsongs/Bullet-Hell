using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalBullet : MonoBehaviour
{
    public GameObject player;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wall" || collision.gameObject.tag == "side") Destroy(gameObject);
    }
}
