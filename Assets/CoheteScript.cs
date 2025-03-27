using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoheteScript : MonoBehaviour

{
    public GameObject coheteFuego;
    float coheteSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        coheteFuego.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, coheteSpeed, 0);

    }
    public void Despegue()
    {
        coheteSpeed = 0.1f;
        //debe activarse el objeto CoheteFuego
        coheteFuego.SetActive(true);
    }
}
