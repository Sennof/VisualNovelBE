using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EpisodeCard : MonoBehaviour
{
    [SerializeField] private TMP_Text _index;
    [SerializeField] private TMP_Text _title;

    [SerializeField] private Image _lockIcon;
    [SerializeField] private List<Color> _lockerColors;

    public void Initialize(EpisodeData episodeData, bool isPrevEpAvailiable) //TODO: check save if availiable
    {
        _index.text = episodeData.Index.ToString();
        _title.text = episodeData.Title.ToString();
        SetIcon(episodeData.IsPaid, isPrevEpAvailiable);
    }

    private void SetIcon(bool isPaid, bool isPrevEpAvailiable)
    {
        //TODO: check savedata if user have already bought the story => return;
        _lockIcon.gameObject.SetActive(true);

        if (isPaid)
        {
            _lockIcon.color = _lockerColors[1];
            return;
        }

        if (!isPrevEpAvailiable)
            _lockIcon.color = _lockerColors[0];
        else
            _lockIcon.gameObject.SetActive(false);
    }
}
