using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using static UnityEngine.GraphicsBuffer;


public class BallMoves : MonoBehaviour
{

    public Rigidbody2D top;
    public float ziplamaGuc;
    public Color turkuazRenk, sariRenk, morRenk, pembeRenk;
    public string mevcutRenk;
    public SpriteRenderer ressam;
    public Transform renkdegistiricipozisyon;
    public TextMeshProUGUI skorYazisi,oyunbittiyazisi;
    public static int skor;
    public Transform kontrol1, kontrol2, kontrol3,kontrol4, cember1, cember2, kare, cemberx2;
    public AudioSource jump, arkaplanmuzik;
    public GameObject yenidenoynapanel;

    [SerializeField]
    bool inPlay;

    [SerializeField]
    Transform ballStartPosition;



    private void Awake()
    {
        top = GetComponent<Rigidbody2D>();  //**//
    }


    void Start()
    {
        arkaplanmuzik.Play();
        RastgeleRenk();
        top.GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    void Update()
    {


        if (!inPlay)
        {
            transform.position = ballStartPosition.position;   //**//
        }


        
        if (Input.GetButtonDown("Jump"))
        {
            inPlay = true;  //***//
            top.GetComponent<Rigidbody2D>().gravityScale = 2;
            top.velocity = Vector2.up * ziplamaGuc;
            jump.Play();
        }

        skorYazisi.text = "Skor:" + skor.ToString();
        oyunbittiyazisi.text = "Tebrikler"+"\n" + "Skorunuz:" + skor.ToString();

    }

    void RastgeleRenk()
    {
        int rastgele = Random.Range(0, 4);
        
        switch (rastgele)
        {
            case 0: mevcutRenk = "Turkuaz";
                ressam.color = turkuazRenk;
                break;

            case 1: mevcutRenk = "Sarý";
                    ressam.color= sariRenk;
                break;

            case 2: mevcutRenk = "Mor";
                ressam.color = morRenk;
                break;

            case 3: mevcutRenk = "Pembe";
                ressam.color = pembeRenk;
                break;


        }
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.tag != mevcutRenk && temas.tag != "RenkDegistirici" && temas.tag != "Kontrol1" && temas.tag != "Kontrol2" && temas.tag != "Kontrol3" && temas.tag != "Kontrol4")
        {
            Time.timeScale = 0;
            yenidenoynapanel.SetActive(true);
            inPlay = false;  //***//
            top.velocity = Vector2.zero;

            if (temas.tag == "Kontrol")
            {
                Debug.Log("Temas etti");
                Time.timeScale = 0;
                yenidenoynapanel.SetActive(true);
                inPlay = false;  //***//
                top.velocity = Vector2.zero;
            }

            
        }

        if (temas.tag == "RenkDegistirici")
        {
            skor += 5;
            renkdegistiricipozisyon.position = new Vector3(renkdegistiricipozisyon.position.x, renkdegistiricipozisyon.position.y + 8f, renkdegistiricipozisyon.position.z);                                                                                                      // Destroy(temas.gameObject);  ( tekrarlýycaz bu iptal
            RastgeleRenk();
        }

        if (temas.tag =="Kontrol1")
        {
            cember1.position = new Vector3 (cember1.position.x, cember1.position.y+32f, cember1.position.z);
            kontrol1.position = new Vector3 (kontrol1.position.x, kontrol1.position.y+31f, kontrol1.position.z);
            CemberDondurme.dondurmeHiz += 0.3f;
        }
        if (temas.tag == "Kontrol2")
        {
            cember2.position = new Vector3(cember2.position.x, cember2.position.y + 32f, cember2.position.z);
            kontrol2.position = new Vector3(kontrol2.position.x, kontrol2.position.y + 31f, kontrol2.position.z);
            CemberDondurme.dondurmeHiz += 0.3f;
        }
        if (temas.tag == "Kontrol3")
        {
            kare.position = new Vector3(kare.position.x, kare.position.y + 32f, kare.position.z);
            kontrol3.position = new Vector3(kontrol3.position.x, kontrol3.position.y + 31f, kontrol3.position.z);
            CemberDondurme.dondurmeHiz += 0.3f;
        }
        if (temas.tag == "Kontrol4")
        {
            cemberx2.position = new Vector3(cemberx2.position.x, cemberx2.position.y + 32f, cemberx2.position.z);
            kontrol4.position = new Vector3(kontrol4.position.x, kontrol4.position.y + 31f, kontrol4.position.z);
            CemberDondurme.dondurmeHiz += 0.3f;
        }
        

    }

    



}
