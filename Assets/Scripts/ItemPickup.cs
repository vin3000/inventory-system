using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{

    
    public List<GameObject> Items = new();
    [SerializeField]
    public List<Image> ItemSlots = new();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        if(Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i] != null)
                {
                    
                    GameObject SpawnedItem = Instantiate(Items[i], transform.position + new Vector3(-0.5f, 0, 0), transform.rotation);
                    SpawnedItem.name = Items[i].name;
                    SpawnedItem.SetActive(true);
                    Destroy(Items[i]);
                    break;
                } else
                {
                    continue;
                }

            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            Items.Add(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i] != null)
            {
                foreach(Image slot in ItemSlots)
                {
                    slot.sprite = Items[i].GetComponent<SpriteRenderer>().sprite;
                    continue;
                }
            }
            else
            {
                continue;
            }
            
        }
    }

}
