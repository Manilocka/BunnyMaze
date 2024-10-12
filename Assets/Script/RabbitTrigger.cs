// using System.Collections;
// using System.Collections.Generic;
// using DialogueEditor;
// using UnityEngine;

// public class RabbitTrigger : MonoBehaviour
// {
//     [SerializeField] private NPCConversation myConversation;
//     private bool hasStartedConversation = false; 

//     private void OnTriggerEnter(Collider other)
//     {
//         if (!hasStartedConversation && other.CompareTag("Player"))
//         {
//             hasStartedConversation = true;  
//             ConversationManager.Instance.StartConversation(myConversation);
//         }
//     }

//     private void OnTriggerExit(Collider other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             hasStartedConversation = false; 
//         }
//     }
// }


// using System.Collections;
// using System.Collections.Generic;
// using DialogueEditor;
// using UnityEngine;

// public class RabbitTrigger : MonoBehaviour
// {
//     [SerializeField] private NPCConversation myConversation;
//     private bool hasStartedConversation = false;
//     private AttackScript attackScript; 
//     private void Start()
//     {
//         attackScript = FindObjectOfType<AttackScript>(); 
//     }

//     private void OnTriggerEnter(Collider other)
//     {
//         if (!hasStartedConversation && other.CompareTag("Player"))
//         {
//             hasStartedConversation = true; 


//             attackScript.HideWeapon(); 
//             Cursor.visible = true; 
//             Cursor.lockState = CursorLockMode.None; 

//             ConversationManager.Instance.StartConversation(myConversation);
//         }
//     }

//     private void OnTriggerExit(Collider other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             hasStartedConversation = false;

       
//             attackScript.ShowWeapon(); 
//             Cursor.visible = false;
//             Cursor.lockState = CursorLockMode.Locked; 
//         }
//     }
// }

// using UnityEngine;
// using DialogueEditor;

// public class RabbitTrigger : MonoBehaviour
// {
//     [SerializeField] private NPCConversation myConversation;
//     private bool hasStartedConversation = false;
//     private AttackScript attackScript; 
//     private void Start()
//     {
//         attackScript = FindObjectOfType<AttackScript>(); 
//     }

//     private void OnTriggerEnter(Collider other)
//     {
//         if (!hasStartedConversation && other.CompareTag("Player"))
//         {
//             hasStartedConversation = true; 

            
//             attackScript.HideWeapon(); 
//             Cursor.visible = true; 
//             Cursor.lockState = CursorLockMode.None; 

            
//             ConversationManager.Instance.StartConversation(myConversation);
//         }
//     }

//     private void OnTriggerExit(Collider other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             hasStartedConversation = false;

            
//             ConversationManager.Instance.EndConversation();

            
//             attackScript.ShowWeapon(); 
//             Cursor.visible = false;
//             Cursor.lockState = CursorLockMode.Locked; 
//         }
//     }
// }


using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;

public class RabbitTrigger : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;
    private bool hasStartedConversation = false;
    private AttackScript attackScript;

    private void Start()
    {
        attackScript = FindObjectOfType<AttackScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasStartedConversation && other.CompareTag("Player"))
        {
            hasStartedConversation = true;
            attackScript.HideWeapon();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            ConversationManager.Instance.StartConversation(myConversation);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasStartedConversation = false;
            ConversationManager.Instance.EndConversation(); 
            attackScript.ShowWeapon();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}