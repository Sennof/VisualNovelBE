using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private StoryTeller _storyTeller;
    [SerializeField] private BackgroundSetter _backgroundSetter;

    [SerializeField] private TMP_Text _characterName;
    [SerializeField] private TMP_Text _replica;

    private void OnEnable()
    {
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
    }
}
