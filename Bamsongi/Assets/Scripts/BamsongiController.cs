using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    Rigidbody rig;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        //Shoot(new Vector3(0, 200, 2000));
    }
    public void Shoot(Vector3 dir)
    {
       
        GetComponent<Rigidbody>().AddForce(dir);
    }
    void OnCollisionEnter(Collision other)
    {
        rig.isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }
    
}
