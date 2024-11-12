using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    //GET Accessor (Read)
    //SET Accessor (Write)
    //Property Values - Encapsulated variables

    [SerializeField]
    public Button ResumeButton { get; set; }

    [SerializeField]    
    public Button RestartButton { get; set; }

    [SerializeField]
    public TextMeshProUGUI SolvedText { get; set; }

}
