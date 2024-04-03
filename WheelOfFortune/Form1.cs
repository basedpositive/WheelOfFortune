using System;
using System.Drawing;
using System.Windows.Forms;

namespace WheelOfFortune
{
    public partial class Form1 : Form
    {
        private Random random;
        private float currentRotationAngle;
        private float rotationTarget;
        private const float FullCircleDegrees = 360;

        private const float ColorSegmentDegrees = FullCircleDegrees / 10;

        private const float SpinDegreesStart1 = ColorSegmentDegrees * 0; // редкий // синий
        private const float SpinDegreesStart2 = ColorSegmentDegrees * 1 + 36; // эпический // фиолетовый
        private const float SpinDegreesStart3 = ColorSegmentDegrees * 2 + 36; // обычный // зеленый
        private const float SpinDegreesStart4 = ColorSegmentDegrees * 3; // легендарный // желтый

        private const float SpinDegreesStart5 = ColorSegmentDegrees * 4; // обычный // зеленый
        private const float SpinDegreesStart6 = ColorSegmentDegrees * 5; // обычный // зеленый
        private const float SpinDegreesStart7 = ColorSegmentDegrees * 6 + 36; // эпический // фиолетовый
        private const float SpinDegreesStart8 = ColorSegmentDegrees * 7; // легендарный // желтый
        private const float SpinDegreesStart9 = ColorSegmentDegrees * 8; // редкий // синий
        private const float SpinDegreesStart10 = ColorSegmentDegrees * 9; // обычный // зеленый

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            currentRotationAngle = 0;
            rotationTarget = 0;
        }

        private void rotationTimer_Tick(object sender, EventArgs e)
        {
            currentRotationAngle += 5; // Adjust the rotation speed
            if (currentRotationAngle >= rotationTarget)
            {
                rotationTimer.Stop();
                int degrees = random.Next(360); // Randomly choose a degree to stop
                                                //MessageBox.Show($"You landed on {GetColor(degrees)}!"); // Display the color
            }
            pictureBoxWheel.Invalidate();
        }

        private void pictureBoxWheel_Paint(object sender, PaintEventArgs e)
        {
            DrawWheelSectors(e.Graphics, currentRotationAngle);
        }

        private void DrawWheelSectors(Graphics g, float rotationAngle)
        {
            // Define colors and sectors
            Color[] colors = { Color.Yellow, Color.Blue, Color.Green, Color.Blue, Color.Purple, Color.Green, Color.Yellow, Color.Green, Color.Green, Color.Purple };
            int numSectors = colors.Length;

            // Calculate sector size
            float sectorAngle = 360f / numSectors;

            // Draw sectors with rotation
            for (int i = 0; i < numSectors; i++)
            {
                float startAngle = i * sectorAngle + rotationAngle;
                using (SolidBrush brush = new SolidBrush(colors[i]))
                {
                    g.FillPie(brush, pictureBoxWheel.ClientRectangle, startAngle, sectorAngle);
                }
            }
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            // Choose a rotation method based on probabilities
            int chance = 1; // Default chance

            currentRotationAngle = 0;

            int randomNumber = random.Next(1, 100);

            if (randomNumber >= 90) // 10% 90 to 100
            {
                chance = 1;
                //MessageBox.Show
            }
            else if (randomNumber >= 84) // 5% 84 to 89 
            {
                chance = 2;
                //MessageBox.Show
            }
            else if (randomNumber == 1) // 1% 
            {
                chance = 3;
                //MessageBox.Show
            }
            else
            {
                chance = 4; // Def
                //MessageBox.Show(" Def ");
            }

            // MessageBox.Show("Random number: " + randomNumber.ToString());

            // Start rotation based on the chosen chance
            switch (chance)
            {
                case 1:
                    int randomRare = random.Next(1, 3);
                    if (randomRare == 1)
                    {
                        // MessageBox.Show("SpinDegrees1");
                        StartRotation(SpinDegreesStart1, SpinDegreesStart1 + ColorSegmentDegrees);
                    }
                    else
                    {
                        // MessageBox.Show("SpinDegrees9");
                        StartRotation(SpinDegreesStart9, SpinDegreesStart9 + ColorSegmentDegrees);
                    }
                    break;
                case 2:
                    int randomEpic = random.Next(1, 3);
                    if (randomEpic == 1)
                    {
                        // MessageBox.Show("SpinDegrees2");
                        StartRotation(SpinDegreesStart2, SpinDegreesStart2 + ColorSegmentDegrees);
                    }
                    else
                    {
                        // MessageBox.Show("SpinDegrees7");
                        StartRotation(SpinDegreesStart7, SpinDegreesStart7 + ColorSegmentDegrees);
                    }
                    break;
                case 3:
                    int randomLegend = random.Next(1, 3);
                    if (randomLegend == 1)
                    {
                        // MessageBox.Show("SpinDegrees4");
                        StartRotation(SpinDegreesStart4, SpinDegreesStart4 + ColorSegmentDegrees);
                    }
                    else
                    {
                        // MessageBox.Show("SpinDegrees8");
                        StartRotation(SpinDegreesStart8, SpinDegreesStart8 + ColorSegmentDegrees);
                    }
                    break;
                    //MessageBox.Show("SpinDegrees3 // желтый");
                case 4:
                    int randomCommon = random.Next(1, 5); 
                    if (randomCommon == 1)
                    {
                        // MessageBox.Show("SpinDegrees3");
                        StartRotation(SpinDegreesStart3, SpinDegreesStart3 + ColorSegmentDegrees);
                    }
                    else if (randomCommon == 2)
                    {
                        // MessageBox.Show("SpinDegrees5");
                        StartRotation(SpinDegreesStart5, SpinDegreesStart5 + ColorSegmentDegrees);
                    }
                    else if (randomCommon == 3)
                    {
                        // MessageBox.Show("SpinDegrees6");
                        StartRotation(SpinDegreesStart6, SpinDegreesStart6 + ColorSegmentDegrees);
                    }
                    else
                    {
                        // MessageBox.Show("SpinDegrees10");
                        StartRotation(SpinDegreesStart10, SpinDegreesStart10 + ColorSegmentDegrees);
                    }

                    //MessageBox.Show("SpinDegrees4 // зеленый");
                    break;
                default:
                    int randomCommonDef = random.Next(1, 5);
                    if (randomCommonDef == 1)
                    {
                        // MessageBox.Show("SpinDegrees3");
                        StartRotation(SpinDegreesStart3, SpinDegreesStart3 + ColorSegmentDegrees);
                    }
                    else if (randomCommonDef == 2)
                    {
                        // MessageBox.Show("SpinDegrees5");
                        StartRotation(SpinDegreesStart5, SpinDegreesStart5 + ColorSegmentDegrees);
                    }
                    else if (randomCommonDef == 3)
                    {
                        // MessageBox.Show("SpinDegrees6");
                        StartRotation(SpinDegreesStart6, SpinDegreesStart6 + ColorSegmentDegrees);
                    }
                    else
                    {
                        // MessageBox.Show("SpinDegrees10");
                        StartRotation(SpinDegreesStart10, SpinDegreesStart10 + ColorSegmentDegrees);
                    }
                    break;
            }
        }


        private void StartRotation(float startDegrees, float endDegrees)
        {
            float currentDegrees = currentRotationAngle % FullCircleDegrees; // Получить текущее вращение в градусах

            // Calculate remaining degrees considering positive rotation
            float remainingDegrees = endDegrees - currentDegrees;
            if (remainingDegrees < 0)
            {
                remainingDegrees += FullCircleDegrees;
            }

            rotationTarget = currentRotationAngle + remainingDegrees; // Рассчитать целевое вращение
            rotationTimer.Start();
        }


    }
}
