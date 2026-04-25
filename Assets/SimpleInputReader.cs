using UnityEngine;

public class InputReader : MonoBehaviour
{
    public FileController fileController;
    public StarterAssets.StarterAssetsInputs starterInputs;

    void Update()
    {
        string cmd = fileController.currentCommand;

        // reset every frame (IMPORTANT)
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
                break;
        }
    }
}