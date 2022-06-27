using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour
{
    public GameObject symbol;
    public GameObject text;
    public bool isTriggered = false;
    public bool isTextTriggered = false;
    private List<GameObject> list = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggered)
        {
            foreach (var element in list)
            {
                element.transform.position = transform.position;

                if (element.CompareTag("Symbol"))
                {
                    
                }
            }
        } 
        else
        {
            foreach (var element in list)
            {
                Destroy(element);
            }
            list.Clear();
        }
    }

    private void createSymbol()
    {
        list.Add(Instantiate(symbol, transform.position, Quaternion.identity));
    }

    private void createText()
    {
        list.Add(Instantiate(text, transform.position, Quaternion.identity));
    }

    public void setTextTrigger(string message)
    {   
        if (!isTextTriggered)
        {
            isTextTriggered = true;
        }
    }

    public void setTrigger()
    {
        if (!isTriggered)
        {
            isTriggered = true;
            createSymbol();
            createText();
        }
        
    }

    public void releaseTrigger()
    {
        isTriggered = false;
    }
}
