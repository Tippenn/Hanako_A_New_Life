using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
        
    public KeyCode button;
    //[HideInInspector]
    public bool isPressed = false;
    public Image image;
    public Sprite ketekan;
    public Sprite kelepas;
    public AudioManager audioManager;
    // Start is called before the first frame update

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    void Start()
    {
        isPressed = false;
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(button))
        {
            audioManager.PlaySFX(audioManager.Tekan);
            isPressed = true;
            image.sprite = ketekan;
        }

        if (Input.GetKeyUp(button))
        {
            audioManager.PlaySFX(audioManager.Lepas);
            image.sprite = kelepas;
        }
    }
}
