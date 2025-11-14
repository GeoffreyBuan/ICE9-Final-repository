namespace ICE9
{
    partial class NextForm
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
            button_back = new Button();
            button_next = new Button();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_back.Location = new Point(128, 304);
            button_back.Name = "button_back";
            button_back.Size = new Size(170, 70);
            button_back.TabIndex = 0;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_next
            // 
            button_next.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_next.Location = new Point(588, 304);
            button_next.Name = "button_next";
            button_next.Size = new Size(170, 70);
            button_next.TabIndex = 0;
            button_next.Text = "Next";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // NextForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_next);
            Controls.Add(button_back);
            Name = "NextForm";
            Text = "NextForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button_back;
        private Button button_next;
    }
}