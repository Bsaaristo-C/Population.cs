namespace Saaristo_ASG5_Population
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
            this.buttonCalculatePopulation = new System.Windows.Forms.Button();
            this.textBoxOrganismInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPercentDailyIncrease = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumberOfDays = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.buttonDefaultValues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalculatePopulation
            // 
            this.buttonCalculatePopulation.Location = new System.Drawing.Point(401, 29);
            this.buttonCalculatePopulation.Name = "buttonCalculatePopulation";
            this.buttonCalculatePopulation.Size = new System.Drawing.Size(167, 31);
            this.buttonCalculatePopulation.TabIndex = 0;
            this.buttonCalculatePopulation.Text = "Calculate";
            this.buttonCalculatePopulation.UseVisualStyleBackColor = true;
            this.buttonCalculatePopulation.Click += new System.EventHandler(this.buttonCalculatePopulation_Click);
            // 
            // textBoxOrganismInput
            // 
            this.textBoxOrganismInput.Location = new System.Drawing.Point(223, 9);
            this.textBoxOrganismInput.Name = "textBoxOrganismInput";
            this.textBoxOrganismInput.Size = new System.Drawing.Size(142, 22);
            this.textBoxOrganismInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Starting number of organisms:";
            // 
            // textBoxPercentDailyIncrease
            // 
            this.textBoxPercentDailyIncrease.Location = new System.Drawing.Point(223, 38);
            this.textBoxPercentDailyIncrease.Name = "textBoxPercentDailyIncrease";
            this.textBoxPercentDailyIncrease.Size = new System.Drawing.Size(142, 22);
            this.textBoxPercentDailyIncrease.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Avg Daily Percentage Increase:";
            // 
            // textBoxNumberOfDays
            // 
            this.textBoxNumberOfDays.Location = new System.Drawing.Point(223, 71);
            this.textBoxNumberOfDays.Name = "textBoxNumberOfDays";
            this.textBoxNumberOfDays.Size = new System.Drawing.Size(142, 22);
            this.textBoxNumberOfDays.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number Of Days To Multiply:";
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(401, 68);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(167, 25);
            this.buttonClearAll.TabIndex = 7;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 16;
            this.listBoxOutput.Location = new System.Drawing.Point(31, 130);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(732, 308);
            this.listBoxOutput.TabIndex = 8;
            // 
            // buttonDefaultValues
            // 
            this.buttonDefaultValues.Location = new System.Drawing.Point(587, 29);
            this.buttonDefaultValues.Name = "buttonDefaultValues";
            this.buttonDefaultValues.Size = new System.Drawing.Size(167, 31);
            this.buttonDefaultValues.TabIndex = 9;
            this.buttonDefaultValues.Text = "Default Values";
            this.buttonDefaultValues.UseVisualStyleBackColor = true;
            this.buttonDefaultValues.Click += new System.EventHandler(this.buttonDefaultValues_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDefaultValues);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumberOfDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPercentDailyIncrease);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOrganismInput);
            this.Controls.Add(this.buttonCalculatePopulation);
            this.Name = "Form1";
            this.Text = "Saaristo Asg5 Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculatePopulation;
        private System.Windows.Forms.TextBox textBoxOrganismInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPercentDailyIncrease;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumberOfDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button buttonDefaultValues;
    }
}

