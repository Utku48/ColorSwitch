using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class BallMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float powerJump;

    public Color turkuazColor, morColor, sariColor, pembeColor;
    public string defaultColor;
    public SpriteRenderer sp;
    public float NewY = 10;
    public TextMeshProUGUI ScoreYazisi;
    public int score = 0;
    public Transform control1, control2, control3, doubleCember, cember, kare;
    public AudioSource jump;


    void Start()
    {
        CircleMove.turnSpeed = 0.2f;
        RandomColor();//Topun baslangıçta rastgele bir renk alması için fonskiyonu Start'da çağırdık.
    }

    void Update()
    {
        Debug.Log(CircleMove.turnSpeed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * powerJump;//Top'a hız vererek zıplatma
            jump.Play();
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != defaultColor && other.tag != "Swc" && other.tag != "Control1" && other.tag != "Control2" && other.tag != "Control3")
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

        if (other.gameObject.tag == "Swc")
        {
            score += 10;
            ScoreYazisi.text = "Skor: " + score;
            RandomColor();
            other.transform.position = new Vector3(other.transform.position.x, NewY, other.transform.position.z);
            NewY += 8;
            CircleMove.turnSpeed += 0.02f;//Renk Degistiriciyi aldıktan sonra Objelerin dönme hızı 0.02 artsın.

        }
        //Oyunun sonsuz yapılması
        if (other.gameObject.tag == "Control1")//Control line'ları ve Oyun objelerinin sonsuz döngü ile ötelenmesi

        {
            control1.position = new Vector3(control1.position.x, control1.position.y + 24, control1.position.z);
            cember.position = new Vector3(cember.position.x, cember.position.y + 24, cember.position.z);

        }

        if (other.gameObject.tag == "Control2")
        {
            control2.position = new Vector3(control2.position.x, control2.position.y + 24, control2.position.z);
            kare.position = new Vector3(kare.position.x, kare.position.y + 24, kare.position.z);
        }

        if (other.gameObject.tag == "Control3")
        {
            control3.position = new Vector3(control3.position.x, control3.position.y + 24, control3.position.z);
            doubleCember.position = new Vector3(doubleCember.position.x, doubleCember.position.y + 24, doubleCember.position.z);
        }

    }

    void RandomColor()//Topun Rastgele bir renk almasını sağladık.
    {
        int rastgele = Random.Range(0, 4);//4 Renk için 4 değerden biri=>0,1,2,3 Random Range'de son değeri alamaz.
        switch (rastgele)
        {
            case 0: //case 0 ise renk Turkuaz olsun
                defaultColor = "Turkuaz";
                sp.color = turkuazColor; //Sprite Renderer içindeki color == turkuaz color olsun.
                break;

            case 1:
                defaultColor = "Mor";
                sp.color = morColor;
                break;

            case 2:
                defaultColor = "Sarı";
                sp.color = sariColor;
                break;

            case 3:
                defaultColor = "Pembe";
                sp.color = pembeColor;
                break;
        }
    }
}




