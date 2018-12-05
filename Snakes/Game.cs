using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Snakes.Components;
using System.IO;

namespace Snakes
{
    public partial class Game : Form
    {
        private List<Circle> snake = new List<Circle>();
        private Circle food = new Circle();
        private bool Paused = false;
        private bool isEscaped = false;
        private SettingsForm SettingsForm;

        public Game(SettingsForm SettingsForm)
        {
            InitializeComponent();

            this.SettingsForm = SettingsForm;
            this.WindowState = FormWindowState.Maximized;
            new Settings();
        }
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);

            if (GreetingPanel.Visible == true && e.KeyCode == Keys.Space)
            {
                GreetingPanel.Visible = false;
                StartGame();
            }
            else if (GreetingPanel.Visible == false && e.KeyCode == Keys.Space)
            {
                if (!Paused)
                {
                    GameTimer.Stop();
                    Paused = true;
                }
                else
                {
                    GameTimer.Start();
                    Paused = false;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                isEscaped = true;
                this.Close();
                SettingsForm.Show();
            }
        }
        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
        private void StartGame()
        {
            new Settings();
            GameTimer.Interval = 1000 / Settings.Speed;
            GameTimer.Start();
            snake.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            snake.Add(head);
            GenerateFood();
        }
        private void GenerateFood()
        {
            int maxXPos = this.Size.Width / Settings.Width;
            int maxYPos = this.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle { X = random.Next(0, maxXPos - 5), Y = random.Next(0, maxYPos - 5) };
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (Settings.GameOver)
            {
                GreetingPanel.Visible = true;
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.Dir != Direction.Left)
                {
                    Settings.Dir = Direction.Right;
                }
                else if (Input.KeyPressed(Keys.Left) && Settings.Dir != Direction.Right)
                {
                    Settings.Dir = Direction.Left;
                }
                else if (Input.KeyPressed(Keys.Up) && Settings.Dir != Direction.Down)
                {
                    Settings.Dir = Direction.Up;
                }
                else if (Input.KeyPressed(Keys.Down) && Settings.Dir != Direction.Up)
                {
                    Settings.Dir = Direction.Down;
                }
                MovePlayer();
            }
            this.Invalidate();
        }
        private void MovePlayer()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.Dir)
                    {
                        case Direction.Right:
                            snake[i].X++;
                            break;
                        case Direction.Left:
                            snake[i].X--;
                            break;
                        case Direction.Up:
                            snake[i].Y--;
                            break;
                        case Direction.Down:
                            snake[i].Y++;
                            break;
                    }

                    int maxXPos = this.Size.Width / Settings.Width;
                    int maxYPos = this.Size.Height / Settings.Height;

                    if (snake[i].X < 0 || snake[i].Y < 0
                        || snake[i].X >= maxXPos || snake[i].Y >= maxYPos - 2)
                    {
                        Die();
                    }

                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].X == snake[j].X &&
                           snake[i].Y == snake[j].Y)
                        {
                            Die();
                        }
                    }

                    if (snake[0].X == food.X && snake[0].Y == food.Y)
                    {
                        Eat();
                    }
                }
                else
                {
                    //Move body
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
            }
        }
        private void Die()
        {
            GameTimer.Stop();
            Settings.GameOver = true;
            ScoreLabel.Visible = true;
            HiscoresLabel.Visible = true;
            ScoreLabel.Text = "SCORE: " + Settings.Points;
            GreetingPanel.Visible = true;
            File.AppendAllText(Application.StartupPath + "/History.txt",
                Settings.Username + " scored: " + Settings.Points + " on: " + DateTime.Now + Environment.NewLine);
        }
        private void Eat()
        {
            Circle food = new Circle();
            food.X = snake[snake.Count - 1].X;
            food.Y = snake[snake.Count - 1].Y;
            snake.Add(food);
            Settings.Points += 100;
            GenerateFood();
        }
        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics Snake = e.Graphics;

            if (!Settings.GameOver)
            {
                SolidBrush colorScheme1 = new SolidBrush(Settings.BrushCol);
                SolidBrush colorScheme2 = new SolidBrush(Settings.BrushCol2);
                SolidBrush colorScheme3 = new SolidBrush(Settings.BrushCol3);

                for (int i = 0; i < snake.Count; i++)
                {
                    if (i == 0)
                    {
                        //Draw snake
                        Snake.FillEllipse(colorScheme1,
                            new Rectangle(snake[i].X * Settings.Width,
                                          snake[i].Y * Settings.Height,
                                          Settings.Width, Settings.Height));
                    }
                    else
                    {
                        Snake.FillEllipse(colorScheme2,
                            new Rectangle(snake[i].X * Settings.Width,
                                          snake[i].Y * Settings.Height,
                                          Settings.Width, Settings.Height));
                    }

                    //Draw Food
                    Snake.FillEllipse(colorScheme3,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
            else
            {
                GreetingPanel.Visible = true;
            }
        }
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isEscaped)
                Application.Exit();
        }
    }
}