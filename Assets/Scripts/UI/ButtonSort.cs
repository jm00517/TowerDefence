using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.UI;

public class ButtonSort : MonoBehaviour, IPointerDownHandler
{
    public Card5Panel card5Panel;

    public void Awake()
    {

    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        GlobalInstance instance = GlobalInstance.GetInstance();
        List<Card> hand = instance.GetUser().GetHand();
        
        hand = CardUtil.SortCardList(hand);
        instance.GetUser().UpdateHand(hand);
        
        
        // ? card5Panel Why null?
        //card5Panel.SetCardImages(hand);
    }
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


