using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private ChestTrigger chestToUnlock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            chestToUnlock.UnlockChest();
            gameObject.SetActive(false);
        }
    }

    private void OnDrawGizmos()
    {
        if (chestToUnlock != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawRay(transform.position, chestToUnlock.transform.position - transform.position);
        }
        else
        {
            Gizmos.color = Color.black;
            Gizmos.DrawSphere(transform.position + Vector3.up * 1, 0.2f);
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(transform.position + Vector3.up * 1, 0.18f);
        }
    }
}
