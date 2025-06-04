using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private StoryTeller _storyTeller;
    [SerializeField] private BackgroundSetter _backgroundSetter;
    [SerializeField] private ActionButtonsSetter _actionButtonSetter;

    [SerializeField] private TMP_Text _characterName;
    [SerializeField] private TMP_Text _replica;

    [SerializeField] private GameObject _choiceWindow;
    [SerializeField] private GameObject _dialogueMenu;
    [SerializeField] private Button _mainButton;

    private void OnEnable()
    {
        SetUI();
    }

    public void TurnOnChoiceWindow()
    {
        _mainButton.interactable = false;
        _dialogueMenu.SetActive(false);
        _choiceWindow.SetActive(true);
    }

    public void TurnOffChoiceWindow()
    {
        _choiceWindow.SetActive(false);
        _dialogueMenu?.SetActive(true);
        _mainButton.interactable = true;
        SetUI();
    }

    public void SetUI()
    {
        ReplicaData replicaData = _storyTeller.GetReplica();
        if (replicaData != null)
        {
            _backgroundSetter.SetBackground(_storyTeller.GetBg() ,replicaData.OffsetType, replicaData.Character.Image);

            _characterName.text = replicaData.Character.Name;
            _replica.text = replicaData.Text;
        }
        else
        {
            TurnOnChoiceWindow();
            _actionButtonSetter.SetButtons(_storyTeller.GetActions());
        }
    }
}
