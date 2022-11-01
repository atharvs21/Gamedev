using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HomingMissile : MonoBehaviour
{
    // Start is called before the first frame update

    Transform target;
    public GameObject explosionEffect;
    public float speed = 50f;
    public float rotateSpeed = 2500f;
    GameObject ply;
    public GameOver GameOver;
    public MouseMovement MouseMovement;
    private Rigidbody2D rb;
     ParticleSystem ps;

    void Start()
    {
        // target = GameObject.FindGameObjectsWithTag("Player").Transform;
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("Square").GetComponent<Transform>();
        ply = GameObject.Find("Plane");
        ps = GameObject.FindGameObjectWithTag("ps").GetComponent<ParticleSystem>();
        Debug.Log(ps.tag);

    }

    private void Update()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 dir = (Vector2)target.position - rb.position;

        dir.Normalize();

        float rotateAmount = Vector3.Cross(dir, transform.up).z;

        rb.angularVelocity = -(rotateAmount * rotateSpeed);

        rb.velocity = transform.up * speed;
    }

    // void OnTriggerEnter2D()
    // {
        
    //     ps.Play();
    //     Destroy(ply);
        
    //     Destroy(gameObject);
    // }

    void OnTriggerEnter2D(Collider2D other){
        if(!other.gameObject.CompareTag("Bonus")){
            GameOver.Setup(MouseMovement.score);
            Destroy(gameObject);
        }
    }
}
    