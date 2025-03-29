using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trameploin : MonoBehaviour
{
    public float JumpVal;

    //���� � ������
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Jump>().jumpStrength += JumpVal;
    }

    //����� �� �������
    void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Jump>().jumpStrength -= JumpVal;
    }
}
