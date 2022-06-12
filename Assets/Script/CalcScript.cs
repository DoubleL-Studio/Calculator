
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class CalcScript : MonoBehaviour
{
    [SerializeField] private Text MathText;
    [SerializeField] private Text ResultText;
    [SerializeField] private string Calc;
    private string x;

    private void Start()
    {
        MathText.text = Calc;
        ResultText.text = x;
    } 
	private void Update()
    {
        if(x.Length > 10)
			ResultText.text = "Error";
    }
	
	
    public void AddElement()
    {
            MathText.text += Calc;    
    }

    public void GetResult()
    {
           
        DataTable dt = new DataTable();
        x = (dt.Compute(MathText.text, "")).ToString();		
        ResultText.text = x;
    }

    public void RestartCalc()
    {
        MathText.text = "";
        ResultText.text = "";
        
    }
    
    
}
