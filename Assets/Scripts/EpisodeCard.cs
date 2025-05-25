using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EpisodeCard : MonoBehaviour
{
    [SerializeField] private TMP_Text _index;
    [SerializeField] private TMP_Text _title;

    [SerializeField] private Image _lockIcon;
    [SerializeField] private List<Sprite> _lockerIcons;

    public void Initialize(EpisodeData episodeData, bool isPrevEpAvailiable)
    {
        _index.text = episodeData.Index.ToString();
        _title.text = episodeData.Title.ToString();
        SetIcon(episodeData.IsAvailiable, isPrevEpAvailiable);
    }

    private void SetIcon(bool isAvailiable, bool isPrevEpAvailiable)
    {
        //TODO: check savedata if user have already bought the story => return;
        _lockIcon.gameObject.SetActive(true);

        if (!isAvailiable)
        {
            _lockIcon.sprite = _lockerIcons[2];
            return;
        }

        if (isPrevEpAvailiable)
            _lockIcon.sprite = _lockerIcons[1];
        else
            _lockIcon.gameObject.SetActive(false);
    }
}
