using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLifeSpan : MonoBehaviour
{
    public BulletMaker bullet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bullet = FindObjectOfType<BulletMaker>();
    }

    void OnCollisionEnter(Collision col)
    {
        if(bullet.bulletFlying == true)
        {
            Destroy(gameObject);
        }
    }
}
