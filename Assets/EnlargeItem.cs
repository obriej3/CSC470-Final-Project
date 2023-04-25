using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargeItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver()
    {
        transform.localScale = new Vector3(3F, 8f, 3f);
    }

    public void OnMouseExit()
    {
        transform.localScale = new Vector3(2, 7, 2); 
    }
}
