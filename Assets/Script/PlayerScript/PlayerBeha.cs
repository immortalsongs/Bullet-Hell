using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeha : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public int hp = 5;

    float worldHeight;
    float worldWidth;

    //public float dashSpeed=3f;

    public Animator ani;
    public AudioSource adi;

    public GameObject hitCir;

    public GameObject deadScene;




    // Start is called before the first frame update
    void Start()
    {
        deadScene.SetActive(false);

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            adi.Pause();
            Dead();
            deadScene.SetActive(true);
        }

        float hori = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(hori, verti,0f).normalized;
        if(dir.magnitude>=0.1f)
        {
                rb.transform.position += dir * speed * Time.deltaTime;
        }
        
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(Vector3.forward*angle);
        //if (Input.GetKeyDown("space"))
        //{
        //    Dash(dir);
        //}
        if (Input.GetKey("left shift"))
        {
            Time.timeScale = 0.5f;
        }
        else Time.timeScale = 1;
        //ani.ResetTrigger("getHit");

          
    }

    //public void Dash(Vector3 dir)
    //{
    //    ani.SetTrigger("dash");
    //    transform.position+=(dir*dashSpeed);
    //}
    public void GetHurt()
    {
        ani.SetTrigger("getHit");
        Instantiate(hitCir, transform.position, Quaternion.identity);
        //ani.ResetTrigger("getHit");
    }

    public void Dead()
    {
        ani.SetTrigger("dead");
        BoxCollider2D temp= GetComponent<BoxCollider2D>();
        temp.size = Vector2.zero;
    }

       

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            if(transform.position.y<0)
                 transform.position = new Vector3(transform.position.x, -(transform.position.y+0.2f), transform.position.z);
            else transform.position = new Vector3(transform.position.x, -(transform.position.y - 0.2f), transform.position.z);
        }
        if (collision.gameObject.tag == "side")
        {
            if(transform.position.x<0)
                transform.position = new Vector3(-(transform.position.x+0.2f), transform.position.y, transform.position.z);
            else transform.position = new Vector3(-(transform.position.x - 0.2f), transform.position.y, transform.position.z);
        }
        if (collision.gameObject.tag == "enemy") 
        { 
            hp--;
            GetHurt();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            hp--;
            GetHurt();
        }
    }

}
