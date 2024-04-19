using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{

    
    public List<GameObject> Items = new List<GameObject>();
    [SerializeField]
    public Image MyImage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Sunflower")
        {
            Items.Add(collision.gameObject);
            Destroy(collision.gameObject);
            print(Items[0]);
            Sprite mySprite = collision.gameObject.GetComponent<SpriteRenderer>().sprite;
            MyImage.sprite = mySprite;
        }
    }

}
