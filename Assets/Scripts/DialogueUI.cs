using TMPro;
using UnityEngine;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private StoryTeller _storyTeller;

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
            _characterName.text = replicaData.Character.Name;
            _replica.text = replicaData.Text;
        }
    }
}
