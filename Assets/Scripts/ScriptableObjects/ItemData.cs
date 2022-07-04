using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new ItemData", menuName = "Item Data", order = 51)]
    public class ItemData : ScriptableObject
    {
        [SerializeField] private Sprite _preview;
        [SerializeField] private string _label;
        [SerializeField] private GameObject _prefab;
        
        public Sprite Preview => _preview;
        public string Label => _label;
        public GameObject Prefab => _prefab;
    }
}