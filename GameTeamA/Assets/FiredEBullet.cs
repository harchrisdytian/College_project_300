using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiredEBullet : MonoBehaviour
{

    [SerializeField]
    private int EbulletsAmount = 10;


    [SerializeField]
    private float startAngle = 90f, endAngle = 270f;

    private Vector2 EbullletMoveDirection;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("fire", 0f, 2f); 
    }

    private void fire()
    {
        float angleStep = (endAngle - startAngle) / EbulletsAmount;
        float angle = startAngle;

        for (int i = 0; i < EbulletsAmount + 1; i++)
        {
            float buldirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float buldirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(buldirX, buldirY, 0f);
            Vector2 buldir = (bulMoveVector - transform.position).normalized;

            GameObject bul = EnemyBulletSpawn.BulletSpawnInstance.GetEBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<EnemyBullet>().SetMoveDirection(buldir);

            angle += angleStep;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
