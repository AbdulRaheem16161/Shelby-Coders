using UnityEngine;
using System.IO;

public class FileController : MonoBehaviour
{
    public string filePath = @"C:\Users\snekr\Files to save in SSD\Shelby Coders\command.txt";

    public string currentCommand = "";

    private string lastCommand = "";

    void Update()
    {
        ReadFile();
    }

    void ReadFile()
    {
        if (!File.Exists(filePath))
        {
            Debug.LogWarning("Command file not found!");
            return;
        }

        string command = File.ReadAllText(filePath).Trim().ToLower();

        if (command != lastCommand)
        {
            lastCommand = command;
            currentCommand = command;

            Debug.Log("Python Command: " + currentCommand);
        }
    }
}