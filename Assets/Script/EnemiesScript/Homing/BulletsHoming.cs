using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsHoming : MonoBehaviour
{
    Rigidbody2D rb;

    public GameObject Player;

    public float speed;
    Vector3 dir;

    public float livingTime=50;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.Find("player");
        dir = (Player.transform.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        if (livingTime <= 0) Destroy(gameObject);
        livingTime -= Time.deltaTime;


        rb.transform.position += (dir*speed*Time.deltaTime);

        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.gameObject.tag == "bullet")*/ Destroy(gameObject);
    }
}
