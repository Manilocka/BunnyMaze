using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;

public class ConversationTrigger : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;
    void Start()
    {
        ConversationManager.Instance.StartConversation(myConversation);
    }

    void Update()
    {
        
    }
}
