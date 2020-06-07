namespace CalculatorFigure
{
    partial class MyForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void IntializeComponent()
        {

        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.circleGroupBox = new System.Windows.Forms.GroupBox();
            this.circleCircuitCheckBox = new System.Windows.Forms.CheckBox();
            this.circleRadiusLabel = new System.Windows.Forms.Label();
            this.circleRadiusTextBox = new System.Windows.Forms.TextBox();
            this.circleAreaCheckBox = new System.Windows.Forms.CheckBox();
            this.cylinderGroupBox = new System.Windows.Forms.GroupBox();
            this.cylinderVolumeCheckBox = new System.Windows.Forms.CheckBox();
            this.cylinderHeightTextBox = new System.Windows.Forms.TextBox();
            this.cylinderRadiusTextBox = new System.Windows.Forms.TextBox();
            this.cylinderHeightLabel = new System.Windows.Forms.Label();
            this.cylinderRadiusLabel = new System.Windows.Forms.Label();
            this.cylinderAreaCheckBox = new System.Windows.Forms.CheckBox();
            this.squareGroupBox = new System.Windows.Forms.GroupBox();
            this.squareCircuitCheckBox = new System.Windows.Forms.CheckBox();
            this.squareSideLabel = new System.Windows.Forms.Label();
            this.squareSideTextBox = new System.Windows.Forms.TextBox();
            this.squareAreaCheckBox = new System.Windows.Forms.CheckBox();
            this.cubeGroupBox = new System.Windows.Forms.GroupBox();
            this.cubeVolumeCheckBox = new System.Windows.Forms.CheckBox();
            this.cubeSideLabel = new System.Windows.Forms.Label();
            this.cubeSideTextBox = new System.Windows.Forms.TextBox();
            this.cubeAreaCheckBox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.circleGroupBox.SuspendLayout();
            this.cylinderGroupBox.SuspendLayout();
            this.squareGroupBox.SuspendLayout();
            this.cubeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // circleGroupBox
            // 
            this.circleGroupBox.Controls.Add(this.circleCircuitCheckBox);
            this.circleGroupBox.Controls.Add(this.circleRadiusLabel);
            this.circleGroupBox.Controls.Add(this.circleRadiusTextBox);
            this.circleGroupBox.Controls.Add(this.circleAreaCheckBox);
            this.circleGroupBox.Location = new System.Drawing.Point(39, 50);
            this.circleGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleGroupBox.Name = "circleGroupBox";
            this.circleGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleGroupBox.Size = new System.Drawing.Size(229, 284);
            this.circleGroupBox.TabIndex = 12;
            this.circleGroupBox.TabStop = false;
            this.circleGroupBox.Text = "CIRCLE";
            // 
            // circleCircuitCheckBox
            // 
            this.circleCircuitCheckBox.AutoSize = true;
            this.circleCircuitCheckBox.Location = new System.Drawing.Point(123, 57);
            this.circleCircuitCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleCircuitCheckBox.Name = "circleCircuitCheckBox";
            this.circleCircuitCheckBox.Size = new System.Drawing.Size(70, 23);
            this.circleCircuitCheckBox.TabIndex = 7;
            this.circleCircuitCheckBox.Text = "Circuit";
            this.circleCircuitCheckBox.UseVisualStyleBackColor = true;
            this.circleCircuitCheckBox.CheckedChanged += new System.EventHandler(this.circleCircuitCheckBox_CheckedChanged);
            // 
            // circleRadiusLabel
            // 
            this.circleRadiusLabel.AutoSize = true;
            this.circleRadiusLabel.Location = new System.Drawing.Point(79, 145);
            this.circleRadiusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.circleRadiusLabel.Name = "circleRadiusLabel";
            this.circleRadiusLabel.Size = new System.Drawing.Size(47, 19);
            this.circleRadiusLabel.TabIndex = 6;
            this.circleRadiusLabel.Text = "radius";
            // 
            // circleRadiusTextBox
            // 
            this.circleRadiusTextBox.Enabled = false;
            this.circleRadiusTextBox.Location = new System.Drawing.Point(47, 172);
            this.circleRadiusTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleRadiusTextBox.Name = "circleRadiusTextBox";
            this.circleRadiusTextBox.Size = new System.Drawing.Size(132, 26);
            this.circleRadiusTextBox.TabIndex = 5;
            this.circleRadiusTextBox.TextChanged += new System.EventHandler(this.circleRadiusTextBox_TextChanged);
            // 
            // circleAreaCheckBox
            // 
            this.circleAreaCheckBox.AutoSize = true;
            this.circleAreaCheckBox.Location = new System.Drawing.Point(28, 57);
            this.circleAreaCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleAreaCheckBox.Name = "circleAreaCheckBox";
            this.circleAreaCheckBox.Size = new System.Drawing.Size(56, 23);
            this.circleAreaCheckBox.TabIndex = 0;
            this.circleAreaCheckBox.Text = "Area";
            this.circleAreaCheckBox.UseVisualStyleBackColor = true;
            this.circleAreaCheckBox.CheckedChanged += new System.EventHandler(this.circleAreaCheckBox_CheckedChanged);
            // 
            // cylinderGroupBox
            // 
            this.cylinderGroupBox.Controls.Add(this.cylinderVolumeCheckBox);
            this.cylinderGroupBox.Controls.Add(this.cylinderHeightTextBox);
            this.cylinderGroupBox.Controls.Add(this.cylinderRadiusTextBox);
            this.cylinderGroupBox.Controls.Add(this.cylinderHeightLabel);
            this.cylinderGroupBox.Controls.Add(this.cylinderRadiusLabel);
            this.cylinderGroupBox.Controls.Add(this.cylinderAreaCheckBox);
            this.cylinderGroupBox.Location = new System.Drawing.Point(312, 50);
            this.cylinderGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cylinderGroupBox.Name = "cylinderGroupBox";
            this.cylinderGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cylinderGroupBox.Size = new System.Drawing.Size(229, 284);
            this.cylinderGroupBox.TabIndex = 13;
            this.cylinderGroupBox.TabStop = false;
            this.cylinderGroupBox.Text = "CYLINDER";
            // 
            // cylinderVolumeCheckBox
            // 
            this.cylinderVolumeCheckBox.AutoSize = true;
            this.cylinderVolumeCheckBox.Location = new System.Drawing.Point(120, 57);
            this.cylinderVolumeCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cylinderVolumeCheckBox.Name = "cylinderVolumeCheckBox";
            this.cylinderVolumeCheckBox.Size = new System.Drawing.Size(75, 23);
            this.cylinderVolumeCheckBox.TabIndex = 12;
            this.cylinderVolumeCheckBox.Text = "Volume";
            this.cylinderVolumeCheckBox.UseVisualStyleBackColor = true;
            this.cylinderVolumeCheckBox.CheckedChanged += new System.EventHandler(this.cylinderVolumeCheckBox_CheckedChanged);
            // 
            // cylinderHeightTextBox
            // 
            this.cylinderHeightTextBox.Enabled = false;
            this.cylinderHeightTextBox.Location = new System.Drawing.Point(55, 232);
            this.cylinderHeightTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cylinderHeightTextBox.Name = "cylinderHeightTextBox";
            this.cylinderHeightTextBox.Size = new System.Drawing.Size(132, 26);
            this.cylinderHeightTextBox.TabIndex = 10;
            this.cylinderHeightTextBox.TextChanged += new System.EventHandler(this.cylinderHeightTextBox_TextChanged);
            // 
            // cylinderRadiusTextBox
            // 
            this.cylinderRadiusTextBox.Enabled = false;
            this.cylinderRadiusTextBox.Location = new System.Drawing.Point(55, 145);
            this.cylinderRadiusTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cylinderRadiusTextBox.Name = "cylinderRadiusTextBox";
            this.cylinderRadiusTextBox.Size = new System.Drawing.Size(132, 26);
            this.cylinderRadiusTextBox.TabIndex = 9;
            this.cylinderRadiusTextBox.TextChanged += new System.EventHandler(this.cylinderRadiusTextBox_TextChanged);
            // 
            // cylinderHeightLabel
            // 
            this.cylinderHeightLabel.AutoSize = true;
            this.cylinderHeightLabel.Location = new System.Drawing.Point(96, 209);
            this.cylinderHeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cylinderHeightLabel.Name = "cylinderHeightLabel";
            this.cylinderHeightLabel.Size = new System.Drawing.Size(49, 19);
            this.cylinderHeightLabel.TabIndex = 8;
            this.cylinderHeightLabel.Text = "height";
            // 
            // cylinderRadiusLabel
            // 
            this.cylinderRadiusLabel.AutoSize = true;
            this.cylinderRadiusLabel.Location = new System.Drawing.Point(96, 121);
            this.cylinderRadiusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cylinderRadiusLabel.Name = "cylinderRadiusLabel";
            this.cylinderRadiusLabel.Size = new System.Drawing.Size(47, 19);
            this.cylinderRadiusLabel.TabIndex = 7;
            this.cylinderRadiusLabel.Text = "radius";
            // 
            // cylinderAreaCheckBox
            // 
            this.cylinderAreaCheckBox.AutoSize = true;
            this.cylinderAreaCheckBox.Location = new System.Drawing.Point(25, 57);
            this.cylinderAreaCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cylinderAreaCheckBox.Name = "cylinderAreaCheckBox";
            this.cylinderAreaCheckBox.Size = new System.Drawing.Size(56, 23);
            this.cylinderAreaCheckBox.TabIndex = 11;
            this.cylinderAreaCheckBox.Text = "Area";
            this.cylinderAreaCheckBox.UseVisualStyleBackColor = true;
            this.cylinderAreaCheckBox.CheckedChanged += new System.EventHandler(this.cylinderAreaCheckBox_CheckedChanged);
            // 
            // squareGroupBox
            // 
            this.squareGroupBox.Controls.Add(this.squareCircuitCheckBox);
            this.squareGroupBox.Controls.Add(this.squareSideLabel);
            this.squareGroupBox.Controls.Add(this.squareSideTextBox);
            this.squareGroupBox.Controls.Add(this.squareAreaCheckBox);
            this.squareGroupBox.Location = new System.Drawing.Point(609, 50);
            this.squareGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.squareGroupBox.Name = "squareGroupBox";
            this.squareGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.squareGroupBox.Size = new System.Drawing.Size(229, 284);
            this.squareGroupBox.TabIndex = 13;
            this.squareGroupBox.TabStop = false;
            this.squareGroupBox.Text = "SQUARE";
            // 
            // squareCircuitCheckBox
            // 
            this.squareCircuitCheckBox.AutoSize = true;
            this.squareCircuitCheckBox.Location = new System.Drawing.Point(132, 57);
            this.squareCircuitCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.squareCircuitCheckBox.Name = "squareCircuitCheckBox";
            this.squareCircuitCheckBox.Size = new System.Drawing.Size(70, 23);
            this.squareCircuitCheckBox.TabIndex = 7;
            this.squareCircuitCheckBox.Text = "Circuit";
            this.squareCircuitCheckBox.UseVisualStyleBackColor = true;
            this.squareCircuitCheckBox.CheckedChanged += new System.EventHandler(this.squareCircuitCheckBox_CheckedChanged);
            // 
            // squareSideLabel
            // 
            this.squareSideLabel.AutoSize = true;
            this.squareSideLabel.Location = new System.Drawing.Point(94, 149);
            this.squareSideLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.squareSideLabel.Name = "squareSideLabel";
            this.squareSideLabel.Size = new System.Drawing.Size(34, 19);
            this.squareSideLabel.TabIndex = 6;
            this.squareSideLabel.Text = "side";
            // 
            // squareSideTextBox
            // 
            this.squareSideTextBox.Enabled = false;
            this.squareSideTextBox.Location = new System.Drawing.Point(47, 172);
            this.squareSideTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.squareSideTextBox.Name = "squareSideTextBox";
            this.squareSideTextBox.Size = new System.Drawing.Size(132, 26);
            this.squareSideTextBox.TabIndex = 5;
            this.squareSideTextBox.TextChanged += new System.EventHandler(this.squarSideTextBox_TextChanged);
            // 
            // squareAreaCheckBox
            // 
            this.squareAreaCheckBox.AutoSize = true;
            this.squareAreaCheckBox.Location = new System.Drawing.Point(35, 57);
            this.squareAreaCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.squareAreaCheckBox.Name = "squareAreaCheckBox";
            this.squareAreaCheckBox.Size = new System.Drawing.Size(56, 23);
            this.squareAreaCheckBox.TabIndex = 0;
            this.squareAreaCheckBox.Text = "Area";
            this.squareAreaCheckBox.UseVisualStyleBackColor = true;
            this.squareAreaCheckBox.CheckedChanged += new System.EventHandler(this.squareAreaCheckBox_CheckedChanged);
            // 
            // cubeGroupBox
            // 
            this.cubeGroupBox.Controls.Add(this.cubeVolumeCheckBox);
            this.cubeGroupBox.Controls.Add(this.cubeSideLabel);
            this.cubeGroupBox.Controls.Add(this.cubeSideTextBox);
            this.cubeGroupBox.Controls.Add(this.cubeAreaCheckBox);
            this.cubeGroupBox.Location = new System.Drawing.Point(909, 50);
            this.cubeGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cubeGroupBox.Name = "cubeGroupBox";
            this.cubeGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cubeGroupBox.Size = new System.Drawing.Size(229, 284);
            this.cubeGroupBox.TabIndex = 13;
            this.cubeGroupBox.TabStop = false;
            this.cubeGroupBox.Text = "CUBE";
            // 
            // cubeVolumeCheckBox
            // 
            this.cubeVolumeCheckBox.AutoSize = true;
            this.cubeVolumeCheckBox.Location = new System.Drawing.Point(120, 57);
            this.cubeVolumeCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cubeVolumeCheckBox.Name = "cubeVolumeCheckBox";
            this.cubeVolumeCheckBox.Size = new System.Drawing.Size(75, 23);
            this.cubeVolumeCheckBox.TabIndex = 8;
            this.cubeVolumeCheckBox.Text = "Volume";
            this.cubeVolumeCheckBox.UseVisualStyleBackColor = true;
            this.cubeVolumeCheckBox.CheckedChanged += new System.EventHandler(this.cubeVolumeCheckBox_CheckedChanged);
            // 
            // cubeSideLabel
            // 
            this.cubeSideLabel.AutoSize = true;
            this.cubeSideLabel.Location = new System.Drawing.Point(102, 149);
            this.cubeSideLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cubeSideLabel.Name = "cubeSideLabel";
            this.cubeSideLabel.Size = new System.Drawing.Size(34, 19);
            this.cubeSideLabel.TabIndex = 7;
            this.cubeSideLabel.Text = "side";
            // 
            // cubeSideTextBox
            // 
            this.cubeSideTextBox.Enabled = false;
            this.cubeSideTextBox.Location = new System.Drawing.Point(60, 172);
            this.cubeSideTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cubeSideTextBox.Name = "cubeSideTextBox";
            this.cubeSideTextBox.Size = new System.Drawing.Size(132, 26);
            this.cubeSideTextBox.TabIndex = 7;
            this.cubeSideTextBox.TextChanged += new System.EventHandler(this.cubeSideTextBox_TextChanged);
            // 
            // cubeAreaCheckBox
            // 
            this.cubeAreaCheckBox.AutoSize = true;
            this.cubeAreaCheckBox.Location = new System.Drawing.Point(33, 57);
            this.cubeAreaCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cubeAreaCheckBox.Name = "cubeAreaCheckBox";
            this.cubeAreaCheckBox.Size = new System.Drawing.Size(56, 23);
            this.cubeAreaCheckBox.TabIndex = 3;
            this.cubeAreaCheckBox.Text = "Area";
            this.cubeAreaCheckBox.UseVisualStyleBackColor = true;
            this.cubeAreaCheckBox.CheckedChanged += new System.EventHandler(this.cubeAreaCheckBox_CheckedChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.Enabled = false;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.calculateButton.FlatAppearance.BorderSize = 10;
            this.calculateButton.Font = new System.Drawing.Font("Yu Gothic UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.calculateButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.calculateButton.Location = new System.Drawing.Point(489, 360);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(227, 92);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Crimson;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resetButton.FlatAppearance.BorderSize = 10;
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetButton.Location = new System.Drawing.Point(880, 490);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 34);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Reset";
            this.resetButton.UseMnemonic = false;
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.resultText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.resultText.Location = new System.Drawing.Point(215, 475);
            this.resultText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(777, 364);
            this.resultText.TabIndex = 16;
            this.resultText.Text = "";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1180, 857);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.squareGroupBox);
            this.Controls.Add(this.cylinderGroupBox);
            this.Controls.Add(this.circleGroupBox);
            this.Controls.Add(this.cubeGroupBox);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MyForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.circleGroupBox.ResumeLayout(false);
            this.circleGroupBox.PerformLayout();
            this.cylinderGroupBox.ResumeLayout(false);
            this.cylinderGroupBox.PerformLayout();
            this.squareGroupBox.ResumeLayout(false);
            this.squareGroupBox.PerformLayout();
            this.cubeGroupBox.ResumeLayout(false);
            this.cubeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox circleAreaCheckBox;
        private System.Windows.Forms.CheckBox cubeAreaCheckBox;
        private System.Windows.Forms.TextBox circleRadiusTextBox;
        private System.Windows.Forms.TextBox cubeSideTextBox;
        private System.Windows.Forms.GroupBox circleGroupBox;
        private System.Windows.Forms.Label circleRadiusLabel;
        private System.Windows.Forms.GroupBox cubeGroupBox;
        private System.Windows.Forms.GroupBox squareGroupBox;
        private System.Windows.Forms.TextBox squareSideTextBox;
        private System.Windows.Forms.CheckBox squareAreaCheckBox;
        private System.Windows.Forms.GroupBox cylinderGroupBox;
        private System.Windows.Forms.Label cylinderHeightLabel;
        private System.Windows.Forms.Label cylinderRadiusLabel;
        private System.Windows.Forms.Label cubeSideLabel;
        private System.Windows.Forms.Label squareSideLabel;
        private System.Windows.Forms.TextBox cylinderHeightTextBox;
        private System.Windows.Forms.TextBox cylinderRadiusTextBox;
        private System.Windows.Forms.CheckBox cylinderAreaCheckBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.CheckBox circleCircuitCheckBox;
        private System.Windows.Forms.CheckBox cylinderVolumeCheckBox;
        private System.Windows.Forms.CheckBox squareCircuitCheckBox;
        private System.Windows.Forms.CheckBox cubeVolumeCheckBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.RichTextBox resultText;
    }
}

