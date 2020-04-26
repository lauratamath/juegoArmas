using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChangeC : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        GetComponent<MeshRenderer>().material.color = Color.gray;
    }

    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

}
