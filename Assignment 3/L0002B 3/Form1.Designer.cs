
// Peter Panduro, 9201015592
// L0002B
// Uppgift 3

namespace L0002B_3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.givenNameTextBox = new System.Windows.Forms.TextBox();
            this.familyNameTextBox = new System.Windows.Forms.TextBox();
            this.pNrTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.givenNameLabel = new System.Windows.Forms.Label();
            this.familyNameLabel = new System.Windows.Forms.Label();
            this.pNrLabel = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.showNameLabel = new System.Windows.Forms.Label();
            this.showPNrLabel = new System.Windows.Forms.Label();
            this.showGenderLabel = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ange dina personuppgifter";
            // 
            // givenNameTextBox
            // 
            this.givenNameTextBox.Location = new System.Drawing.Point(164, 66);
            this.givenNameTextBox.Name = "givenNameTextBox";
            this.givenNameTextBox.Size = new System.Drawing.Size(230, 26);
            this.givenNameTextBox.TabIndex = 1;
            // 
            // familyNameTextBox
            // 
            this.familyNameTextBox.Location = new System.Drawing.Point(164, 109);
            this.familyNameTextBox.Name = "familyNameTextBox";
            this.familyNameTextBox.Size = new System.Drawing.Size(230, 26);
            this.familyNameTextBox.TabIndex = 2;
            // 
            // pNrTextBox
            // 
            this.pNrTextBox.Location = new System.Drawing.Point(164, 154);
            this.pNrTextBox.Name = "pNrTextBox";
            this.pNrTextBox.Size = new System.Drawing.Size(230, 26);
            this.pNrTextBox.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(40, 214);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(89, 33);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(135, 214);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 33);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // givenNameLabel
            // 
            this.givenNameLabel.AutoSize = true;
            this.givenNameLabel.Location = new System.Drawing.Point(36, 66);
            this.givenNameLabel.Name = "givenNameLabel";
            this.givenNameLabel.Size = new System.Drawing.Size(73, 20);
            this.givenNameLabel.TabIndex = 6;
            this.givenNameLabel.Text = "Förnamn";
            // 
            // familyNameLabel
            // 
            this.familyNameLabel.AutoSize = true;
            this.familyNameLabel.Location = new System.Drawing.Point(36, 112);
            this.familyNameLabel.Name = "familyNameLabel";
            this.familyNameLabel.Size = new System.Drawing.Size(84, 20);
            this.familyNameLabel.TabIndex = 7;
            this.familyNameLabel.Text = "Efternamn";
            // 
            // pNrLabel
            // 
            this.pNrLabel.AutoSize = true;
            this.pNrLabel.Location = new System.Drawing.Point(36, 157);
            this.pNrLabel.Name = "pNrLabel";
            this.pNrLabel.Size = new System.Drawing.Size(117, 20);
            this.pNrLabel.TabIndex = 8;
            this.pNrLabel.Text = "Personnummer";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel.Controls.Add(this.showGenderLabel);
            this.panel.Controls.Add(this.showPNrLabel);
            this.panel.Controls.Add(this.showNameLabel);
            this.panel.Location = new System.Drawing.Point(31, 273);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(363, 130);
            this.panel.TabIndex = 9;
            // 
            // showNameLabel
            // 
            this.showNameLabel.AutoSize = true;
            this.showNameLabel.Location = new System.Drawing.Point(22, 17);
            this.showNameLabel.Name = "showNameLabel";
            this.showNameLabel.Size = new System.Drawing.Size(0, 20);
            this.showNameLabel.TabIndex = 0;
            // 
            // showPNrLabel
            // 
            this.showPNrLabel.AutoSize = true;
            this.showPNrLabel.Location = new System.Drawing.Point(22, 52);
            this.showPNrLabel.Name = "showPNrLabel";
            this.showPNrLabel.Size = new System.Drawing.Size(0, 20);
            this.showPNrLabel.TabIndex = 1;
            // 
            // showGenderLabel
            // 
            this.showGenderLabel.AutoSize = true;
            this.showGenderLabel.Location = new System.Drawing.Point(22, 88);
            this.showGenderLabel.Name = "showGenderLabel";
            this.showGenderLabel.Size = new System.Drawing.Size(0, 20);
            this.showGenderLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 678);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pNrLabel);
            this.Controls.Add(this.familyNameLabel);
            this.Controls.Add(this.givenNameLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.pNrTextBox);
            this.Controls.Add(this.familyNameTextBox);
            this.Controls.Add(this.givenNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox givenNameTextBox;
        private System.Windows.Forms.TextBox familyNameTextBox;
        private System.Windows.Forms.TextBox pNrTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label givenNameLabel;
        private System.Windows.Forms.Label familyNameLabel;
        private System.Windows.Forms.Label pNrLabel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label showGenderLabel;
        private System.Windows.Forms.Label showPNrLabel;
        private System.Windows.Forms.Label showNameLabel;
    }
}

