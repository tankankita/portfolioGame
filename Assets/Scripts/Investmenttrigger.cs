using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Investmenttrigger : MonoBehaviour
{
    Dictionary<string, int> portfolioItems = new Dictionary<string, int>();
    string APPLE = "apple";
    string DODGE = "dodge";

    private void OnTriggerEnter(Collider collider)
    {
        string name = collider.name;

        string x = collider.tag;
        Debug.Log("trigger entered");
        PortfolioController.Instance.setText("Portfolio Details: \n _____________________ \n ");

        if (name.CompareTo(APPLE) == 0)
        {
            if(portfolioItems.ContainsKey(name))
            {
                portfolioItems.Remove(APPLE);
            }
            else
            {
               portfolioItems.Add(APPLE, 1);
            }
        }

        if (name.CompareTo(DODGE) == 0)
        {
            if (portfolioItems.ContainsKey(name))
            {
                portfolioItems.Remove(DODGE);
            }
            else
            {
                portfolioItems.Add(DODGE, 3);
            }
        }
        PortfolioController.Instance.updateText(portfolioItems);
    }
}
