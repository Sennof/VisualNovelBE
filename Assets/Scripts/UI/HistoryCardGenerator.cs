using System.Collections.Generic;
using UnityEngine;

public class HistoryCardGenerator : MonoBehaviour
{
    [SerializeField] private string _pathToData;

    [SerializeField] private Transform _cardFolder;
    [SerializeField] private GameObject _cardPrefab;

    private HistoryData[] _histories;
    private List<GameObject> _generatedCards;

    public void Initialize()
    {
        LoadHistoriesData();
        GenerateUI();
    }

    private void LoadHistoriesData()
    {
        _histories = Resources.LoadAll<HistoryData>(_pathToData);
    }

    private void GenerateUI()
    {
        if (_histories == null)
            return;

        foreach(HistoryData data in _histories)
        {
            GameObject genCard = Instantiate(_cardPrefab, _cardFolder);
            genCard.GetComponent<HistoryCard>().Initialize(data);
        }
    }
}
