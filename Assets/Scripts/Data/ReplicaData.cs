using UnityEngine;

[CreateAssetMenu(fileName = "New Replica", menuName = "Data/Replica", order = 1)]
public class ReplicaData : ScriptableObject
{
    [Header("Visualized information")]
    [Tooltip("Information about the character speaking the line")]
    public PersonData Character;
    [Tooltip("A line spoken by a character")]
    public string Text;

    [Header("Information for logic")]
    [Tooltip("The place of the screen to which the background is attached")]
    public BgOffsetEnum OffsetType = BgOffsetEnum.None;
}
