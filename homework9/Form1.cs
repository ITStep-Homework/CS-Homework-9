using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework9
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStartGuess_Click(object sender, EventArgs e)
        {
            StartNumberGuessingGame();
        }

        private void StartNumberGuessingGame()
        {
            MessageBox.Show("Загадайте число от 1 до 2000, а я попробую его угадать!",
                           "Начало игры", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int min = 1;
            int max = 2000;
            int attempts = 0;
            bool gameActive = true;

            while (gameActive && min <= max)
            {
                attempts++;
                int guess = (min + max) / 2;

                DialogResult result = MessageBox.Show(
                    $"Попытка #{attempts}\n\nВаше число равно {guess}?",
                    "Угадываю число",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show(
                            $"Отлично! Я угадал ваше число {guess} за {attempts} попыток!",
                            "Победа!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                        if (MessageBox.Show("Хотите сыграть еще раз?", "Новая игра",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            StartNumberGuessingGame();
                        }
                        gameActive = false;
                        break;

                    case DialogResult.No:
                        DialogResult compareResult = MessageBox.Show(
                            $"Ваше число больше {guess}?",
                            "Уточнение",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (compareResult == DialogResult.Yes)
                        {
                            min = guess + 1;
                        }
                        else
                        {
                            max = guess - 1;
                        }
                        break;

                    case DialogResult.Cancel:
                        MessageBox.Show("Игра прервана.", "Отмена",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gameActive = false;
                        break;
                }

                if (min > max && gameActive)
                {
                    MessageBox.Show("Кажется, вы где-то ошиблись в ответах. Давайте начнем заново!",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (MessageBox.Show("Хотите начать новую игру?", "Новая игра",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        StartNumberGuessingGame();
                    }
                    gameActive = false;
                }
            }
        }

        private void tabPageRunning_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = e.Location;
            Point labelPos = labelRunningStatic.Location;
            Size labelSize = labelRunningStatic.Size;

            Point labelCenter = new Point(
                labelPos.X + labelSize.Width / 2,
                labelPos.Y + labelSize.Height / 2);

            double distance = Math.Sqrt(
                Math.Pow(mousePos.X - labelCenter.X, 2) +
                Math.Pow(mousePos.Y - labelCenter.Y, 2));

            if (distance < 80)
            {
                MoveRunningStatic(mousePos);
            }
        }

        private void MoveRunningStatic(Point mousePosition)
        {
            int maxX = tabPageRunning.Width - labelRunningStatic.Width - 10;
            int maxY = tabPageRunning.Height - labelRunningStatic.Height - 10;
            int minX = 10;
            int minY = 10;

            int newX, newY;

            int currentCenterX = labelRunningStatic.Location.X + labelRunningStatic.Width / 2;
            int currentCenterY = labelRunningStatic.Location.Y + labelRunningStatic.Height / 2;

            int deltaX = currentCenterX - mousePosition.X;
            int deltaY = currentCenterY - mousePosition.Y;

            double length = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            if (length > 0)
            {
                deltaX = (int)((deltaX / length) * 100); // Перемещение на 100 пикселей
                deltaY = (int)((deltaY / length) * 100);
            }
            else
            {
                deltaX = random.Next(-100, 100);
                deltaY = random.Next(-100, 100);
            }

            newX = currentCenterX + deltaX - labelRunningStatic.Width / 2;
            newY = currentCenterY + deltaY - labelRunningStatic.Height / 2;

            newX = Math.Max(minX, Math.Min(maxX, newX));
            newY = Math.Max(minY, Math.Min(maxY, newY));

            if (newX <= minX || newX >= maxX || newY <= minY || newY >= maxY)
            {
                newX = random.Next(minX, maxX);
                newY = random.Next(minY, maxY);
            }

            labelRunningStatic.Location = new Point(newX, newY);
        }
    }
}