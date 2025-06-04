using System.Collections.Generic;
using UnityEngine;

public class ActionButtonsSetter : MonoBehaviour
{
    [SerializeField] private List<ActionCard> _actionCards;

    public void SetButtons(List<ActionData> datas)
    {
        for(int i = 0;  i < datas.Count; i++)
        {
            _actionCards[i].Initialize(datas[i]);
            _actionCards[i].gameObject.SetActive(true);
        }
        for(int i = datas.Count; i < _actionCards.Count; i++)
        {
            _actionCards[i].gameObject.SetActive(false);
        }
    }
}
