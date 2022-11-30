using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseSelection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private Button button;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (button != null)
        {
            button.Select();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //button
    }
}
