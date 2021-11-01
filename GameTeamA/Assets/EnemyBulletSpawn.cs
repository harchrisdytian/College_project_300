using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawn : MonoBehaviour
{
    public static EnemyBulletSpawn BulletSpawnInstance;

    [SerializeField]
    private GameObject SpawnedBulllet;
    private bool notEnoughBulletsInPool = true;

    private List<GameObject> Ebullets;

    private void Awake()
    {
        BulletSpawnInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Ebullets = new List<GameObject>();
    }


    public GameObject GetEBullet()
    {
        if (Ebullets.Count > 0)
        {
            for (int i = 0; i < Ebullets.Count; i++)
            {
                if (!Ebullets[i].activeInHierarchy) 
                {
                    return Ebullets[i];

                }
            
            
            }
        
        }

        if (notEnoughBulletsInPool)
        {
            GameObject bul = Instantiate(SpawnedBulllet);
            bul.SetActive(false);
            Ebullets.Add(bul);
            return bul;
        }

        return null;


    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
