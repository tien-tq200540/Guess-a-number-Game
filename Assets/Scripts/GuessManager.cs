using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessManager : TienMonoBehaviour
{
    [Header("Number")]
    [SerializeField] private int computerNumber;
    [SerializeField] private int guessNumber;

    [Header("Range")]
    [SerializeField] private int min = 0;
    [SerializeField] private int max = 10;

    [Header("Input/Output Field")]
    [SerializeField] InputField input;
    [SerializeField] Text output;
    [SerializeField] GameObject Restart_btn;

    protected override void LoadComponents()
    {
        base.LoadComponents();

        this.LoadInputField();
        this.LoadOutputText();
        this.LoadRestartBtn();
        this.UpdateComputerNumber();
    }

    protected virtual void LoadInputField()
    {
        if (this.input != null) return;
        this.input = GameObject.Find("InputField").GetComponent<InputField>();
        this.input.contentType = InputField.ContentType.IntegerNumber;
    }

    protected virtual void LoadOutputText()
    {
        if (this.output != null) return;
        this.output = GameObject.Find("Output").GetComponent<Text>();
        this.ResetOutput();
    }

    protected virtual void LoadRestartBtn()
    {
        if (this.Restart_btn != null) return;
        this.Restart_btn = GameObject.Find("Restart_btn");
        this.Restart_btn.SetActive(false);
    }

    public virtual void UpdateComputerNumber()
    {
        this.computerNumber = Random.Range(min, max + 1);
    }

    public virtual void UpdateGuessNumber()
    {
        this.guessNumber = int.Parse(this.input.text);
    }

    public virtual void CompareNumber()
    {
        if (this.guessNumber < this.computerNumber) this.output.text = "Low";
        else if (this.guessNumber > this.computerNumber) this.output.text = "High";
        else
        {
            this.output.text = "You guessed right!";
            this.Restart_btn.SetActive(true);
        }
    }

    public virtual void ResetOutput()
    {
        this.input.text = "";
        this.output.text = "";
    }

    public virtual void setMin(int min)
    {
        this.min = min;
    }

    public virtual void setMax(int max)
    {
        this.max = max;
    }
}
