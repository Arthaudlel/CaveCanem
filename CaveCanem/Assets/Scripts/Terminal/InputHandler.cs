using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputHandler : MonoBehaviour
{
    //static int activeScene = MyComponentManager.ChallengeLevel;
    // Start is called before the first frame update

    public static string TextHandler(string str)
    {
        int activeScene = MyComponentManager.ChallengeLevel;
        Debug.Log("Terminal Active Scene : " + activeScene);
        if (str == "Quit" || str == "quit")
        {
            SceneManager.LoadScene(activeScene);
            return "";
        }
        if (activeScene == 2)
        {
            if (str.StartsWith("pass "))
            {
                if (str == "pass [PASS]Th4tW4s3asy!")
                {
                    MyComponentManager.Success = true;
                    return "Challenge 1: \n You Gess Right :)";
                } else
                {
                    return "Challenge 1: \n Wrong Password ! :(";
                }
            }
            else if (str == "ls")
            {
                return "Challenge 1: \n No File Found";
            }
            else
                return "Challenge 1: \n Unknow Command";
        }
        else if (activeScene == 3)
        {
            if (str.StartsWith("pass "))
            {
                if (str == "pass [PASS]N1c3Job!")
                {
                    MyComponentManager.Success = true;
                    return "Challenge 2: \n You Gess Right :)";
                }
                else
                {
                    return "Challenge 2: \n Wrong Password ! :(";
                }
            }
            else if (str == "ls") {
                return "Challenge 2: \n EncodedPassword.txt";
            }
            else if (str.StartsWith("show "))
            {
                if (str == "show EncodedPassword.txt")
                {
                    return "Challenge 2: \n 0x5b 0x50 0x41 0x53 0x53 0x5d 0x4e 0x31 0x63 0x33 0x4a 0x6f 0x62 0x21";
                } else
                {
                    return "Challenge 2: \n Unknow File.";
                }
            }
            else
                return "Challenge 2: \n Unknow Command";
        }
        else if (activeScene == 4)
        {
            if (str.StartsWith("pass "))
            {
                if (str == "pass [PASS]B1nary1sCool!")
                {
                    MyComponentManager.Success = true;
                    return "Challenge 3: \n You Gess Right :)";
                }
                else
                {
                    return "Challenge 3: \n Wrong Password ! :(";
                }
            }
            else if (str == "ls")
            {
                return "Challenge 3: \n EncodedPassword.txt";
            }
            else if (str.StartsWith("show "))
            {
                if (str == "show EncodedPassword.txt")
                {
                    return "Challenge 3: \n 01011011 01010000 01000001 01010011 01010011 01011101 01000010 00110001 01101110 01100001 01110010 01111001 00110001 01110011 01000011 01101111 01101111 01101100 00100001";
                }
                else
                {
                    return "Challenge 3: \n Unknow File.";
                }
            }
            else
                return "Challenge 2: \n Unknow Command";
        }
        return "";
    }
}
