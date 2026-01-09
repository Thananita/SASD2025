namespace Restaurant
{
    partial class WaiterForm
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
            textBox1 = new TextBox();
            Send = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 31);
            textBox1.TabIndex = 0;
            // 
            // Send
            // 
            Send.Location = new Point(566, 65);
            Send.Name = "Send";
            Send.Size = new Size(112, 34);
            Send.TabIndex = 1;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // WaiterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Send);
            Controls.Add(textBox1);
            Name = "WaiterForm";
            Text = "Waiter Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Send;
    }
}
