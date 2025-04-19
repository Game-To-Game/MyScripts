using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TemperatureUI : MonoBehaviour
{
    public TextMeshProUGUI temperatuerText;

    private Temprter playerTem;

    // Start is called before the first frame update
    void Start()
    {
        playerTem = GameObject.FindGameObjectWithTag("Player").GetComponent<Temprter>();

    }

    // Update is called once per frame
    void Update()
    {
        temperatuerText.text = (Mathf.Round(playerTem.currentTempretr * 10.0f)* 0.1f).ToString();



    }
}
