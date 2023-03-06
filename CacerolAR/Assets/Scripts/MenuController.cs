using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void HistoricButton()
    {
        SceneManager.LoadScene("Historic");
    }
    public void ScannerButton()
    {
        SceneManager.LoadScene("CameraScanner");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void BackButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
