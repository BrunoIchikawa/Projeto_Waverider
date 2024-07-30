using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{

    Vector3 movi;
    // Inicia e executa apenas no primeiro frame
    void Start()
    {
        movi = new Vector3(0f,1f,0f);
        transform.position = movi;
    }

    // Atualiza a cada frama
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
                movi.x = -0.05f;
                movi.y = 0;
                movi.z = 0;
                transform.Translate(movi);
            }
        if (Input.GetKeyDown(KeyCode.D))
            {
                movi.x = 0.05f;
                movi.y = 0;
                movi.z = 0;
                transform.Translate(movi);
            }
        if (Input.GetKeyDown(KeyCode.S))
        {
            movi.x = 0f;
            movi.y = 0;
            movi.z = -0.05f ;
            transform.Translate(movi);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            movi.x = 0f;
            movi.y = 0;
            movi.z = 0.05f;
            transform.Translate(movi);
        }
        if (Input.GetKeyDown(KeyCode.Space))
            {
            movi.x = 0f;
            movi.y = 1f;
            movi.z = 0f;
            transform.Translate(movi);
            }
    }
}
