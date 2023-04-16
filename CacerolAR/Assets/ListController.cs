using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ListController : MonoBehaviour
{

    public Image img;
    public TextMeshProUGUI TMP;
    public string[] frases;
    public int selected = 0;
    public GameObject scanner;
    public Sprite[] sprites; 
    // Start is called before the first frame update
    
    public void changeObjto0()
    {
        selected = 0;
        UpdateTextUI();
    }
    public void changeObjto1()
    {
        selected = 1;
        UpdateTextUI();
    }
    public void changeObjto2()
    {
        selected = 2;
        UpdateTextUI();
    }
    public void changeObjto3()
    {
        selected = 3;
        UpdateTextUI();
    }
    public void changeObjto4()
    {
        selected = 4;
        UpdateTextUI();
    }
    void Start()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("find");
        TMP = obj.GetComponent<TextMeshProUGUI>();
        img.sprite = sprites[selected];
        TMP.text = frases[selected];
    }

    // Update is called once per frame
    void Update()
    {
        switch(selected)
        {
            case 0: scanner.SetActive(true);
                    break;
            case 1: scanner.SetActive(true);
                    break;
            default:scanner.SetActive(false);
                    break;
        }
    }
    public void UpdateTextUI()
    {
        img.sprite = sprites[selected];
        TMP.text = frases[selected];
    }
}
