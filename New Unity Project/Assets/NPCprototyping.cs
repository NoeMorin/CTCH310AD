using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCprototyping : MonoBehaviour
{

    public int intel = 5;
    public bool hitonhead = true;
    public bool readbook = true;

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
                if (hitonhead)
                {
                    intel = 3;
                    Greet();
                }
                if (readbook)
                {
                    intel = 5;
                    Greet();
                }
                break;

            case 3:
                print("What you want?");
                if (hitonhead)
                {
                    intel = 2;
                    Greet();
                }
                if (readbook)
                {
                    intel = 5;
                    Greet();
                }
                break;

            case 2:
                print("Ugh... Ugh... Hungry...");
                if (hitonhead)
                {
                    intel = 1;
                    Greet();
                }
                if (readbook)
                {
                    intel = 5;
                    Greet();
                }
                break;

            case 1:
                print("Grrrrrr...");
                if (hitonhead)
                {
                    intel = default;
                    Greet();
                }
                if (readbook)
                {
                    intel = 5;
                    Greet();
                }
                break;

            default:
                print("...");
                break;
        }
        //add in hit on head to make dumber with spacebar; pressing r key will make the ogre read a book and get smarter
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
