using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseTutorialDialog : MonoBehaviour
{
    public GameObject dialogBox;
    
    
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(CloseDialogBox);
    }

    void CloseDialogBox()
    {
        Destroy(dialogBox);
    }
}
