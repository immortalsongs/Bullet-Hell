using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCircleBeha : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale += Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += Vector3.one;
        if (Mathf.Abs(transform.localScale.x) > 10) Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet") Destroy(collision.gameObject);
    }
}

