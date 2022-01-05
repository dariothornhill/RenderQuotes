using System.IO;
using System.Net;
using UnityEngine;


public class APIHelper
{
    // Start is called before the first frame update
    public static QuoteCollection FetchQuote()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://private-anon-f8d2d0814e-goquotes.apiary-proxy.com/api/v1/random?count=1");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader responseStream = new StreamReader(response.GetResponseStream());
        string json =  responseStream.ReadToEnd();
        Debug.Log(json);
        QuoteCollection quotes = JsonUtility.FromJson<QuoteCollection>(json);
        Debug.Log(quotes.quotes[0].text);
        return quotes;
    }

}
