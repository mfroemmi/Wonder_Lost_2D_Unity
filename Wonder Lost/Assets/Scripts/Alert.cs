using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour
{
    public GameObject symbol;
    public bool isTriggered = false;
    private ArrayList list = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggered)
        {
            if (list.Count < 1)
            {
                showAlert();
            }
        } 
        else
        {
            if (list.Count > 0)
            {
                Destroy((GameObject) list[0]);
                list.Clear();
            }
        }
    }

    private void showAlert()
    {
        GameObject g = Instantiate(symbol, transform.position, Quaternion.identity);
        list.Add(g);
    }

    public void setTrigger()
    {
        isTriggered = true;
    }

    public void releaseTrigger()
    {
        isTriggered = false;
    }
}
