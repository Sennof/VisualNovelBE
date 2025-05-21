using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Data/Character", order = 1)]
public class PersonData : ScriptableObject
{
    [Header("Visualized information")]
    [Tooltip("The name of the character")]
    public string Name;
    [Tooltip("The image of the character")]
    public Sprite Image;
}
