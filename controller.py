import tkinter as tk

FILE = r"C:\Users\snekr\Files to save in SSD\Shelby Coders\command.txt"

def send(cmd):
    with open(FILE, "w") as f:
        f.write(cmd)

root = tk.Tk()
root.title("Control Panel")

tk.Button(root, text="Forward", command=lambda: send("forward")).pack()
tk.Button(root, text="Backward", command=lambda: send("backward")).pack()
tk.Button(root, text="Left", command=lambda: send("left")).pack()
tk.Button(root, text="Right", command=lambda: send("right")).pack()
tk.Button(root, text="Jump", command=lambda: send("jump")).pack()

root.mainloop()