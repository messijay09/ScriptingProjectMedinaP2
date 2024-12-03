using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass1 : MonoBehaviour
{
    public int apples;
    public int banana;


    private int stapler;
    private int sellotape;


    public void FruitMachine (int A, int B)
    {
        int answer;
        answer = A + B;
        Debug.Log("Fruit tstol: " + answer);
    }


    private void OfficeSort (int A, int B)
    {
        int answer;
        answer = A + B;
        Debug.Log("Office Supplies total: " + answer);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
