using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake ()
    {
        cardList.Add(new Card(0, "None", 0, 0, "None"));
        cardList.Add(new Card(0, "None", 0, 0, "None"));
        cardList.Add(new Card(0, "None", 0, 0, "None"));
        cardList.Add(new Card(0, "None", 0, 0, "None"));





    }
}
