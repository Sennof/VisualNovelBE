using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New History", menuName = "Data/History", order = 1)]
public class HistoryData : ScriptableObject
{
    [Header("Visualized information")]
    [Tooltip("The name of the story that the player will see")]
    public string Title;
    [Tooltip("The description of the story that the player will see")]
    public string Description;
    [Tooltip("Image that is used as a cover.")]
    public Sprite Banner;
    [Tooltip("The color on which the background color depends")]
    public Color ThemeColor;

    [Header("Information for logic")]
    [Tooltip("Global story index among other stories")]
    public int Index;
    [Tooltip("All episodes of the story")]
    public List<EpisodeData> Episodes;
}
