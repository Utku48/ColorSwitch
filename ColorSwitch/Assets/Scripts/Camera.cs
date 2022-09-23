using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //Kamera Takip Kodu
    public Transform ballPosition;


    void Update()
    {
        //Topun pozisyonu kamera'nın pozisyonundan büyükse
        if (ballPosition.position.y > transform.position.y) //Transform.position = Script'in içinde bulundugu game obje'nin pozisyonu
        {
            transform.position = new Vector3(transform.position.x, ballPosition.position.y, transform.position.z);
        }
    }
}
