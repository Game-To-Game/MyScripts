using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 10;
    public int coinCount;
    public GameObject fireBall;
    public Transform shotpoint;
    public string sceneName;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока" + health);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireBall, shotpoint.position, shotpoint.rotation);

            
        }
            if (health <= 0)
            {
                EditorSceneManager.LoadScene(sceneName);
            }
    }
}
