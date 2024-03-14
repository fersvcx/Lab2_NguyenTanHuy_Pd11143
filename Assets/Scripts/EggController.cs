using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    public GameObject EggBroken;
    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("dat"))
        {
            Instantiate (EggBroken, transform.position, Quaternion.identity);
            Destroy (this);
        }
        if (col.gameObject.name.Equals("box"))
        {
            Destroy (this);
        }
    }
}
