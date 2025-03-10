using UnityEngine;



//[CreateAssetMenu(fileName = "ItemObject", menuName = "Scriptable Objects/ItemObject")]
public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public GameObject inGamePrefab;
    public ItemType type;
    public string itemName;
    [TextArea(15, 20)]
    public string description;
}
