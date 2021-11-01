using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public float lifetime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
        StartCoroutine(WaitthenDie());
    }
    private void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Debug.Log(hitinfo.name);
        //Destroy(gameObject);

    }
    IEnumerator WaitthenDie()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
