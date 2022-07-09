using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alert : MonoBehaviour
{
    public GameObject symbol;
    public GameObject textObject;
    private Text objectText;
    public bool isTriggered = false;
    public bool isTextTriggered = false;
    private List<GameObject> list = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        objectText = textObject.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggered)
        {
            foreach (var element in list)
            {
                element.transform.position = transform.position;
            }
        } 
        else
        {
            clearList();
        }
    }

    private void createSymbol()
    {
        list.Add(Instantiate(symbol, transform.position, Quaternion.identity));
    }

    private void createText(string message)
    {
        objectText.text = message;
        list.Add(Instantiate(textObject, transform.position, Quaternion.identity));
    }

    public void setTrigger(string from, string message = "")
    {
        if (!isTriggered)
        {
            if (from == "symbol")
            {
                createSymbol();
            }

            if (from == "text")
            {
                createText(message);
            }
            isTriggered = true;
        }
        
    }

    public void releaseTrigger()
    {
        isTriggered = false;
        clearList();
    }

    public void clearList()
    {
        foreach (var element in list)
        {
            Destroy(element);
        }
        list.Clear();
    }
}
