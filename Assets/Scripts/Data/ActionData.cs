using AYellowpaper.SerializedCollections;
using UnityEngine;

[CreateAssetMenu(fileName = "New Action", menuName = "Data/Action", order = 1)]
public class ActionData : ScriptableObject
{
    [Header("Visualized information")]
    [Tooltip("Title of the action")]
    public string Title;

    [Header("Information for logic")]
    [Tooltip("Required relationship")]
    [SerializedDictionary("Relationship", "Value")]
    public SerializedDictionary<RelationhshipEnum, int> RequiredRelationship;
    [Tooltip("Effects obtained from the action")]
    [SerializedDictionary("Effect", "Value")]
    public SerializedDictionary<RelationhshipEnum, int> Effects;
    [Tooltip("The parameter is responsible for paying for the replica")]
    public bool IsPaid;
    [Tooltip("Cost per replica")]
    public int Price = 0;
}
