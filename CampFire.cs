using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampFire : MonoBehaviour
{
    public float lifeTime;
    public float heatSpeed;

    private Temprter playerTempr;



    // Start is called before the first frame update
    void Start()
    {
        
        Invoke("die", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerTempr = other.gameObject.GetComponent<Temprter>();
            playerTempr.currentTempretr += heatSpeed * Time.deltaTime;
        }
        
    }
    public void die()
    {
        Destroy(gameObject);
    }


}
