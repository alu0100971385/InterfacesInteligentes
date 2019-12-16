using System;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.Speech;


public class KeywordScript : MonoBehaviour
{
    [SerializeField]
    private string[] m_Keywords;

    private KeywordRecognizer m_Recognizer;

    public void Start()
    {
        Debug.Log("Start");
        m_Keywords = new string[] {"hola","coche","hello"};
        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        m_Recognizer.Start();
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log(args.text);
    }
}