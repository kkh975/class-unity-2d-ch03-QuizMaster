using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Quesion", fileName = "New Quesion")]
public class QuestionSO : ScriptableObject 
{
    [TextArea(2,6)]
    [SerializeField] string question = "Enter new quesion text here";
}
