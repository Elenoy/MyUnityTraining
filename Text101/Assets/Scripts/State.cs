using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="State")]
public class State : ScriptableObject {
    [TextArea(14, 10)] [SerializeField] string StoryText;
    [SerializeField] State[] nextStates;

    public string GetStoryText()
    {
        return StoryText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
