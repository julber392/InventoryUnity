using UnityEngine;

namespace Core
{
    [CreateAssetMenu(fileName = "NewItem", menuName = "ScriptableObject/Item")]
    public class Item : ScriptableObject
    {
        public int Id;
        public string Name = "Item";
        public Sprite Icon;
        public int price;
        public bool stackable;
    }
}
