using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoryBook
{
    public string mainText;
    public string option1Text;
    public string option2Text;
    public StoryBook option1Block;
    public StoryBook option2Block;

    public StoryBook(string mainText, string option1Text, string option2Text, StoryBook option1Block, StoryBook option2Block)
    {
        this.mainText = mainText;
        this.option1Text = option1Text;
        this.option2Text = option2Text;
        this.option1Block = option1Block;
        this.option2Block = option2Block;
    }
}
public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI mainText;
    [SerializeField] private Button option1;
    [SerializeField] private Button option2;
    private StoryBook currentBlock;
    static StoryBook block7 = new StoryBook("You quickly cover the passage back up and lie down, closing your eyes", "Uncover the passage and enter it", "Examine the cell door lock", null, null);
    static StoryBook block6 = new StoryBook("You squeeze through the narrow opening, just as the footsteps grow louder", "Continue towards the light", "Stop and listen for any sounds", null, null);
    static StoryBook block5 = new StoryBook("You redouble your efforts, working frantically on the lock", "Rush out and knock out the guard", "Slip out quietly and hide in the shadows", null, null);
    static StoryBook block4 = new StoryBook("You quickly hide the metal piece under your straw mattress and lie down, closing your eyes", "Retrieve the metal piece and continue working on the lock", "Investigate the walls for other hidden passages", block6, block7);
    static StoryBook block3 = new StoryBook("You begin to search the walls of your cell, feeling for any loose stones or hidden mechanisms", "Enter the hidden passage", "Cover the passage and pretend to be asleep", block6, block7);
    static StoryBook block2 = new StoryBook("You crawl over to the cell door and examine the lock closely", "Hide the metal piece and pretend to be asleep", "Continue working on the lock quickly", block4, block5);
    static StoryBook block1 = new StoryBook("You just woke up in a small, dark cell in an old castle", "Examine the lock on the cell door", "Search for a hidden passage", block2, block3);

    private void Start()
    {
        DisplayBlock(block1);
    }
    private void DisplayBlock(StoryBook block)
    {
        currentBlock = block;
        mainText.text = currentBlock.mainText;
        option1.GetComponentInChildren<TextMeshProUGUI>().text = currentBlock.option1Text;
        option2.GetComponentInChildren<TextMeshProUGUI>().text = currentBlock.option2Text;
    }

    public void Button1Clicked()
    {
        if (currentBlock.option1Block != null)
        {
            DisplayBlock(currentBlock.option1Block);
        }
    }

    public void Button2Clicked()
    {
        if (currentBlock.option2Block != null)
        {
            DisplayBlock(currentBlock.option2Block);
        }
    }
}
