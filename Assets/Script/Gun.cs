using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 武器类
public class Gun : MonoBehaviour
{
    private float fireSpeed = 1f;

    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {        
        fireSpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire() {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

    public void OpenFire() {
        InvokeRepeating("Fire", 0.5f, fireSpeed);
    }

    public void StopFire() {
        CancelInvoke("Fire");
    }
}
