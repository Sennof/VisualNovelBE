using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Episode", menuName = "Data/Episode", order = 1)]
public class EpisodeData : ScriptableObject
{
    [Header("Visualized information")]
    [Tooltip("The name of the episode that the player will see")]
    public string Title;

    [Header("Information for logic")]
    [Tooltip("Local episode index among other episodes in the story")]
    public int Index;
    [Tooltip("All dialogues of the episode")]
    public List<DialogueData> Dialogues;

    [Header("Payment information")]
    [Tooltip("Does the player need to buy an episode")]
    public bool IsPaid;
    [Tooltip("The cost of the episode in the game currency")]
    public int Price = 0;
}
