using UnityEngine;
using StarterAssets;

public class PythonInputReader : MonoBehaviour
{
    public FileController fileController;
    public StarterAssetsInputs starterInputs;

    void Update()
    {
        if (fileController == null || starterInputs == null)
            return;

        string cmd = fileController.currentCommand;

        HandleCommand(cmd);
    }

    void HandleCommand(string cmd)
    {
        // Reset each frame (important for movement feel)
        starterInputs.move = Vector2.zero;
        starterInputs.jump = false;

        switch (cmd)
        {
            case "forward":
                starterInputs.MoveInput(Vector2.up);
                break;

            case "backward":
                starterInputs.MoveInput(Vector2.down);
                break;

            case "left":
                starterInputs.MoveInput(Vector2.left);
                break;

            case "right":
                starterInputs.MoveInput(Vector2.right);
                break;

            case "jump":
                starterInputs.JumpInput(true);
                Debug.Log("Jump triggered");
                break;

            default:
                // idle = no movement
                break;
        }
    }
}