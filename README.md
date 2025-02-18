🎯 Galil Motion Controller with VB.NET 🚀
💡 This project is designed to control the Galil Motion Controller using VB.NET.
⚡ Supports Jogging, Homing, Setting Speed, Enabling/Disabling Servo, and Reading Position

🎨 Features
✅ Connect and initialize the motion controller
✅ Jogging (Move forward/backward)
✅ Homing to the reference position
✅ Enable/Disable Servo
✅ Move to Position based on predefined values
✅ Read Position of each axis

📦 Installation
1️⃣ Install Galil API SDK
2️⃣ Connect your Galil Motion Controller to the network
3️⃣ Open the project in Visual Studio
4️⃣ Verify the IP address and parameter values

🛠 Usage
🔗 1. Connect to Controller
Lb_Status_Galil.Text = GalilController.Connect(txt_GalilIP.Text)
✅ Establish a connection with the Galil Motion Controller

⚙️ 2. Set Default Motion Parameters
GalilController.Setdefault(txt_speedA.Text, txt_AccA.Text, txt_DecA.Text, txt_smoothA.Text,
                           txt_speedB.Text, txt_AccB.Text, txt_DecB.Text, txt_smoothB.Text,
                           txt_speedC.Text, txt_AccC.Text, txt_DecC.Text, txt_smoothC.Text)
✅ Set Speed, Acceleration, Deceleration, and Smooth Factor

🎮 3. Jogging (Manual Movement)
🔼 Move Forward
GalilController.Jog_forward("A", txt_speed_jogA.Text)
🔽 Move Reverse

GalilController.Jog_reverse("A", txt_speed_jogA.Text)
🛑 Stop Jogging

GalilController.StopJog()
🏠 4. Homing
GalilController.Home("A")
✅ Automatically moves the axis to the home position

⚡ 5. Enable/Disable Servo
🔹 Enable Servo

GalilController.Enable("A")
🔸 Disable Servo

GalilController.Disable("A")
📍 6. Move to Specific Position
GalilController.GoToPosition("B", txt_B_P1.Text)
GalilController.GoToPosition("C", txt_C_P1.Text)
✅ Commands axes B & C to move to predefined positions

📊 7. Read Current Position
Lb_A_position.Text = "A=" & GalilController.GetPositions("A")
Lb_B_position.Text = "B=" & GalilController.GetPositions("B")
Lb_C_position.Text = "C=" & GalilController.GetPositions("C")
✅ Displays the real-time position of each axis

🛠 Troubleshooting
❌ Connection Error? → Check the IP Address
❌ Jog not working? → Make sure the Servo is enabled
❌ Need to Clear Errors? → Use the command

dmc.command("CN") ' Clears errors
📜 License
🔓 Open-source – feel free to modify and customize as needed

💻 Developed by: [Nitikorn T] 🛠
🔗 GitHub Repository: [https://github.com/Izonetoyou/Galil_B140.git]

🚀 Now ready to use! Try it out! 🎯
