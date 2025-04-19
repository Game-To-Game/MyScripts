using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temprter : MonoBehaviour
{
    public float currentTempretr;
    public float critTemp;
    public float standartTemp;

    public PlayerHealth playerHp;

    public int temprteDamage;

    public float frezeSpeed;

    public float frizingtime;
    public float frizingDelay;


    // Update is called once per frame
    void Update()
    {
        currentTempretr -= frezeSpeed * Time.deltaTime;

        if (currentTempretr <= critTemp)
        {
            frizingtime -= Time.deltaTime;
            if (frizingtime <= 0)
            {
                playerHp.TakeDamage(temprteDamage);
                frizingtime = frizingDelay;
            }
            
        }
    }
}
