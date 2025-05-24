using UnityEngine;

public class Entrypoint : MonoBehaviour
{
    private void Awake()
    {
        InitializeHistoryCards();
    }

    private void InitializeHistoryCards()
    {
        GameObject.FindAnyObjectByType<HistoryCardGenerator>().Initialize();
    }
}
