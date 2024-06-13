using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCustomer : MonoBehaviour
{
    public List<GameObject> posisiduduk;
    public SoalManager soalManager;
    public OrderContainer orderContainer;
    public LetterBehaviourToko LBT;
    public int choice = 0;
    public Image gambarduduk;

    private void Start()
    {
        soalManager = GetComponent<SoalManager>();
        LBT = GetComponent<LetterBehaviourToko>();
        changechoice();
    }
    private void Update()
    {
        //ChangePesanan();
        if (Input.GetKeyDown(KeyCode.H))
        {
            if(choice < 2)
            {
                choice++;
                changechoice();
            }   
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (choice > 0)
            {
                choice--;
                changechoice();
            }
        }
    }

    public void changechoice()
    {
        ChangeVisual();
        ChangePesanan();
    }

    public void ChangeVisual()
    {
        foreach (GameObject pd in posisiduduk)
        {
            gambarduduk = pd.GetComponent<Image>();
            gambarduduk.color = Color.black;
        }
        gambarduduk = posisiduduk[choice].GetComponent<Image>();
        gambarduduk.color = Color.white;
    }

    public void ChangePesanan()
    {
        orderContainer = posisiduduk[choice].GetComponent<OrderContainer>();
        LBT.letter.text = orderContainer.pesanan;
    }

    public void OrderSelesai()
    {
        orderContainer.resetOrder();
    }
}
