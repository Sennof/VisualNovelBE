using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HistoryCard : MonoBehaviour
{
    [SerializeField] private Image _bannerImage;
    [SerializeField] private TMP_Text _genre;
    [SerializeField] private TMP_Text _episodeNum;
    [SerializeField] private TMP_Text _description;

    public void Initialize(HistoryData data)
    {
        _bannerImage.sprite = data.Banner;
        _genre.text = GenerateGenreText(data.Genres);
        _episodeNum.text = $"Серия $ из {data.Episodes.Count}"; //instead of $, there will be a download from the save
        _description.text = data.Description;
    }

    public void SelectStory()
    {

    }

    private string GenerateGenreText(List<HistoryGenreEnum> genres)
    {
        string text = "";

        for(int i = 0; i < genres.Count; i++)
        {
            string genre = "";
            switch (genres[i])
            {
                case HistoryGenreEnum.Adventure:
                    genre = "Приключения";
                    break;
                case HistoryGenreEnum.Science:
                    genre = "Научное";
                    break;
                case HistoryGenreEnum.Fantasy:
                    genre = "Фэнтези";
                    break;
                case HistoryGenreEnum.Drama:
                    genre = "Драма";
                    break;
            }

            if (i == genres.Count - 1)
                return text += genre + ".";

            text += genre + ",";
        }
        return text;
    }
}
