using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    int selected = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void changeObjto0()
    {
        selected = 0;
    }
    public void changeObjto1()
    {
        selected = 1;
    }
    public void LoadScanner()
    {
        switch (selected)
        {
            case 0: SceneManager.LoadScene("CameraScanner 1"); break;
            case 1:SceneManager.LoadScene("Jarron"); break;
            default:break;
        }
    }
    public void HistoricButton()
    {
        SceneManager.LoadScene("Historic");
    }
    public void ScannerButton()
    {
        SceneManager.LoadScene("CameraScene");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void BackButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void BackButtonToHistoric()
    {
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
