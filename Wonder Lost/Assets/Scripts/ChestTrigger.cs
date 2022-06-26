using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTrigger : MonoBehaviour
{
    private Rigidbody rb;
    private bool isPlayerInRange = false;
    private bool isKeyPressed = false;
    private bool isChestUnlocked = false;
    private GameObject player;
    private GameObject exclamation;
    private Alert alert;

    [SerializeField] private GameObject chestOpen, chestClose;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        exclamation = GameObject.Find("SymbolPosition");
        alert = (Alert)exclamation.GetComponent(typeof(Alert));

        chestOpen.SetActive(false);
        chestClose.SetActive(true);
    }

    private void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            isKeyPressed = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
            alert.setTrigger();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = false;
            alert.releaseTrigger();
        }
    }

    private void FixedUpdate()
    {
        if (isChestUnlocked && isPlayerInRange && isKeyPressed)
        {
            isKeyPressed = false;

            chestOpen.SetActive(true);
            chestClose.SetActive(false);
        }

        if (!isChestUnlocked && isPlayerInRange && isKeyPressed)
        {
            Debug.Log("You need a key!");
            isKeyPressed = false;
        }
    }

    public void UnlockChest()
    {
        isChestUnlocked = true;
    }
}
