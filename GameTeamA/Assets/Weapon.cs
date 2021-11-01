using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint2;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BulletSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        //Shoot();
    }
    public IEnumerator BulletSpawn()
    {
        while (true)
        {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
        yield return new WaitForSeconds(.5f);
        }
    }
    void Shoot()
    {
        //shooting
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
    }
}
