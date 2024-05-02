using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.Model
{
    [CreateAssetMenu]
    public class ItemSO : ScriptableObject
    {
        [field: SerializeField]

        public bool IsStackable { get; set; }

        public int ID => GetInstanceID();

        [field: SerializeField]

        public int MaxStackSize { get; set; } = 1;

        [field: SerializeField]
        public string Name { get; set; }

        [field: SerializeField]
        [field: TextArea]
        public string Description { get; set; }

        [field: SerializeField]
        public Sprite ItemImage { get; set; }

        public static implicit operator ItemSO(InventoryItem v)
        {
            throw new NotImplementedException();
        }
    }
    public interface IItemAction
    {
        public string ActionName { get; }

        bool PerformAction(GameObject character);
    }
}