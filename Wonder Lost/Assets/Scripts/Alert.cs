using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour
{
    public GameObject symbol;
    public bool isTriggered = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        if (isTriggered)
        {
            showAlert();
        }
    }
    private void showAlert()
    {
        GameObject g = Instantiate(symbol, transform.position, Quaternion.identity);
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
