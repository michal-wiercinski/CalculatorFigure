using CalculatorFigure.Figure;
using CalculatorFigure.Service;
using CalculatorFigure.Service.interfaces;
using CalculatorFigure.Service.interfaces._3D;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculatorFigure
{
    public partial class MyForm : Form
    {
        private List<String> result = new List<String>();
        private int radius;
        private int height;
        private int side;
        private int counter = 1;
        
        public MyForm()
        {
            Text = "CalculatorFigure";
            Width = 320;
            Height = 200;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculateButton_Click(sender, e);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        { 
            calculateCircleArea();
            calculateCircleCircuit();
            calculateCylinderArea();
            calculateCylinderVolume();
            calculateSquareArea();
            calculateSquareCircuit();
            calculateCubeArea();
            calculateCubeVolume();
            resultText.Text = string.Join("\n", result.ToArray());
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            result.Clear();
            counter = 1;
            resultText.Text = "";
        }

        private void calculateCircleArea()
        {
            if (circleAreaCheckBox.Checked)
            {                
                if (int.TryParse(circleRadiusTextBox.Text.Trim(), out radius))
                {
                    Figure2DService<Circle> circleService = new CircleService();
                    double circleArea = circleService.calculateArea(radius);
                    String areaResult = String.Format("{0}. Circle area is: {1}    for radius: {2}", counter++, circleArea, radius);
                    Console.WriteLine(areaResult);
                    result.Add(areaResult);
                }
            }
        }
        private void calculateCircleCircuit()
        {

            if (circleCircuitCheckBox.Checked)
            {
                if (int.TryParse(circleRadiusTextBox.Text.Trim(), out radius))
                {
                    Figure2DService<Circle> circleService = new CircleService();
                    double circleCircuit = circleService.calculateCircuit(radius);
                    String circuitResult = String.Format("{0}. Circle circuit is: {1}    for radius: {2}", counter++, circleCircuit, radius);
                    Console.WriteLine(circuitResult);
                    result.Add(circuitResult);
                }
            }
        }
        private void calculateCylinderArea()
        {
            if (cylinderAreaCheckBox.Checked)
            {
                if (int.TryParse(cylinderRadiusTextBox.Text.Trim(), out radius) && int.TryParse(cylinderHeightTextBox.Text.Trim(), out height))
                {
                    Figure3DService<Cylinder> cylinderService = new CylinderService();
                    double cylinderArea = cylinderService.calculateArea(radius, height);
                    String areaResult = String.Format("{0}. Cylinder area is: {1}    for side: {2} and height: {3}", counter++, cylinderArea, radius, height);
                    Console.WriteLine(areaResult);
                    result.Add(areaResult);
                }
            }
        }

        private void calculateCylinderVolume()
        {
            if (cylinderVolumeCheckBox.Checked)
            {
                if (int.TryParse(cylinderRadiusTextBox.Text.Trim(), out radius) && int.TryParse(cylinderHeightTextBox.Text.Trim(), out height))
                {
                    Figure3DService<Cylinder> cylinderService = new CylinderService();
                    double cylinderVolume = cylinderService.calculateVolume(radius, height);
                    String volumeResult = String.Format("{0}. Cylinder volume is: {1}    for radius: {2} and height: {3}", counter++, cylinderVolume, radius, height);
                    Console.WriteLine(volumeResult);
                    result.Add(volumeResult);
                }
            }
        }
        private void calculateSquareArea()
        {
            if (squareAreaCheckBox.Checked)
            {
                if (int.TryParse(squareSideTextBox.Text.Trim(), out side))
                {
                    Figure2DService<Square> squareServie = new SquareService();
                    double squareArea = squareServie.calculateArea(side);
                    String areaResult = String.Format("{0}. Square area is: {1}    for side: {2}", counter++, squareArea, side);
                    Console.WriteLine(areaResult);
                    result.Add(areaResult);
                }
            }
        }
        private void calculateSquareCircuit()
        {
            if (squareCircuitCheckBox.Checked)
            {
                if (int.TryParse(squareSideTextBox.Text.Trim(), out side))
                {
                    Figure2DService<Square> squareServie = new SquareService();
                    double squareCircuit = squareServie.calculateCircuit(side);
                    String circuitResult = String.Format("{0}. Square circuit is: {1}    for side: {2}", counter++, squareCircuit, side);
                    Console.WriteLine(circuitResult);
                    result.Add(circuitResult);
                }
            }
        }
        private void calculateCubeArea()
        {
            if (cubeAreaCheckBox.Checked)
            {
                if (int.TryParse(cubeSideTextBox.Text.Trim(), out side))
                {
                    Figure3DService<Cube> cubeService = new CubeService();
                    double cubeArea = cubeService.calculateArea(side);
                    String areaResult = String.Format("{0}. Cube area is: {1}    for side: {2}", counter++, cubeArea, side);
                    Console.WriteLine(result);
                    result.Add(areaResult);
                }
            }
        }
        private void calculateCubeVolume()
        {
            if (cubeVolumeCheckBox.Checked)
            {
                if (int.TryParse(cubeSideTextBox.Text.Trim(), out side))
                {
                    Figure3DService<Cube> cubeService = new CubeService();
                    double cubeVolume = cubeService.calculateVolume(side);
                    String volumeResult = String.Format("Cube volume is: {0}    for side: {1}", counter++, cubeVolume, side);
                    Console.WriteLine(volumeResult);
                    result.Add(volumeResult);
                }
            }
        }
        private void squareAreaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            squareSideTextBox.Enabled = squareAreaCheckBox.Checked;
        }
        private void circleAreaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            circleRadiusTextBox.Enabled = circleAreaCheckBox.Checked;
        }
        private void cubeAreaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cubeSideTextBox.Enabled = cubeAreaCheckBox.Checked;
        }
        private void cylinderAreaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cylinderRadiusTextBox.Enabled = cylinderAreaCheckBox.Checked;
            cylinderHeightTextBox.Enabled = cylinderAreaCheckBox.Checked;
        }
        private void squareCircuitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            squareSideTextBox.Enabled = squareCircuitCheckBox.Checked;
        }
        private void cylinderVolumeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cylinderRadiusTextBox.Enabled = cylinderVolumeCheckBox.Checked;
            cylinderHeightTextBox.Enabled = cylinderVolumeCheckBox.Checked;
        }
        private void circleCircuitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            circleRadiusTextBox.Enabled = circleCircuitCheckBox.Checked;
        }

        private void cubeVolumeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cubeSideTextBox.Enabled = cubeVolumeCheckBox.Checked;
        }
        private void circleRadiusTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateButton.Enabled = circleRadiusTextBox.TextLength > 0;
        }
        private void cylinderRadiusTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateButton.Enabled = cylinderRadiusTextBox.TextLength > 0;
        }
        private void cylinderHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateButton.Enabled = cylinderHeightTextBox.TextLength > 0;
        }
        private void squarSideTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateButton.Enabled = squareSideTextBox.TextLength > 0;
        }
        private void cubeSideTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateButton.Enabled = cubeSideTextBox.TextLength > 0;
        }        
    }
}
