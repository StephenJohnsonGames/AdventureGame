using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    Queue<string> sentences;


	// Use this for initialization
	void Start () {

        sentences = new Queue<string>();

	}

    public void StartDialogue (Dialogue dialogue)
    {

        animator.SetBool("IsOpen", true);
        //informs the console who you are talking too
        //Debug.Log("Starting conversation with " + dialogue.name);

        nameText.text = dialogue.name;

        sentences.Clear();

        //loops through each sentence and adds it to the que
        foreach(string sentence in dialogue.sentences)
        {

            sentences.Enqueue(sentence);

        }

        DisplayNextSentence();

    }

    //checks whether the count of sentences is 0
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        //dialogueText.text = sentence;

        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));


    }

    //to print letter by letter
    IEnumerator TypeSentence (string sentence)
    {

        dialogueText.text = "";
        //what happens for each letter of the sentence 
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;

        }

    }


    void EndDialogue()
    {

        Debug.Log("end of convo");
        animator.SetBool("IsOpen", false);
    }

}
