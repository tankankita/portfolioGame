using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PortfolioController : MonoBehaviour
{
    public static PortfolioController Instance;
    public TextMeshProUGUI portfolioText;
    string text = "";

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    public void updateText(Dictionary<string,int> portfolio)
    {
        portfolioText.text = "";
        foreach (KeyValuePair<string, int> entry in portfolio)
        {
            text += entry.Key + " - " + entry.Value + "\n";
        }
        portfolioText.text = text + "\n_____________________________________ \n \n ";
    }

    public void setText(string newText)
    {
        text += newText;
        portfolioText.text = text +"...\n";
    }
}
