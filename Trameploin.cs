using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trameploin : MonoBehaviour
{
    public float JumpVal;

    //Вход в тригер
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Jump>().jumpStrength += JumpVal;
    }

    //Выход из тригера
    void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Jump>().jumpStrength -= JumpVal;
    }
}
