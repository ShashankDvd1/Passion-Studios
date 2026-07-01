using UnityEngine;
using System.Collections.Generic;

namespace WonderForge.TinyWorld.Core.Config
{
    [System.Serializable]
    public struct DialogueLine
    {
        public string SpeakerName;
        [TextArea(3, 5)]
        public string Message;
    }

    [CreateAssetMenu(fileName = "NewDialogue", menuName = "TinyWorld/Dialogue Definition")]
    public class DialogueDefinition : ScriptableObject
    {
        [Tooltip("Unique ID used to trigger this dialogue from code.")]
        public string NodeID;
        
        [Tooltip("The sequence of messages for this conversation.")]
        public List<DialogueLine> Lines = new List<DialogueLine>();
    }
}
