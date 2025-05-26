using System.Collections.Generic;
using UnityEngine;

public class EpisodesWindowSetter : MonoBehaviour
{
    [SerializeField] private Transform _cardsFolder;
    [SerializeField] private GameObject _episodeCardPrefab;

    private List<GameObject> _genCards = new(); 

    public void SetEpisodes(List<EpisodeData> episodes)
    {
        DestroyGenerated();

        for(int i = 0; i < episodes.Count; i++)
        {
            int prevEpId = (i > 0) ? i - 1 : 0;
            GameObject genCard = Instantiate(_episodeCardPrefab, _cardsFolder);
            genCard.GetComponent<EpisodeCard>().Initialize(episodes[i], true);
            _genCards.Add(genCard);
        }
    }

    private void DestroyGenerated()
    {
        foreach(GameObject genCard in _genCards)
        {
            Destroy(genCard);
        }
    }
}
