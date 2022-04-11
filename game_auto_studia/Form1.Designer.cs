
namespace game_auto_studia
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.road = new System.Windows.Forms.PictureBox();
            this.tree2 = new System.Windows.Forms.PictureBox();
            this.could4 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.coin = new System.Windows.Forms.PictureBox();
            this.tree1 = new System.Windows.Forms.PictureBox();
            this.coin_lb = new System.Windows.Forms.Label();
            this.otherCar = new System.Windows.Forms.PictureBox();
            this.otherCar2 = new System.Windows.Forms.PictureBox();
            this.could1 = new System.Windows.Forms.PictureBox();
            this.could3 = new System.Windows.Forms.PictureBox();
            this.could2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.fuel_lb = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.distance_lb = new System.Windows.Forms.Label();
            this.fuel = new System.Windows.Forms.PictureBox();
            this.tree3 = new System.Windows.Forms.PictureBox();
            this.tree4 = new System.Windows.Forms.PictureBox();
            this.tree5 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.twoPlane = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.could4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.could1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.could3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.could2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // road
            // 
            this.road.BackColor = System.Drawing.Color.Transparent;
            this.road.Image = ((System.Drawing.Image)(resources.GetObject("road.Image")));
            this.road.Location = new System.Drawing.Point(-6, 364);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(1560, 307);
            this.road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road.TabIndex = 1;
            this.road.TabStop = false;
            this.road.Tag = "road";
            // 
            // tree2
            // 
            this.tree2.BackColor = System.Drawing.Color.Transparent;
            this.tree2.Image = ((System.Drawing.Image)(resources.GetObject("tree2.Image")));
            this.tree2.Location = new System.Drawing.Point(1070, 194);
            this.tree2.Name = "tree2";
            this.tree2.Size = new System.Drawing.Size(93, 176);
            this.tree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree2.TabIndex = 53;
            this.tree2.TabStop = false;
            this.tree2.Tag = "tree";
            this.tree2.Visible = false;
            // 
            // could4
            // 
            this.could4.BackColor = System.Drawing.Color.Transparent;
            this.could4.Image = ((System.Drawing.Image)(resources.GetObject("could4.Image")));
            this.could4.Location = new System.Drawing.Point(1315, 3);
            this.could4.Name = "could4";
            this.could4.Size = new System.Drawing.Size(123, 48);
            this.could4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.could4.TabIndex = 60;
            this.could4.TabStop = false;
            this.could4.Tag = "cloud";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(125, 552);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(144, 74);
            this.player.TabIndex = 84;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.OnGameUpdate);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Transparent;
            this.coin.Location = new System.Drawing.Point(-6, 438);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(54, 63);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 87;
            this.coin.TabStop = false;
            this.coin.Tag = "";
            this.coin.Visible = false;
            // 
            // tree1
            // 
            this.tree1.BackColor = System.Drawing.Color.Transparent;
            this.tree1.Image = ((System.Drawing.Image)(resources.GetObject("tree1.Image")));
            this.tree1.Location = new System.Drawing.Point(860, 130);
            this.tree1.Name = "tree1";
            this.tree1.Size = new System.Drawing.Size(136, 228);
            this.tree1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree1.TabIndex = 92;
            this.tree1.TabStop = false;
            this.tree1.Tag = "tree";
            this.tree1.Visible = false;
            // 
            // coin_lb
            // 
            this.coin_lb.AutoSize = true;
            this.coin_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coin_lb.Location = new System.Drawing.Point(556, 9);
            this.coin_lb.Name = "coin_lb";
            this.coin_lb.Size = new System.Drawing.Size(79, 29);
            this.coin_lb.TabIndex = 93;
            this.coin_lb.Text = "label1";
            // 
            // otherCar
            // 
            this.otherCar.BackColor = System.Drawing.Color.Transparent;
            this.otherCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.otherCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otherCar.Image = ((System.Drawing.Image)(resources.GetObject("otherCar.Image")));
            this.otherCar.Location = new System.Drawing.Point(-77, 430);
            this.otherCar.Name = "otherCar";
            this.otherCar.Size = new System.Drawing.Size(141, 71);
            this.otherCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.otherCar.TabIndex = 85;
            this.otherCar.TabStop = false;
            this.otherCar.Tag = "otherDriver";
            this.otherCar.Visible = false;
            this.otherCar.WaitOnLoad = true;
            // 
            // otherCar2
            // 
            this.otherCar2.BackColor = System.Drawing.Color.Transparent;
            this.otherCar2.Image = ((System.Drawing.Image)(resources.GetObject("otherCar2.Image")));
            this.otherCar2.InitialImage = null;
            this.otherCar2.Location = new System.Drawing.Point(-96, 507);
            this.otherCar2.Name = "otherCar2";
            this.otherCar2.Size = new System.Drawing.Size(144, 104);
            this.otherCar2.TabIndex = 86;
            this.otherCar2.TabStop = false;
            this.otherCar2.Tag = "otherDriver2";
            this.otherCar2.Visible = false;
            // 
            // could1
            // 
            this.could1.BackColor = System.Drawing.Color.Transparent;
            this.could1.Image = ((System.Drawing.Image)(resources.GetObject("could1.Image")));
            this.could1.Location = new System.Drawing.Point(78, 29);
            this.could1.Name = "could1";
            this.could1.Size = new System.Drawing.Size(286, 42);
            this.could1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.could1.TabIndex = 97;
            this.could1.TabStop = false;
            this.could1.Tag = "cloud";
            // 
            // could3
            // 
            this.could3.BackColor = System.Drawing.Color.Transparent;
            this.could3.Image = ((System.Drawing.Image)(resources.GetObject("could3.Image")));
            this.could3.Location = new System.Drawing.Point(1039, 58);
            this.could3.Name = "could3";
            this.could3.Size = new System.Drawing.Size(147, 48);
            this.could3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.could3.TabIndex = 98;
            this.could3.TabStop = false;
            this.could3.Tag = "cloud";
            // 
            // could2
            // 
            this.could2.BackColor = System.Drawing.Color.Transparent;
            this.could2.Image = ((System.Drawing.Image)(resources.GetObject("could2.Image")));
            this.could2.Location = new System.Drawing.Point(610, 58);
            this.could2.Name = "could2";
            this.could2.Size = new System.Drawing.Size(123, 48);
            this.could2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.could2.TabIndex = 99;
            this.could2.TabStop = false;
            this.could2.Tag = "cloud";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(523, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 101;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(395, 9);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(17, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 103;
            this.pictureBox7.TabStop = false;
            // 
            // fuel_lb
            // 
            this.fuel_lb.AutoSize = true;
            this.fuel_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_lb.Location = new System.Drawing.Point(418, 9);
            this.fuel_lb.Name = "fuel_lb";
            this.fuel_lb.Size = new System.Drawing.Size(79, 29);
            this.fuel_lb.TabIndex = 102;
            this.fuel_lb.Text = "label2";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(656, 9);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(27, 25);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 105;
            this.pictureBox13.TabStop = false;
            // 
            // distance_lb
            // 
            this.distance_lb.AutoSize = true;
            this.distance_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance_lb.Location = new System.Drawing.Point(689, 9);
            this.distance_lb.Name = "distance_lb";
            this.distance_lb.Size = new System.Drawing.Size(79, 29);
            this.distance_lb.TabIndex = 104;
            this.distance_lb.Text = "label1";
            // 
            // fuel
            // 
            this.fuel.BackColor = System.Drawing.Color.Transparent;
            this.fuel.Location = new System.Drawing.Point(-6, 438);
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(54, 63);
            this.fuel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fuel.TabIndex = 106;
            this.fuel.TabStop = false;
            this.fuel.Tag = "";
            this.fuel.Visible = false;
            // 
            // tree3
            // 
            this.tree3.BackColor = System.Drawing.Color.Transparent;
            this.tree3.Image = ((System.Drawing.Image)(resources.GetObject("tree3.Image")));
            this.tree3.Location = new System.Drawing.Point(176, 182);
            this.tree3.Name = "tree3";
            this.tree3.Size = new System.Drawing.Size(93, 176);
            this.tree3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree3.TabIndex = 107;
            this.tree3.TabStop = false;
            this.tree3.Tag = "tree";
            this.tree3.Visible = false;
            // 
            // tree4
            // 
            this.tree4.BackColor = System.Drawing.Color.Transparent;
            this.tree4.Image = ((System.Drawing.Image)(resources.GetObject("tree4.Image")));
            this.tree4.Location = new System.Drawing.Point(623, 162);
            this.tree4.Name = "tree4";
            this.tree4.Size = new System.Drawing.Size(93, 176);
            this.tree4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree4.TabIndex = 108;
            this.tree4.TabStop = false;
            this.tree4.Tag = "tree";
            this.tree4.Visible = false;
            // 
            // tree5
            // 
            this.tree5.BackColor = System.Drawing.Color.Transparent;
            this.tree5.Image = ((System.Drawing.Image)(resources.GetObject("tree5.Image")));
            this.tree5.Location = new System.Drawing.Point(337, 172);
            this.tree5.Name = "tree5";
            this.tree5.Size = new System.Drawing.Size(93, 176);
            this.tree5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree5.TabIndex = 109;
            this.tree5.TabStop = false;
            this.tree5.Tag = "tree";
            this.tree5.Visible = false;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.background.Location = new System.Drawing.Point(-6, 3);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1560, 367);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 110;
            this.background.TabStop = false;
            this.background.Tag = "background";
            // 
            // twoPlane
            // 
            this.twoPlane.BackColor = System.Drawing.Color.Transparent;
            this.twoPlane.Image = ((System.Drawing.Image)(resources.GetObject("twoPlane.Image")));
            this.twoPlane.Location = new System.Drawing.Point(-6, 144);
            this.twoPlane.Name = "twoPlane";
            this.twoPlane.Size = new System.Drawing.Size(1560, 245);
            this.twoPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twoPlane.TabIndex = 0;
            this.twoPlane.TabStop = false;
            this.twoPlane.Tag = "twoPlane";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1537, 675);
            this.Controls.Add(this.tree5);
            this.Controls.Add(this.tree4);
            this.Controls.Add(this.tree3);
            this.Controls.Add(this.fuel);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.distance_lb);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.fuel_lb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.coin_lb);
            this.Controls.Add(this.tree1);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.otherCar2);
            this.Controls.Add(this.otherCar);
            this.Controls.Add(this.player);
            this.Controls.Add(this.tree2);
            this.Controls.Add(this.road);
            this.Controls.Add(this.twoPlane);
            this.Controls.Add(this.could2);
            this.Controls.Add(this.could1);
            this.Controls.Add(this.could4);
            this.Controls.Add(this.could3);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Drive Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlayerKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.could4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.could1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.could3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.could2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox road;
        private System.Windows.Forms.PictureBox tree2;
        private System.Windows.Forms.PictureBox could4;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.PictureBox tree1;
        private System.Windows.Forms.Label coin_lb;
        private System.Windows.Forms.PictureBox otherCar;
        private System.Windows.Forms.PictureBox otherCar2;
        private System.Windows.Forms.PictureBox could1;
        private System.Windows.Forms.PictureBox could3;
        private System.Windows.Forms.PictureBox could2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label fuel_lb;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label distance_lb;
        private System.Windows.Forms.PictureBox fuel;
        private System.Windows.Forms.PictureBox tree3;
        private System.Windows.Forms.PictureBox tree4;
        private System.Windows.Forms.PictureBox tree5;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox twoPlane;
    }
}

