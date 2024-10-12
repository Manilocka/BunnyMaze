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
// using System.Collections;
// using System.Collections.Generic;
// using DialogueEditor;
// using UnityEngine;
// using UnityEngine.SceneManagement; 

// public class ConversationTrigger : MonoBehaviour
// {
//     [SerializeField] private NPCConversation myConversation;

//     void Start()
//     {
//         ConversationManager.Instance.StartConversation(myConversation);
//         myConversation.OnConversationEnd += OnConversationEnd;
//     }

//     private void OnConversationEnd()
//     {

//         ChangeSceneToLevel();
//     }

//     private void ChangeSceneToLevel()
//     {

//         SceneManager.LoadScene("Level");
//     }

//     void Update()
//     {
//     }
// }