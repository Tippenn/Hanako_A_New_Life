using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OrderContainerEndless : MonoBehaviour
{
    public string pesanan;
    public Animator animator;
    public Image gambarorang;
    public List<Sprite> contohorang;
    public GameObject Orang;
    public Slider Gaugemeter;
    public SoalManagerEndless SoalManagerEndless;
    public LetterBehaviourToko LBT;
    public WinManagerToko WMT;
    public float gauge = 0f;
    public bool chargegauge = false;
    public bool isempty = true;
    private void Start()
    {
        gambarorang = Orang.GetComponent<Image>();
    }
    private void Update()
    {
        if (isempty && SoalManagerEndless.timeleft > 0f)
        {
            Debug.Log("AKudatang");
            isempty = false;
            Invoke("orangdatang", Random.Range(2f, 5f));
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
        if (SoalManagerEndless.timeleft > 0f)
        {
            chargegauge = true;
            mintapesanan();
            spawnorang();

        }

    }
    public void mintapesanan()
    {
        Debug.Log("Pesanan didapatkan");
        pesanan = SoalManagerEndless.soal[Random.Range(0,10)];
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
