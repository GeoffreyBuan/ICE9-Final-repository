namespace ICE9
{
    partial class SplashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label_Title = new Label();
            Splash_Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Label_Title
            // 
            Label_Title.Font = new Font("Calibri", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Title.Location = new Point(139, 40);
            Label_Title.Name = "Label_Title";
            Label_Title.Size = new Size(602, 94);
            Label_Title.TabIndex = 0;
            Label_Title.Text = "Character Generator";
            Label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Splash_Timer
            // 
            Splash_Timer.Enabled = true;
            Splash_Timer.Interval = 2000;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label_Title);
            Name = "SplashForm";
            Text = "SplashForm";
            ResumeLayout(false);
        }

        #endregion

        private Label Label_Title;
        private System.Windows.Forms.Timer Splash_Timer;
    }
}