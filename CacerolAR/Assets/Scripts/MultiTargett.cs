using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTargett : MonoBehaviour
{
    [SerializeField] private GameObject startModel;
    private int modelsCount;
    private int indextCurrentModel;

    //public float RotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        modelsCount = transform.childCount;
        indextCurrentModel = startModel.transform.GetSiblingIndex(); 
    }
    public void ChangeARModel(int index)
    {
    transform.GetChild(indextCurrentModel).gameObject.SetActive(false);
    int newIndex = indextCurrentModel + index;
    if (newIndex < 0)
    {
    newIndex = modelsCount - 1;
    }
    else if (newIndex > modelsCount - 1)
    {
    newIndex = 0;
    }
    GameObject newModel = transform.GetChild(newIndex).gameObject;
    newModel.SetActive(true);
    indextCurrentModel = newModel.transform.GetSiblingIndex();
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.GetChild(indextCurrentModel).gameObject.transform.Rotate(0f, RotationSpeed, 0f);
    }
}
