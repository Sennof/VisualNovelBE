using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StoryTeller : MonoBehaviour
{
    [SerializeField] private WindowSwitcher _windowSwitcher;

    private List<DialogueData> _dialogues; 
    private int _dialogueIndex = 0;
    private int _replicaIndex = 0;

    public void SetData(EpisodeData episodeData)
    {
        _dialogues = episodeData.Dialogues;
        _dialogueIndex = 0;
        _replicaIndex = 0;
    }

    public ReplicaData GetReplica()
    {
        if (_dialogues[_dialogueIndex].Replics.Count > _replicaIndex)
        {
            _replicaIndex++;
            return _dialogues[_dialogueIndex].Replics[_replicaIndex-1];
        }
        else
        {
            if(_dialogues.Count - 1 == _dialogueIndex)
            {
                _windowSwitcher.SwitchWindow(1);
                return null;
            }

            _dialogueIndex++;
            _replicaIndex = 0;
            return GetReplica();
        }
    }
}
