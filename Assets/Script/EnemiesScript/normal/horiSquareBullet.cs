using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horiSquareBullet : MonoBehaviour
{
    public float rotateSpeed;
    public float force;
    int firedir;

    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.x > 0) firedir = 1;
        else firedir = -1;


    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        transform.position += new Vector3(-firedir, 0, 0) * force * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wall" || collision.gameObject.tag == "side") Destroy(gameObject);
    }
}
