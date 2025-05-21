using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Data/Dialogue", order = 1)]
public class DialogueData : ScriptableObject
{
    [Header("Information for logic")]
    [Tooltip("Character cues, after which the player will be given a choice")]
    public List<ReplicaData> Replics;
    [Tooltip("A choice that gives buffs or debuffs")]
    public List<ActionData> Actions;
}
