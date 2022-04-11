using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



//Zaimplementować w.NET(język C#) aplikację działającą w trybie graficznym, która demonstruje zasadę działania wielowątkowości.
//Aplikacja ma mieć możliwość utworzenia co najmniej 3 wątków, które będą wykonywać jakieś sensowne obliczenia matematyczne lub inne akcje różne od wypisywania tekstu.
//Obliczenia mają trwać na tyle długo, aby można było zaobserwować wielowątkowość.

//Należy przesłać:

//1. Archiwum zip z kompletnym rozwiązaniem zadania.
//2. Plik doc lub docx z informacją co to jest wielowątkowość i do czego ją się wykorzystuje oraz należy sporządzić instrukcję jak to zadanie wykonać
//(jak wygląda główna forma, jakie kontrolki zostały umieszczone na formie, jakie właściwości określono dla kontrolek, jakie zdarzenia i w jaki sposób zostały oprogramowane).

//Uwagi:

//Pami ętaj o podaniu bibliografii.


namespace game_auto_studia
{
    public partial class Form1 : Form
    {
        const int MAX_VEHICLE = 14;
        const int MAX_SPEED_WORD = 20000;
        const int MAX_DISTANCE_CREATE_OTHERCARONE = 5000;
        const int MIN_DISTANCE_CREATE_OTHERCARONE = 400;
        const int MAX_DISTANCE_CREATE_OTHERCARTWO = 2500;
        const int MIN_DISTANCE_CREATE_OTHERCARTWO = 400;
        const int MAX_DISTANCE_CREATE_COIN = 100;
        const int MIN_DISTANCE_CREATE_COIN = 50;
        const int MAX_DISTANCE_CREATE_FUEL = 45000;
        const int MIN_DISTANCE_CREATE_FUEL = 30000;
        const int MAX_PLAYER_SPEED = 15;
        const int MAX_PLAYER_FUEL = 100;
        const int MAX_DISTANCE_CREATE_COULD = 350;
        const int MIN_DISTANCE_CREATE_COULD = 150;
        const int MAX_GETS_FUEL = 25;
        const int MIN_GETS_FUEL = 10;
        const int MAX_DISTANCE_CREATE_TWO_PLANE_OBJECT = 5000;
        const int MIN_DISTANCE_CREATE_TWO_PLANE_OBJECT = 200;
        const int MAX_FUEL = 100;

      
        int playerSpeed = 15;
        int playerTopSpeed = 8;
        int playerScore = 0;
        int playerFuel = 100;
        int distance = 0;
        int horizontalObiectSpeed = 2;
        int timeTick = 0;
        int otherCar1Speed = 6;
        int otherCar2Speed = 4;
        string FILE_PATH = Path.GetFullPath(Path.Combine(Application.ExecutablePath, "..\\", "..\\", "..\\"));
        bool goRight, goLeft, goUp, goDown, isGameOver, playerGo = false;

        List<int> animatedObiectCunt = new List<int>();
        List<bool> animatedObiectBool = new List<bool>();
        List<int> animatedObiectDelay = new List<int>();
        Random rd = new Random();

     



        private void CreateNewCould(PictureBox could)
        {
            could.Top = rd.Next(3, 90);
            could.Size = new Size(rd.Next(123, 286), rd.Next(30, 48));
            could.Left += this.ClientSize.Width + rd.Next(MIN_DISTANCE_CREATE_COULD, MAX_DISTANCE_CREATE_COULD);
            could.Image = Image.FromFile(FILE_PATH + "\\upload\\object\\cloud\\" + rd.Next(1, 5) + ".png");
        }


        private static async Task CreateNewTwoPlaneObject(PictureBox[] twoPlanObject, string FILE_PATH, Random rd, Form tthis)
        {

            await Task.Run(() =>
            {

                foreach (var item in twoPlanObject)
                {
                    if (item.Left < -6 - item.Width)
                        item.Invoke(new Action(() => item.Visible = false));


                    if (item.Visible == false)
                    {
                        item.Invoke(new Action(() =>
                        {
                            item.Size = new Size(rd.Next(140, 167), rd.Next(228, 245));
                            item.Top = rd.Next(30, 90);
                            item.Left += tthis.ClientSize.Width + rd.Next(MIN_DISTANCE_CREATE_TWO_PLANE_OBJECT, MAX_DISTANCE_CREATE_TWO_PLANE_OBJECT) + item.Width;
                            item.Image = Image.FromFile(FILE_PATH + "\\upload\\object\\tree\\" + rd.Next(1, 6) + ".png");
                            item.Visible = true;
                        }));

                    }
                }
            });
        }

        private static async Task CreateCarAsync(PictureBox otherCar, PictureBox otherCar2, string FILE_PATH, Random rd, Form thiss)
        {
            Bitmap bitmap1 = null;
            await Task.Run(() =>
            {
                if (otherCar.Left < -6 - otherCar.Width)
                    otherCar.Invoke(new Action(() => otherCar.Visible = false));
                if (otherCar2.Left < -6 - otherCar2.Width)
                    otherCar2.Invoke(new Action(() => otherCar2.Visible = false));

                if (otherCar.Visible == false || otherCar2.Visible == false)
                {
                    int rdr = rd.Next(1, MAX_VEHICLE);
                    if (otherCar.Visible == false)
                    {
                        try
                        {
                            bitmap1 = (Bitmap)Bitmap.FromFile(FILE_PATH + "upload\\otherCar\\" + rdr + ".png");
                            otherCar.Invoke(new Action(() =>
                            {
                                otherCar.SizeMode = PictureBoxSizeMode.AutoSize;
                                otherCar.Image = bitmap1;
                            }));
                        }
                        catch (Exception)
                        { }
                        bitmap1.RotateFlip(RotateFlipType.Rotate180FlipY);
                        otherCar.Invoke(new Action(() =>
                        {
                            otherCar.Image = bitmap1;
                            otherCar.Top = rd.Next(9, 90);
                            otherCar.Left = thiss.ClientSize.Width + rd.Next(MIN_DISTANCE_CREATE_OTHERCARONE, MAX_DISTANCE_CREATE_OTHERCARONE);
                            otherCar.Visible = true;
                            otherCar.BringToFront();
                        }));
                    }
                    if (otherCar2.Visible == false)
                    {
                        try
                        {
                            bitmap1 = (Bitmap)Bitmap.FromFile(FILE_PATH + "upload\\otherCar\\" + rdr + ".png");
                            otherCar2.Invoke(new Action(() =>
                            {
                                otherCar2.SizeMode = PictureBoxSizeMode.AutoSize;
                                otherCar2.Image = bitmap1;
                            }));
                        }
                        catch (Exception)
                        { }

                        otherCar2.Invoke(new Action(() =>
                        {
                            otherCar2.Top = rd.Next(145, 225);
                            otherCar2.Left = thiss.ClientSize.Width + rd.Next(MIN_DISTANCE_CREATE_OTHERCARTWO, MAX_DISTANCE_CREATE_OTHERCARTWO);
                            otherCar2.Visible = true;
                            otherCar2.BringToFront();
                        }));
                    }
                }
            });
        }

        private void CreateNewCoin(PictureBox coin)
        {
            coin.Top = rd.Next(-9, 171);
            coin.Left += this.ClientSize.Width + rd.Next(MIN_DISTANCE_CREATE_COIN, MAX_DISTANCE_CREATE_COIN);
            coin.Visible = true;
        }
        private void CreateNewFuel(PictureBox fuel)
        {
            fuel.Top = rd.Next(-9, 171);
            fuel.Left += this.ClientSize.Width + rd.Next(MIN_DISTANCE_CREATE_FUEL, MAX_DISTANCE_CREATE_FUEL) + distance;
            fuel.Visible = true;
        }
        


        private void CreateAnimation(int idAnimacion, int min)
        {
            try
            {
                animatedObiectCunt[idAnimacion] = min;
            }
            catch (Exception)
            {
                animatedObiectCunt.Add(min);
                animatedObiectBool.Add(false);
                animatedObiectDelay.Add(0);
            }
        }







        private void AnimatedPictureBox(int idAnimacion, PictureBox pic, bool reapet, string animatedPath, int min, int max, int animateDelay)
        {

            if (animatedObiectDelay[idAnimacion] == (animateDelay / 1000))
            {
                animatedObiectDelay[idAnimacion] = 0;
                if (reapet == false)
                {
                    if (animatedObiectCunt[idAnimacion] == min)
                        animatedObiectBool[idAnimacion] = false;

                    if (animatedObiectCunt[idAnimacion] == max)
                        animatedObiectBool[idAnimacion] = true;

                    if (animatedObiectBool[idAnimacion] == true)
                        animatedObiectCunt[idAnimacion]--;

                    else if (animatedObiectBool[idAnimacion] == false)
                        animatedObiectCunt[idAnimacion]++;
                }
                else
                    if (animatedObiectCunt[idAnimacion] == max)
                    animatedObiectCunt[idAnimacion] = min;
                else
                    animatedObiectCunt[idAnimacion]++;


                pic.Image = Image.FromFile(FILE_PATH + animatedPath + "\\" + animatedObiectCunt[idAnimacion] + ".png");
            }
            else
                animatedObiectDelay[idAnimacion]++;

        }
        private void GameOver()
        {
            gameTimer.Stop();
            isGameOver = true;
            playerGo = false;
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            CreateAnimation(0, 1);
            CreateAnimation(1, 1);
            CreateAnimation(2, 1);






            player.Parent = road;
            player.Location =
                    new Point(
                        player.Location.X
                        - road.Location.X,
                        player.Location.Y
                        - road.Location.Y);

            otherCar.Parent = road;
            otherCar.Location =
                    new Point(
                        otherCar.Location.X
                        - road.Location.X,
                        otherCar.Location.Y
                        - road.Location.Y);

            otherCar2.Parent = road;
            otherCar2.Location =
                    new Point(
                        otherCar2.Location.X
                        - road.Location.X,
                        otherCar2.Location.Y
                        - road.Location.Y);

            coin.Parent = road;
            coin.Location =
                    new Point(
                        coin.Location.X
                        - road.Location.X,
                        coin.Location.Y
                        - road.Location.Y);

            fuel.Parent = road;
            fuel.Location =
                    new Point(
                        fuel.Location.X
                        - road.Location.X,
                        fuel.Location.Y
                        - road.Location.Y);



            could1.Parent = background;
            could1.Location =
                    new Point(
                        could1.Location.X
                        - background.Location.X,
                        could1.Location.Y
                        - background.Location.Y);
            could2.Parent = background;
            could2.Location =
                    new Point(
                        could2.Location.X
                        - background.Location.X,
                        could2.Location.Y
                        - background.Location.Y);
            could3.Parent = background;
            could3.Location =
                    new Point(
                        could3.Location.X
                        - background.Location.X,
                        could3.Location.Y
                        - background.Location.Y);
            could4.Parent = background;
            could4.Location =
                    new Point(
                        could4.Location.X
                        - background.Location.X,
                        could4.Location.Y
                        - background.Location.Y);


            twoPlane.Parent = background;
            twoPlane.Location =
                    new Point(
                        twoPlane.Location.X
                        - background.Location.X,
                        twoPlane.Location.Y
                        - background.Location.Y);

            tree1.Parent = twoPlane;
            tree1.Location =
                    new Point(
                        tree1.Location.X
                        - twoPlane.Location.X,
                        tree1.Location.Y
                        - twoPlane.Location.Y);
            tree2.Parent = twoPlane;
            tree2.Location =
                    new Point(
                        tree2.Location.X
                        - twoPlane.Location.X,
                        tree2.Location.Y
                        - twoPlane.Location.Y);
            tree3.Parent = twoPlane;
            tree3.Location =
                    new Point(
                        tree3.Location.X
                        - twoPlane.Location.X,
                        tree3.Location.Y
                        - twoPlane.Location.Y);
            tree4.Parent = twoPlane;
            tree4.Location =
                    new Point(
                        tree4.Location.X
                        - twoPlane.Location.X,
                        tree4.Location.Y
                        - twoPlane.Location.Y);
            tree5.Parent = twoPlane;
            tree5.Location =
                    new Point(
                        tree5.Location.X
                        - twoPlane.Location.X,
                        tree5.Location.Y
                        - twoPlane.Location.Y);




        }
        private void GameReset()
        {
            goLeft = goRight = goUp = goDown = isGameOver = playerGo = false;
            horizontalObiectSpeed = 1;
            timeTick = 0;

            playerScore = 0;
            otherCar1Speed = 5;
            otherCar2Speed = 2;
            player.Left = 12;
            player.Top = 55;
            distance = 0;
            playerFuel = 100;

            otherCar.Top = 5;
            otherCar.Visible = false;
            otherCar2.Visible = false;
            fuel.Visible = false;
            background.BackColor = SystemColors.ActiveCaption;
            twoPlane.Image = Image.FromFile(FILE_PATH + "\\upload\\object\\forest.png");

            animatedObiectBool.Clear();
            animatedObiectCunt.Clear();
            animatedObiectDelay.Clear();
            CreateAnimation(0, 1);
            CreateAnimation(1, 1);
            CreateAnimation(2, 1);
            CreateNewCoin(coin);
            CreateNewFuel(fuel);




            gameTimer.Start();
        }
        private async void OnGameUpdate(object sender, EventArgs e)
        {
             
            if (timeTick == MAX_SPEED_WORD / 20)
            {
                horizontalObiectSpeed++;
                int checkFuel = rd.Next(MIN_GETS_FUEL, MAX_GETS_FUEL);
                if (checkFuel > playerFuel)
                {
                    playerFuel = 0;
                }
                else
                    playerFuel -= checkFuel;
                timeTick = 0;
            }
            else
                timeTick++;

            if (distance >= 11000)
            {

                background.BackColor = SystemColors.ActiveBorder;
                twoPlane.Image = Image.FromFile(FILE_PATH + "\\upload\\object\\city.png");

            }

            if (distance == 21000)
            {
                background.BackColor = SystemColors.Highlight;
                twoPlane.Image = Image.FromFile(FILE_PATH + "\\upload\\object\\desert.png");
            }



            AnimatedPictureBox(0, coin, false, "\\upload\\animated\\coin", 1, 7, 2000);
            if (playerGo == true)
                AnimatedPictureBox(1, road, true, "\\upload\\animated\\road", 1, 4, 6000 - horizontalObiectSpeed * 70 < 20 ? 100 : 6000 - horizontalObiectSpeed * 100);
            AnimatedPictureBox(2, fuel, false, "\\upload\\animated\\fuel", 1, 3, 2000);



            coin_lb.Text = "" + playerScore;
            distance_lb.Text = "" + distance;
            fuel_lb.Text = playerFuel + "/" + MAX_FUEL + "   " + tree1.Left + "  " + tree1.Top;


            if (goRight == false && goLeft == false && playerGo == true)
                distance++;
            if (goRight == true)
            {
                if (player.Left < 753)
                    player.Left += MAX_PLAYER_SPEED;
                else
                {
                    if (horizontalObiectSpeed <= 6)
                        horizontalObiectSpeed++;
                    playerGo = true;
                }
                distance++;


            }

            if (goLeft == true)
                if (player.Left >= 0)
                    if (horizontalObiectSpeed <= 4)
                        player.Left -= playerSpeed;
                    else
                        player.Left += otherCar2Speed - horizontalObiectSpeed;


            if (goUp == true && MAX_PLAYER_SPEED != 0)
                if (player.Top >= 15)
                    player.Top -= playerTopSpeed;

            if (goDown == true && MAX_PLAYER_SPEED != 0)
                if (player.Top <= 231)
                    player.Top += playerTopSpeed;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {

                    if ((string)x.Tag == "road")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                            player.Top = x.Top - player.Height;

                        x.BringToFront();

                        if (playerGo == true)
                        {
                            coin.Left -= horizontalObiectSpeed;
                            fuel.Left -= horizontalObiectSpeed;
                        }


                        if (player.Bounds.IntersectsWith(coin.Bounds))
                        {
                            coin.Visible = false;
                            playerScore += 5;
                            CreateNewCoin(coin);
                        }
                        if (coin.Left < -6 - coin.Width)
                            CreateNewCoin(coin);



                        fuel.BringToFront();
                        if (player.Bounds.IntersectsWith(fuel.Bounds))
                        {

                            if (fuel.Visible == true)
                            {
                                if (playerFuel + 50 < MAX_PLAYER_FUEL)
                                    playerFuel += 50;
                                else
                                    playerFuel = MAX_PLAYER_FUEL;

                                fuel.Visible = false;
                            }
                            CreateNewFuel(fuel);
                        }
                        if (fuel.Left < -6 - fuel.Width)
                        {
                            fuel.Visible = false;
                            CreateNewFuel(fuel);

                        }

                        await CreateCarAsync(otherCar, otherCar2, FILE_PATH, rd, this);

                        otherCar.Left -= otherCar1Speed + horizontalObiectSpeed;
                        otherCar2.Left += otherCar2Speed - horizontalObiectSpeed;

                        if (player.Bounds.IntersectsWith(otherCar2.Bounds) || player.Bounds.IntersectsWith(otherCar.Bounds) || playerFuel <= 0)
                            if ((player.Top >= otherCar2.Top - 30 && player.Top <= otherCar2.Top + 30) || (player.Top >= otherCar.Top - 30 && player.Top <= otherCar.Top + 30) || (playerFuel <= 0))
                                GameOver();



                    }
                    if ((string)x.Tag == "twoPlane")
                    {
                        PictureBox[] table = { tree1, tree2, tree3, tree4, tree5 };
                        if (playerGo == true)
                        {
                            table[0].Left -= horizontalObiectSpeed + 2;
                            table[1].Left -= horizontalObiectSpeed + 2;
                            table[2].Left -= horizontalObiectSpeed + 2;
                            table[3].Left -= horizontalObiectSpeed + 2;
                            table[4].Left -= horizontalObiectSpeed + 2;

                            table[0].BringToFront();
                            table[1].BringToFront();
                            table[2].BringToFront();
                            table[3].BringToFront();
                            table[4].BringToFront();

                        }



                        await CreateNewTwoPlaneObject(table, FILE_PATH, rd, this);


                    }
                    if ((string)x.Tag == "background")
                    {

                        could1.Left -= horizontalObiectSpeed;
                        could2.Left -= horizontalObiectSpeed;
                        could3.Left -= horizontalObiectSpeed;
                        could4.Left -= horizontalObiectSpeed;

                        if (could1.Left < -6 - could1.Width)
                            CreateNewCould(could1);
                        could1.BringToFront();

                        if (could2.Left < -6 - could2.Width)
                            CreateNewCould(could2);
                        could2.BringToFront();

                        if (could3.Left < -6 - could3.Width)
                            CreateNewCould(could3);
                        could3.BringToFront();

                        if (could4.Left < -6 - could4.Width)
                            CreateNewCould(could4);
                        could4.BringToFront();

                    }



                }
            }
        }

        private void PlayerKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                goUp = false;
            if (e.KeyCode == Keys.Down)
                goDown = false;

            if (e.KeyCode == Keys.Right)
                goRight = false;
            if (e.KeyCode == Keys.Left)
                goLeft = false;

            if (e.KeyCode == Keys.Enter && isGameOver == true)
                GameReset();

        }

        private void PlayerKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goDown = false;
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goUp = false;
                goDown = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goLeft = false;
                goRight = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goRight = false;
                goLeft = true;
            }
        }
    }
}
