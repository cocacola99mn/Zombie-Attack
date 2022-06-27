using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverButton : MonoBehaviour,IPointerEnterHandler
{
    public RectTransform Button;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Button.GetComponent<Animation>().Play("UIAnim");
    }
}
