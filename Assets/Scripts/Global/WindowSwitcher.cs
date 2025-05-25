using System.Collections.Generic;
using UnityEngine;

public class WindowSwitcher : MonoBehaviour
{
    [SerializeField] private List<GameObject> _windows = new();

    public void SwitchWindow(int index)
    {
        for(int i = 0; i < _windows.Count; i++)
        {
            if(i == index)
                _windows[i].SetActive(true);
            else
                _windows[i].SetActive(false);
        }
    }
}
