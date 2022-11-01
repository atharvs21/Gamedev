using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicators : MonoBehaviour
{
    public GameObject Indicator;
    public GameObject Target;

    Renderer rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!rd.isVisible){
            if(!Indicator.activeSelf){
                Indicator.SetActive(true);
            }

            Vector2 direction = Target.transform.position - transform.position;

            RaycastHit2D ray = Physics2D.Raycast(transform.position, direction);

            if(ray.collider != null){
                Indicator.transform.position = ray.point;
            }
        }
        else{
            if(Indicator.activeSelf){
                Indicator.SetActive(false);
            }
        }
    }
}
