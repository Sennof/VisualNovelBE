using TMPro;
using UnityEngine;

public class ActionCard : MonoBehaviour
{
    [SerializeField] private TMP_Text _title;
    [SerializeField] private GameObject _locker;
    [SerializeField] private TMP_Text _price;

    //action manager

    public void Initialize(ActionData data)
    {
        _title.text = data.Title;
        _locker.SetActive(data.IsPaid);
        _price.text = data.Price.ToString();
    }

    public void DoAction()
    {
        //action manager
        Debug.Log("Action Plug");
    }
}
