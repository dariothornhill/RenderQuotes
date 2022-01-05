using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RenderQuote : MonoBehaviour
{
    public TextMeshProUGUI quoteText;
    // Start is called before the first frame update
    public void NewQuote()
    {
        QuoteCollection quotesResponse = APIHelper.FetchQuote();
        quoteText.text = quotesResponse.quotes[0].text;
    }
}
