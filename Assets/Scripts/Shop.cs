using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private string name;
    private Inventory inventory;

    public bool IsActive { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag + " has entered store activation zone");
        IsActive = true;
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.tag + " has exited store activation zone");
        IsActive = false;
    }
}
