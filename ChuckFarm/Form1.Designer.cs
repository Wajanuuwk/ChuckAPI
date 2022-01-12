namespace ChuckFarm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GetJokeBtn = new System.Windows.Forms.Button();
            this.jokeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // GetJokeBtn
            // 
            this.GetJokeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GetJokeBtn.BackgroundImage")));
            this.GetJokeBtn.Location = new System.Drawing.Point(37, 33);
            this.GetJokeBtn.Name = "GetJokeBtn";
            this.GetJokeBtn.Size = new System.Drawing.Size(80, 31);
            this.GetJokeBtn.TabIndex = 0;
            this.GetJokeBtn.Text = "Get Joke";
            this.GetJokeBtn.UseVisualStyleBackColor = true;
            this.GetJokeBtn.Click += new System.EventHandler(this.GetJokeBtn_Click);
            // 
            // jokeBox
            // 
            this.jokeBox.Location = new System.Drawing.Point(12, 82);
            this.jokeBox.Name = "jokeBox";
            this.jokeBox.Size = new System.Drawing.Size(181, 178);
            this.jokeBox.TabIndex = 1;
            this.jokeBox.Text = "Get a joke. I dare you!";
            this.jokeBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(427, 272);
            this.Controls.Add(this.jokeBox);
            this.Controls.Add(this.GetJokeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetJokeBtn;
        private System.Windows.Forms.RichTextBox jokeBox;
    }
}

