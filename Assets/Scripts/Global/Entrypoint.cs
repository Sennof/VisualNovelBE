using UnityEngine;

public class Entrypoint : MonoBehaviour
{
    private void Awake()
    {
        InitializeHistoryCards();
        //InitializeActionButtons();
    }

    private void InitializeHistoryCards() => GameObject.FindAnyObjectByType<HistoryCardGenerator>().Initialize();
 
    //private void InitializeActionButtons() => GameObject.FindAnyObjectByType<ActionButtonsSetter>().Initialize();
}
