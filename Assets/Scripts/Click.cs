using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject UI;

    private void OnMouseDown()
    {
        UI.SetActive(true);
    }

    private void OnMouseUp()
    {
        UI.SetActive(false);
    }

}
