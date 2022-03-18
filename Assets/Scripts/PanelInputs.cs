using UnityEngine.UI;
using UnityEngine;
using System;

public class PanelInputs : MonoBehaviour
{
    [SerializeField] private Text speedInput;
    [SerializeField] private Text distanceInput;
    [SerializeField] private Text spawnInput;
    [SerializeField] private SpawnData spawnData;
    [SerializeField]private CubeData cubeData;
    public Action OnPressed;

    public void OnPressedButton()
    {
        cubeData.Speed = CheckNumbers(speedInput.text);
        spawnData.SpawnTime = CheckNumbers(spawnInput.text);
        cubeData.Distance = CheckNumbers(distanceInput.text);
        OnPressed?.Invoke();

    }


    private float CheckNumbers(string textValue)
    {
        char[] charArray = textValue.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            if (!Char.IsDigit(charArray[i]))
            {
                throw new Exception("Need numbers!");
            }
        }
        float result = float.Parse(textValue);
        return result;
    }

}
