using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class LetterBehaviourToko : MonoBehaviour
{
    public TMP_Text letter;
    public TMP_Text Visual;

    public SelectCustomer selectCustomer;
    public SelectCustomerEndless selectCustomerEndless;
    public WinManagerToko WMT;

    public ButtonBehaviour b1;
    public ButtonBehaviour b2;
    public ButtonBehaviour b3;
    public ButtonBehaviour b4;
    public ButtonBehaviour b5;
    public ButtonBehaviour b6;
    public ButtonBehaviour Space;
    [SerializeField] private bool isletter = true;
    [SerializeField] private int berapa = 0;
    private void Start()
    {
        
    }

    void Update()
    {
        
        visualize_letter();
        if (Somethingispressed())
        {
            if (Allisrelease())
            {
                compare_letter();
                Reset_button();
            }
        }

    }

    public bool Somethingispressed()
    {
        if (b1.isPressed || b2.isPressed || b3.isPressed || b4.isPressed || b5.isPressed || b6.isPressed || Space.isPressed )
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public bool Allisrelease()
    {
        if (b1.image.sprite == b1.kelepas && b2.image.sprite == b2.kelepas && b3.image.sprite == b3.kelepas && b4.image.sprite == b4.kelepas && b5.image.sprite == b5.kelepas && b6.image.sprite == b6.kelepas && Space.image.sprite == Space.kelepas)
        {
            Debug.Log("Kelepas");
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Reset_button()
    {
        b1.isPressed = false;
        b2.isPressed = false;
        b3.isPressed = false;
        b4.isPressed = false;
        b5.isPressed = false;
        b6.isPressed = false;
        Space.isPressed = false;
    }

    public void visualize_letter()
    {
        if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == false && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "A";
        }
        else if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == false && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "B";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == false && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "C";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == false && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "D";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == false && b4.isPressed == false && b5.isPressed == true && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "E";
        }
        else if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "F";
        }
        else if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "G";
        }
        else if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == false && b4.isPressed == false && b5.isPressed == true && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "H";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "I";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "J";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "K";
        }
        else if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == true && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "L";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "M";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "N";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == false && b5.isPressed == true && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "O";
        }
        else if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == true && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "P";
        }
        else if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == true && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "Q";
        }
        else if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == true && b4.isPressed == false && b5.isPressed == true && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "R";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == true && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "S";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == true && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false && isletter == true && Space.isPressed == false)
        {
            Visual.text = "T";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == false && b5.isPressed == false && b6.isPressed == true && isletter == true && Space.isPressed == false)
        {
            Visual.text = "U";
        }
        else if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == true && b4.isPressed == false && b5.isPressed == false && b6.isPressed == true && isletter == true && Space.isPressed == false)
        {
            Visual.text = "V";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == true && b6.isPressed == true && isletter == true && Space.isPressed == false)
        {
            Visual.text = "W";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == true && b5.isPressed == false && b6.isPressed == true && isletter == true && Space.isPressed == false)
        {
            Visual.text = "X";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == true && b5.isPressed == true && b6.isPressed == true && isletter == true && Space.isPressed == false)
        {
            Visual.text = "Y";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == false && b5.isPressed == true && b6.isPressed == true && isletter == true && Space.isPressed == false)
        {
            Visual.text = "Z";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == false && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false && isletter == false && Space.isPressed == false)
        {
            Visual.text = "1";
        }
        else if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == false && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false && isletter == false && Space.isPressed == false)
        {
            Visual.text = "2";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == false && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false && isletter == false && Space.isPressed == false)
        {
            Visual.text = "3";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == false && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false && isletter == false && Space.isPressed == false)
        {
            Visual.text = "4";
        }
        else if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == false && b4.isPressed == false && b5.isPressed == true && b6.isPressed == false && isletter == false && Space.isPressed == false)
        {
            Visual.text = "5";
        }
        else if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false && isletter == false && Space.isPressed == false)
        {
            Visual.text = "6";
        }
        else if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false && isletter == false && Space.isPressed == false)
        {
            Visual.text = "7";
        }
        else if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == false && b4.isPressed == false && b5.isPressed == true && b6.isPressed == false && isletter == false && Space.isPressed == false)
        {
            Visual.text = "8";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false && isletter == false && Space.isPressed == false)
        {
            Visual.text = "9";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false && isletter == false && Space.isPressed == false)
        {
            Visual.text = "0";
        }
        else if (b1.isPressed == false && b2.isPressed == false && b3.isPressed == true && b4.isPressed == true && b5.isPressed == true && b6.isPressed == true && isletter == true && Space.isPressed == false)
        {
            Visual.text = "number";
        }
        else if (b1.isPressed == false && b2.isPressed == false && b3.isPressed == true && b4.isPressed == true && b5.isPressed == true && b6.isPressed == true && isletter == false && Space.isPressed == false)
        {
            Visual.text = "letter";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == true && b4.isPressed == false && b5.isPressed == false && b6.isPressed == true && Space.isPressed == false)
        {
            Visual.text = "?";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == true && b4.isPressed == false && b5.isPressed == true && b6.isPressed == false && Space.isPressed == false)
        {
            Visual.text = "!";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == false && b4.isPressed == false && b5.isPressed == true && b6.isPressed == true && Space.isPressed == false)
        {
            Visual.text = ".";
        }
        else if (b1.isPressed == false && b2.isPressed == false && b3.isPressed == true && b4.isPressed == false && b5.isPressed == false && b6.isPressed == true && Space.isPressed == false)
        {
            Visual.text = "-";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == false && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false && Space.isPressed == false)
        {
            Visual.text = ",";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == true && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false && Space.isPressed == false)
        {
            Visual.text = ";";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == false && b4.isPressed == false && b5.isPressed == true && b6.isPressed == false && Space.isPressed == false)
        {
            Visual.text = ":";
        }
        else if (b1.isPressed == false && b2.isPressed == false && b3.isPressed == true && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false && Space.isPressed == false)
        {
            Visual.text = "/";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == true && b4.isPressed == false && b5.isPressed == false && b6.isPressed == true && Space.isPressed == false)
        {
            Visual.text = "\"";
        }
        else if (b1.isPressed == false && b2.isPressed == false && b3.isPressed == true && b4.isPressed == false && b5.isPressed == true && b6.isPressed == true && Space.isPressed == false)
        {
            Visual.text = "\"";
        }
        else if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == true && b4.isPressed == false && b5.isPressed == true && b6.isPressed == true && Space.isPressed == false)
        {
            Visual.text = "()";
        }
        else if (b1.isPressed == false && b2.isPressed == false && b3.isPressed == true && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false && Space.isPressed == false)
        {
            Visual.text = "'";
        }
        else if (b1.isPressed == false && b2.isPressed == false && b3.isPressed == false && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false && Space.isPressed == true)
        {
            Visual.text = " ";
        }
        else
        {
            Visual.text = "~";
        }
    }

    public void change_letter()
    {
        if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == false && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false)
        {
            letter.text = letter.text + "A";
        }
        if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == false && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false)
        {
            letter.text = letter.text + "B";
        }
        if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == false && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false)
        {
            letter.text = letter.text + "C";
        }
        if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == false && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false)
        {
            letter.text = letter.text + "D";
        }
        if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == false && b4.isPressed == false && b5.isPressed == true && b6.isPressed == false)
        {
            letter.text = letter.text + "E";
        }
        if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false)
        {
            letter.text = letter.text + "F";
        }
        if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false)
        {
            letter.text = letter.text + "G";
        }
        if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == false && b4.isPressed == false && b5.isPressed == true && b6.isPressed == false)
        {
            letter.text = letter.text + "H";
        }
        if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false)
        {
            letter.text = letter.text + "I";
        }
        if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false)
        {
            letter.text = letter.text + "J";
        }
        if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false)
        {
            letter.text = letter.text + "K";
        }
        if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == true && b4.isPressed == false && b5.isPressed == false && b6.isPressed == false)
        {
            letter.text = letter.text + "L";
        }
        if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false)
        {
            letter.text = letter.text + "M";
        }
        if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false)
        {
            letter.text = letter.text + "N";
        }
        if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == false && b5.isPressed == true && b6.isPressed == false)
        {
            letter.text = letter.text + "O";
        }
        if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == true && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false)
        {
            letter.text = letter.text + "P";
        }
        if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == true && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false)
        {
            letter.text = letter.text + "Q";
        }
        if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == true && b4.isPressed == false && b5.isPressed == true && b6.isPressed == false)
        {
            letter.text = letter.text + "R";
        }
        if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == true && b4.isPressed == true && b5.isPressed == false && b6.isPressed == false)
        {
            letter.text = letter.text + "S";
        }
        if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == true && b4.isPressed == true && b5.isPressed == true && b6.isPressed == false)
        {
            letter.text = letter.text + "T";
        }
        if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == false && b5.isPressed == false && b6.isPressed == true)
        {
            letter.text = letter.text + "U";
        }
        if (b1.isPressed == true && b2.isPressed == true && b3.isPressed == true && b4.isPressed == false && b5.isPressed == false && b6.isPressed == true)
        {
            letter.text = letter.text + "V";
        }
        if (b1.isPressed == false && b2.isPressed == true && b3.isPressed == false && b4.isPressed == true && b5.isPressed == true && b6.isPressed == true)
        {
            letter.text = letter.text + "W";
        }
        if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == true && b5.isPressed == false && b6.isPressed == true)
        {
            letter.text = letter.text + "X";
        }
        if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == true && b5.isPressed == true && b6.isPressed == true)
        {
            letter.text = letter.text + "Y";
        }
        if (b1.isPressed == true && b2.isPressed == false && b3.isPressed == true && b4.isPressed == false && b5.isPressed == true && b6.isPressed == true)
        {
            letter.text = letter.text + "Z";
        }

    }

    public void compare_letter()
    {
        //Debug.Log("panjang :" + letter.text.Length);
        if (letter.text.Length > 0 && Visual.text.Length < 2)
        {
            char firstvisualtext = Visual.text[0];
            char firstlettertext = letter.text[0];
            if (firstlettertext == firstvisualtext)
            {
                
                WMT.BPMhitungan++;
                letter.text = letter.text.Substring(1);
                //Debug.Log(letter.text);
            }
        }
        else if (Visual.text.Length > 1)
        {
            
            if (isletter)
            {
                isletter = false;
            }
            else
            {
                isletter = true;
            }
        }
        //Debug.Log("SETELAH: "+letter.text);
        if (letter.text.Length == 0)
        {
            pesananselesaidiketik();
        }
        //Debug.Log("SETELAH2: " + letter.text);
    }

    public void pesananselesaidiketik()
    {
        letter.text = "*no order*";
        Scene scene = SceneManager.GetActiveScene();
        WMT.SChitungan++;
        //Debug.Log("pesanan done");
        if (scene.name == "EndlessMode")
        {
            selectCustomerEndless.OrderSelesai();
        }
        else
        {
            Debug.Log("pesanan done");
            selectCustomer.OrderSelesai();
        }

    }



}
