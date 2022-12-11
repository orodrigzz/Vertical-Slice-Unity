using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject UI;
    public GameObject UI2;

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
        UI.SetActive(true);
        UI2.SetActive(false);
    }

}
