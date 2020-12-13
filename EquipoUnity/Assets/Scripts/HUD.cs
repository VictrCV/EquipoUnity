using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    private float vida, vidastart;
    public Image verde;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
        vidastart = vida;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position ;
        verde.fillAmount = vida / vidastart;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vida = vida - 10;
        }
    }
}
