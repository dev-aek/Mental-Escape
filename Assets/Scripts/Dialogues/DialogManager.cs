using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DialogManager : MonoBehaviour
{
    private Queue<string> sentences;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI buttonText;
    public AudioSource clip;
     void Start()
    {
        sentences = new Queue<string>();
        clip = GetComponent<AudioSource>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        
    }
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        Debug.Log(dialogueText.text.Equals(null));
        if (!sentence.Equals(null))
        {
            foreach (char letter in sentence.ToCharArray())
            {
                dialogueText.text += letter;
                clip.Play();
                yield return new WaitForSeconds(0.07f);
            }
        }
    }
    void EndDialogue()
    {
        buttonText.text = "finish";
    }
}

