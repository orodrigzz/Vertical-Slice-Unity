using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenalCode : MonoBehaviour
{
    public GameObject UI;

    private void OnMouseDown()
    {
        UI.SetActive(true);
    }

    void Update()
    {
        if (UI.activeInHierarchy)
        {
            if (Input.GetMouseButtonDown(1))
            {
                UI.SetActive(false);
            }
        }
    }
}
