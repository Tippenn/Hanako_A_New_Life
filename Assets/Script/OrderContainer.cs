using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// Tugas dia buat container dari order dan buat minta orderan dan selesaiin orderan.
public class OrderContainer : MonoBehaviour
{
    public string pesanan;
    public Animator animator;
    public Image gambarorang;
    public List<Sprite> contohorang;
    public GameObject Orang;
    public Slider Gaugemeter;
    public SoalManager SoalManager;
    public LetterBehaviourToko LBT;
    public WinManagerToko WMT;
    public float gauge = 0f;
    public bool chargegauge = false;
    public bool isempty = true;
    private void Start()
    {
        Debug.Log("start called");
        isempty = true;
        gambarorang = Orang.GetComponent<Image>();
    }
    private void Update()
    {
        if (isempty && SoalManager.urutansoal < 10)
        {
            Debug.Log("dsadasd");
            Invoke(nameof(orangdatang), Random.Range(2f, 5f));
            Debug.Log("dsadasddsada");
            isempty = false;
        }

        if (chargegauge)
        {
            gauge += Time.deltaTime;
            Gaugemeter.value = gauge;
        }

        if (gauge >= 60f)
        {
            AkuMarah();
        }
    }
    public void orangdatang()
    {
        Debug.Log("dsadasddsadafas");
        if (SoalManager.urutansoal < 10)
        {
            chargegauge = true;
            mintapesanan();
            spawnorang();

        }

    }
    public void mintapesanan()
    {
        Debug.Log("Pesanan didapatkan");
        if (SoalManager.urutansoal < 10)
        {
            pesanan = SoalManager.soal[SoalManager.urutansoal];
            SoalManager.NextSoal();
        }

    }

    public void spawnorang()
    {
        Sprite sprite = contohorang[Random.Range(0, 4)];
        gambarorang.sprite = sprite;
        animator.SetBool("OrangDatang", true);
        animator.SetBool("OrangPergi", false);
    }

    public void resetOrder()
    {
        Scene currentscene = SceneManager.GetActiveScene();
        if(currentscene.name == "TokoModeScene")
        {
            SoalManager.soaldone++;
        }
        
        Debug.Log("pesanan selesai :" + SoalManager.soaldone);
        isempty = true;
        chargegauge = false;

        gauge = 0f;
        Gaugemeter.value = gauge;

        pesanan = "*no order*";
        despawnorang();
    }

    public void despawnorang()
    {
        animator.SetBool("OrangPergi", true);
        animator.SetBool("OrangDatang", false);
    }

    public void AkuMarah()
    {
        resetOrder();
        WMT.USChitungan++;
    }
}
