using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace wepie.libs.GameFramework.Editor
{
public class ProfileTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TestCase1();
    }

    void TestCase1()
    {
        int t = 20000000;
        Debug.Log("=====");
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        sw.Start();
        for (int i = 0; i < t; i++)
        {
            int m = 8;
            m = m << 15;
            //Debug.Log(m);
            m = m >> 15;
            //Debug.Log(m);
        }
        Debug.Log("test tims is :" + sw.ElapsedMilliseconds);
        sw.Restart();
        for (int i = 0; i < t; i++)
        {
            int m = 8;
            m = m * 10000;
            //Debug.Log(m);
            m = m / 10000;
            //Debug.Log(m);
        }

        Debug.Log("test2 tims is :" + sw.ElapsedMilliseconds);
    }
}
}
