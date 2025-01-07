namespace RedBadgerForms
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            maxYCoordinateTextBox = new TextBox();
            XPromptTextBox = new TextBox();
            button1 = new Button();
            YPromptTextBox = new TextBox();
            maxXCoordinateTextBox = new TextBox();
            RobotXCoordinateTextBox = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            RobotYCoordinateTextBox = new TextBox();
            comamndForRobotPrompt = new TextBox();
            sendCommandTextBox = new TextBox();
            button2 = new Button();
            textBox5 = new TextBox();
            RobotOrientationTextBox = new TextBox();
            button3 = new Button();
            FinalOrientationTextBox = new TextBox();
            FinalCoordinatesTextBox = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // maxYCoordinateTextBox
            // 
            resources.ApplyResources(maxYCoordinateTextBox, "maxYCoordinateTextBox");
            maxYCoordinateTextBox.Name = "maxYCoordinateTextBox";
            // 
            // XPromptTextBox
            // 
            XPromptTextBox.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(XPromptTextBox, "XPromptTextBox");
            XPromptTextBox.Name = "XPromptTextBox";
            XPromptTextBox.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GenerateGridButton_Click;
            // 
            // YPromptTextBox
            // 
            YPromptTextBox.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(YPromptTextBox, "YPromptTextBox");
            YPromptTextBox.Name = "YPromptTextBox";
            YPromptTextBox.ReadOnly = true;
            // 
            // maxXCoordinateTextBox
            // 
            resources.ApplyResources(maxXCoordinateTextBox, "maxXCoordinateTextBox");
            maxXCoordinateTextBox.Name = "maxXCoordinateTextBox";
            // 
            // RobotXCoordinateTextBox
            // 
            resources.ApplyResources(RobotXCoordinateTextBox, "RobotXCoordinateTextBox");
            RobotXCoordinateTextBox.Name = "RobotXCoordinateTextBox";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            // 
            // RobotYCoordinateTextBox
            // 
            resources.ApplyResources(RobotYCoordinateTextBox, "RobotYCoordinateTextBox");
            RobotYCoordinateTextBox.Name = "RobotYCoordinateTextBox";
            // 
            // comamndForRobotPrompt
            // 
            comamndForRobotPrompt.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(comamndForRobotPrompt, "comamndForRobotPrompt");
            comamndForRobotPrompt.Name = "comamndForRobotPrompt";
            comamndForRobotPrompt.ReadOnly = true;
            // 
            // sendCommandTextBox
            // 
            resources.ApplyResources(sendCommandTextBox, "sendCommandTextBox");
            sendCommandTextBox.Name = "sendCommandTextBox";
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += GenerateRobotButton_Click;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBox5, "textBox5");
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            // 
            // RobotOrientationTextBox
            // 
            resources.ApplyResources(RobotOrientationTextBox, "RobotOrientationTextBox");
            RobotOrientationTextBox.Name = "RobotOrientationTextBox";
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += SendCommandButton_Click;
            // 
            // FinalOrientationTextBox
            // 
            resources.ApplyResources(FinalOrientationTextBox, "FinalOrientationTextBox");
            FinalOrientationTextBox.Name = "FinalOrientationTextBox";
            // 
            // FinalCoordinatesTextBox
            // 
            resources.ApplyResources(FinalCoordinatesTextBox, "FinalCoordinatesTextBox");
            FinalCoordinatesTextBox.Name = "FinalCoordinatesTextBox";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBox4, "textBox4");
            textBox4.Name = "textBox4";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FinalOrientationTextBox);
            Controls.Add(FinalCoordinatesTextBox);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(RobotOrientationTextBox);
            Controls.Add(button2);
            Controls.Add(comamndForRobotPrompt);
            Controls.Add(sendCommandTextBox);
            Controls.Add(textBox1);
            Controls.Add(RobotYCoordinateTextBox);
            Controls.Add(textBox2);
            Controls.Add(RobotXCoordinateTextBox);
            Controls.Add(maxXCoordinateTextBox);
            Controls.Add(YPromptTextBox);
            Controls.Add(button1);
            Controls.Add(XPromptTextBox);
            Controls.Add(maxYCoordinateTextBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Load += Window_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox maxYCoordinateTextBox;
        private TextBox XPromptTextBox;
        private Button button1;
        private TextBox YPromptTextBox;
        private TextBox maxXCoordinateTextBox;
        private TextBox RobotXCoordinateTextBox;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox RobotYCoordinateTextBox;
        private TextBox comamndForRobotPrompt;
        private TextBox sendCommandTextBox;
        private Button button2;
        private TextBox textBox5;
        private TextBox RobotOrientationTextBox;
        private Button button3;
        private TextBox FinalOrientationTextBox;
        private TextBox FinalCoordinatesTextBox;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
