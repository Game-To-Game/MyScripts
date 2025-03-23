using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // ���-�� ������
    public int health;

    // �������
    public int level;

    // ��������
    public int speed;

    private Vector3 newPos;
    // Start is called before the first frame update
    void Start()
    {
        // ���������� � �������� �������
        health += level;
        print(health);

        newPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPos.z += speed * Time.deltaTime;
        transform.position = newPos;  
    }
}
