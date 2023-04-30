using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    [SerializeField] private GameObject baseView;
    [SerializeField] private List<GameObject> views = new List<GameObject>();

    public void Show(string viewName)
    {
        foreach (GameObject view in views)
        {
            view.SetActive(view.name == viewName);
        }
    }

    public void ShowBase()
    {
        Show(baseView.name);
    }

    public void HideAllViews()
    {
        foreach (GameObject view in views)
        {
            view.SetActive(false);
        }
    }
}
