using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCprototyping : MonoBehaviour
{

    public int intel = 5;
    public bool hitonhead = true;

    float test()
    {
        return 5.0f;
    }

    void Greet()
    {

        switch(intel)
        {
            case 5:
                print("Hello, good sir! do you like physics?");
                if (hitonhead)
                {
                    intel = 4;
                    Greet();
                }
                break;

            case 4:
                print("Ello guv!");
                break;

            case 3:
                print("What you want?");
                break;

            case 2:
                print("Ugh... Ugh... Hungry...");
                break;

            case 1:
                print("Grrrrrr...");
                break;

            default:
                print("...");
                break;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        Greet();
        float testNum = test();
        print(testNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
