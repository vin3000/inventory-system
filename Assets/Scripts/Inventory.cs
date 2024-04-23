using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    Image myImage;
    void Start()
    {
        myImage = GetComponent<Image>();
        List<Image> slotImages;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(myImage.enabled)
            {
                myImage.enabled = false;
            } 
            else
            {
                myImage.enabled = true;
            }

        }
    }
}
