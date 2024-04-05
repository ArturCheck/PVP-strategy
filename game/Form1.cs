using System.Media;

namespace game
{
    public partial class Form1 : Form
    {
        private Random random = new Random();


        private void Random12()
        {
            int randomNumber = random.Next(1, 3);

            if (randomNumber == 1)
            {
                button5.Enabled = true;
                button10.Enabled = true;
                button13.Enabled = true;
                button18.Enabled = true;
                button4.Enabled = false;
                button12.Enabled = false;
                button11.Enabled = false;
                button19.Enabled = false;
                label15.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
            }
            else
            {
                button5.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button18.Enabled = false;
                button4.Enabled = true;
                button12.Enabled = true;
                button11.Enabled = true;
                button19.Enabled = true;
                label14.Visible = false;
                label16.Visible = false;
                label19.Visible = false;
            }
        }

        private void startgameseting()
        {
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            label13.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label14.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            listBox1.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
        }

        private void changeplayer10()
        {
            if (button5.Enabled == true)
            {
                button5.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button18.Enabled = false;
                button4.Enabled = true;
                button12.Enabled = true;
                button11.Enabled = true;
                button19.Enabled = true;
                label15.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label14.Visible = false;
                label16.Visible = false;
                label19.Visible = false;
                label15.Text = random.Next(1, 6).ToString();
                label17.Text = random.Next(1, 6).ToString();
                label18.Text = random.Next(1, 7).ToString();
            }
            else
            {
                button5.Enabled = true;
                button10.Enabled = true;
                button13.Enabled = true;
                button18.Enabled = true;
                label14.Visible = true;
                label16.Visible = true;
                label19.Visible = true;
                button4.Enabled = false;
                button12.Enabled = false;
                button11.Enabled = false;
                button19.Enabled = false;
                label15.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label14.Text = random.Next(1, 6).ToString();
                label16.Text = random.Next(1, 6).ToString();
                label19.Text = random.Next(1, 7).ToString();
            }
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        private void changeplayer100()
        {
            if (button5.Enabled == true)
            {
                button5.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button18.Enabled = false;
                button4.Enabled = true;
                button12.Enabled = true;
                button11.Enabled = true;
                button19.Enabled = true;
                label15.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label14.Visible = false;
                label16.Visible = false;
                label19.Visible = false;
                label15.Text = random.Next(1, 51).ToString();
                label17.Text = random.Next(1, 51).ToString();
                label18.Text = random.Next(1, 61).ToString();
            }
            else
            {
                button5.Enabled = true;
                button10.Enabled = true;
                button13.Enabled = true;
                button18.Enabled = true;
                label14.Visible = true;
                label16.Visible = true;
                label19.Visible = true;
                button4.Enabled = false;
                button12.Enabled = false;
                button11.Enabled = false;
                button19.Enabled = false;
                label15.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label14.Text = random.Next(1, 51).ToString();
                label16.Text = random.Next(1, 51).ToString();
                label19.Text = random.Next(1, 61).ToString();
            }
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        private void changeplayer1000()
        {
            if (button5.Enabled == true)
            {
                button5.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button18.Enabled = false;
                button4.Enabled = true;
                button12.Enabled = true;
                button11.Enabled = true;
                button19.Enabled = true;
                label15.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label14.Visible = false;
                label16.Visible = false;
                label19.Visible = false;
                label15.Text = random.Next(1, 501).ToString();
                label17.Text = random.Next(1, 501).ToString();
                label18.Text = random.Next(1, 601).ToString();
            }
            else
            {
                button5.Enabled = true;
                button10.Enabled = true;
                button13.Enabled = true;
                button18.Enabled = true;
                label14.Visible = true;
                label16.Visible = true;
                label19.Visible = true;
                button4.Enabled = false;
                button12.Enabled = false;
                button11.Enabled = false;
                button19.Enabled = false;
                label15.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label14.Text = random.Next(1, 501).ToString();
                label16.Text = random.Next(1, 501).ToString();
                label19.Text = random.Next(1, 601).ToString();
            }
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        private void gameover()
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label14.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            listBox1.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button2.Visible = true;
            button14.Visible = true;
            button3.Visible = true;
            button2.Focus();
            listBox1.Items.Clear();
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.winsgame);
                soundPlayer.Play();
            }
        }

        int Difficulty = 0;
        private bool isSoundOn = true;

        public Form1()
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Start game

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button9.Visible = true;
            button15.Visible = false;
            button14.Visible = false;
            button1.Visible = false;
            label13.Visible = false;
            textBox1.Focus();
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_button);
                soundPlayer.Play();
            }
        }

        //Retry game

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Text = "Choose difficulty";
            button2.Visible = false;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            label13.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label24.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button14.Visible = false;
            button6.Focus();
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_button);
                soundPlayer.Play();
            }
        }

        //Comfirm name

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button9.Visible = false;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            label13.Visible = true;
            label13.Text = "Choose difficulty";
            if (textBox1.Text == "")
            {
                label11.Text = "Player 1";
            }
            else
            {
                label11.Text = textBox1.Text;
            }
            if (textBox2.Text == "")
            {
                label12.Text = "Player 2";
            }
            else
            {
                label12.Text = textBox2.Text;
            }
            button6.Focus();
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_button);
                soundPlayer.Play();
            }
        }

        //Fast

        private void button6_Click(object sender, EventArgs e)
        {
            startgameseting();
            Difficulty = 10;
            listBox1.ForeColor = Color.LawnGreen;
            listBox1.Items.Add("Game start");
            label7.Text = "0";
            label9.Text = "0";
            label8.Text = "10";
            label10.Text = "10";
            label14.Text = random.Next(1, 6).ToString();
            label15.Text = random.Next(1, 6).ToString();
            label16.Text = random.Next(1, 6).ToString();
            label17.Text = random.Next(1, 6).ToString();
            label18.Text = random.Next(1, 7).ToString();
            label19.Text = random.Next(1, 7).ToString();
            Random12();
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.startgame1);
                soundPlayer.Play();
            }
        }

        //Long

        private void button7_Click(object sender, EventArgs e)
        {
            startgameseting();
            Difficulty = 1000;
            listBox1.ForeColor = Color.LawnGreen;
            listBox1.Items.Add("Game start");
            label7.Text = "0";
            label9.Text = "0";
            label8.Text = "1000";
            label10.Text = "1000";
            label14.Text = random.Next(1, 501).ToString();
            label15.Text = random.Next(1, 501).ToString();
            label16.Text = random.Next(1, 501).ToString();
            label17.Text = random.Next(1, 501).ToString();
            label18.Text = random.Next(1, 601).ToString();
            label19.Text = random.Next(1, 601).ToString();
            Random12();
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.startgame1);
                soundPlayer.Play();
            }
        }

        //Middle

        private void button8_Click(object sender, EventArgs e)
        {
            startgameseting();
            Difficulty = 100;
            listBox1.ForeColor = Color.LawnGreen;
            listBox1.Items.Add("Game start");
            label7.Text = "0";
            label9.Text = "0";
            label8.Text = "100";
            label10.Text = "100";
            label14.Text = random.Next(1, 51).ToString();
            label15.Text = random.Next(1, 51).ToString();
            label16.Text = random.Next(1, 51).ToString();
            label17.Text = random.Next(1, 51).ToString();
            label18.Text = random.Next(1, 61).ToString();
            label19.Text = random.Next(1, 61).ToString();
            Random12();
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.startgame1);
                soundPlayer.Play();
            }
        }

        //Exit

        private void button14_Click(object sender, EventArgs e)
        {
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.exitgame);
                soundPlayer.Play();
            }
            Thread.Sleep(2000);
            this.Close();
        }

        //Change theme

        private void button15_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
            button15.Visible = false;
            button1.Visible = false;
            label13.Visible = false;
            button16.Visible = true;
            button17.Visible = true;
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_button);
                soundPlayer.Play();
            }
        }

        //Blue

        private void button16_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkTurquoise;
            button1.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            label13.Visible = true;
            button16.Visible = false;
            button17.Visible = false;
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_button);
                soundPlayer.Play();
            }
        }

        //Green

        private void button17_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.GreenYellow;
            button1.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            label13.Visible = true;
            button16.Visible = false;
            button17.Visible = false;
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_button);
                soundPlayer.Play();
            }
        }

        //Player 1 Attack

        private void button5_Click(object sender, EventArgs e)
        {
            int player2Armor = int.Parse(label9.Text);
            int damage = int.Parse(label19.Text);
            int fixarmor = int.Parse(label9.Text);

            int newArmor = player2Armor - damage;
            if (newArmor <= 0)
            {
                newArmor = 0;
            }

            label9.Text = newArmor.ToString();

            string playerName = label11.Text;
            string damages = label19.Text;
            int player2Health = int.Parse(label10.Text);

            if (newArmor == 0)
            {
                int newHealth = player2Health - (damage - player2Armor);

                if (newHealth <= 0)
                {
                    gameover();
                    label24.Text = $"{playerName}\nwins";
                    label24.Visible = true;
                    int playerwin = int.Parse(label22.Text) + 1;
                    label22.Text = $"{playerwin}";
                }
                else
                {
                    string attackMessage = $"{playerName} used attack (- {damages})";
                    listBox1.ForeColor = Color.Crimson;
                    listBox1.Items.Add(attackMessage);
                    label10.Text = newHealth.ToString();
                    if (Difficulty == 10)
                    {
                        changeplayer10();
                    }
                    if (Difficulty == 100)
                    {
                        changeplayer100();
                    }
                    if (Difficulty == 1000)
                    {
                        changeplayer1000();
                    }
                    if (fixarmor == damage)
                    {
                        label28.Visible = true;
                        Refresh();
                        System.Threading.Thread.Sleep(500);
                        label28.Visible = false;
                        if (isSoundOn)
                        {
                            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_on_armor);
                            soundPlayer.Play();
                        }
                    }
                    else
                    {
                        label25.Visible = true;
                        Refresh();
                        System.Threading.Thread.Sleep(500);
                        label25.Visible = false;
                        if (isSoundOn)
                        {
                            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_on_health);
                            soundPlayer.Play();
                        }
                    }
                }
            }
            else
            {
                string attackMessage = $"{playerName} used attack (- {damages})";
                listBox1.ForeColor = Color.Crimson;
                listBox1.Items.Add(attackMessage);
                if (isSoundOn)
                {
                    SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_on_armor);
                    soundPlayer.Play();
                }
                if (Difficulty == 10)
                {
                    changeplayer10();
                }
                if (Difficulty == 100)
                {
                    changeplayer100();
                }
                if (Difficulty == 1000)
                {
                    changeplayer1000();
                }
                label28.Visible = true;
                Refresh();
                System.Threading.Thread.Sleep(500);
                label28.Visible = false;
            }
        }

        //Player 2 Attack

        private void button4_Click(object sender, EventArgs e)
        {
            int player1Armor = int.Parse(label7.Text);
            int damage = int.Parse(label18.Text);
            int fixarmor = int.Parse(label7.Text);

            int newArmor = player1Armor - damage;
            if (newArmor <= 0)
            {
                newArmor = 0;
            }

            label7.Text = newArmor.ToString();

            string playerName = label12.Text;
            string damages = label18.Text;
            int player1Health = int.Parse(label8.Text);

            if (newArmor == 0)
            {
                int newHealth = player1Health - (damage - player1Armor);

                if (newHealth <= 0)
                {
                    gameover();
                    label24.Text = $"{playerName}\nwins";
                    label24.Visible = true;
                    int playerwin = int.Parse(label23.Text) + 1;
                    label23.Text = $"{playerwin}";
                }
                else
                {
                    string attackMessage = $"{playerName} used attack (- {damages})";
                    listBox1.ForeColor = Color.Crimson;
                    listBox1.Items.Add(attackMessage);
                    label8.Text = newHealth.ToString();
                    if (Difficulty == 10)
                    {
                        changeplayer10();
                    }
                    if (Difficulty == 100)
                    {
                        changeplayer100();
                    }
                    if (Difficulty == 1000)
                    {
                        changeplayer1000();
                    }
                    if (fixarmor == damage)
                    {
                        label26.Visible = true;
                        Refresh();
                        System.Threading.Thread.Sleep(500);
                        label26.Visible = false;
                        if (isSoundOn)
                        {
                            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_on_armor);
                            soundPlayer.Play();
                        }
                    }
                    else
                    {
                        label27.Visible = true;
                        Refresh();
                        System.Threading.Thread.Sleep(500);
                        label27.Visible = false;
                        if (isSoundOn)
                        {
                            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_on_health);
                            soundPlayer.Play();
                        }
                    }
                }
            }
            else
            {
                string attackMessage = $"{playerName} used attack (- {damages})";
                listBox1.ForeColor = Color.Crimson;
                listBox1.Items.Add(attackMessage);
                if (isSoundOn)
                {
                    SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_on_armor);
                    soundPlayer.Play();
                }
                if (Difficulty == 10)
                {
                    changeplayer10();
                }
                if (Difficulty == 100)
                {
                    changeplayer100();
                }
                if (Difficulty == 1000)
                {
                    changeplayer1000();
                }
                label26.Visible = true;
                Refresh();
                System.Threading.Thread.Sleep(500);
                label26.Visible = false;
            }
        }

        //Change name

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button2.Visible = false;
            label24.Visible = false;
            label22.Text = "0";
            label23.Text = "0";
            button1_Click(sender, e);
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_button);
                soundPlayer.Play();
            }
        }

        //Player 1 Defense

        private void button10_Click(object sender, EventArgs e)
        {
            int player1Armor = int.Parse(label7.Text) + int.Parse(label16.Text);
            string playerName = label11.Text;
            string armor = label16.Text;
            string DefenseMessage = $"{playerName} used defense (+ {armor})";
            listBox1.ForeColor = Color.DodgerBlue;
            listBox1.Items.Add(DefenseMessage);
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_armor);
                soundPlayer.Play();
            }
            if (Difficulty == 10)
            {
                changeplayer10();
                if (player1Armor > 10)
                {
                    player1Armor = 10;
                }
                label7.Text = player1Armor.ToString();
            }
            if (Difficulty == 100)
            {
                changeplayer100();
                if (player1Armor > 100)
                {
                    player1Armor = 100;
                }
                label7.Text = player1Armor.ToString();
            }
            if (Difficulty == 1000)
            {
                changeplayer1000();
                if (player1Armor > 1000)
                {
                    player1Armor = 1000;
                }
                label7.Text = player1Armor.ToString();
            }
        }

        //Player 2 Defense

        private void button11_Click(object sender, EventArgs e)
        {
            int player2Armor = int.Parse(label9.Text) + int.Parse(label17.Text);
            string playerName = label12.Text;
            string armor = label17.Text;
            string DefenseMessage = $"{playerName} used defense (+ {armor})";
            listBox1.ForeColor = Color.DodgerBlue;
            listBox1.Items.Add(DefenseMessage);
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_armor);
                soundPlayer.Play();
            }
            if (Difficulty == 10)
            {
                changeplayer10();
                if (player2Armor > 10)
                {
                    player2Armor = 10;
                }
                label9.Text = player2Armor.ToString();
            }
            if (Difficulty == 100)
            {
                changeplayer100();
                if (player2Armor > 100)
                {
                    player2Armor = 100;
                }
                label9.Text = player2Armor.ToString();
            }
            if (Difficulty == 1000)
            {
                changeplayer1000();
                if (player2Armor > 1000)
                {
                    player2Armor = 1000;
                }
                label9.Text = player2Armor.ToString();
            }
        }

        //Player 1 Heal

        private void button13_Click(object sender, EventArgs e)
        {
            int player1Health = int.Parse(label8.Text) + int.Parse(label14.Text);
            string playerName = label11.Text;
            string health = label14.Text;
            string DefenseMessage = $"{playerName} used heal (+ {health})";
            listBox1.ForeColor = Color.LawnGreen;
            listBox1.Items.Add(DefenseMessage);
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_health);
                soundPlayer.Play();
            }
            if (Difficulty == 10)
            {
                changeplayer10();
                if (player1Health > 10)
                {
                    player1Health = 10;
                }
                label8.Text = player1Health.ToString();
            }
            if (Difficulty == 100)
            {
                changeplayer100();
                if (player1Health > 100)
                {
                    player1Health = 100;
                }
                label8.Text = player1Health.ToString();
            }
            if (Difficulty == 1000)
            {
                changeplayer1000();
                if (player1Health > 1000)
                {
                    player1Health = 1000;
                }
                label8.Text = player1Health.ToString();
            }
        }

        //Player 2 Heal

        private void button12_Click(object sender, EventArgs e)
        {
            int player2Health = int.Parse(label10.Text) + int.Parse(label15.Text);
            string playerName = label12.Text;
            string health = label15.Text;
            string DefenseMessage = $"{playerName} used heal (+ {health})";
            listBox1.ForeColor = Color.LawnGreen;
            listBox1.Items.Add(DefenseMessage);
            if (isSoundOn)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_health);
                soundPlayer.Play();
            }
            if (Difficulty == 10)
            {
                changeplayer10();
                if (player2Health > 10)
                {
                    player2Health = 10;
                }
                label10.Text = player2Health.ToString();
            }
            if (Difficulty == 100)
            {
                changeplayer100();
                if (player2Health > 100)
                {
                    player2Health = 100;
                }
                label10.Text = player2Health.ToString();
            }
            if (Difficulty == 1000)
            {
                changeplayer1000();
                if (player2Health > 1000)
                {
                    player2Health = 1000;
                }
                label10.Text = player2Health.ToString();
            }
        }

        //Random player 1

        private void button18_Click(object sender, EventArgs e)
        {
            int Random = random.Next(1, 5);
            if (Random == 1)
            {
                button13_Click(sender, e);
            }
            if (Random == 2)
            {
                button10_Click(sender, e);
            }
            if (Random >= 3)
            {
                button5_Click(sender, e);
            }
        }

        //Random player 2

        private void button19_Click(object sender, EventArgs e)
        {
            int Random = random.Next(1, 5);
            if (Random == 1)
            {
                button12_Click(sender, e);
            }
            if (Random == 2)
            {
                button11_Click(sender, e);
            }
            if (Random >= 3)
            {
                button4_Click(sender, e);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBox2.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                textBox1.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                button9.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                textBox1.Focus();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (isSoundOn)
            {
                isSoundOn = false;
                button20.Text = "🔇";
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_button);
                soundPlayer.Play();
            }
            else
            {
                isSoundOn = true;
                button20.Text = "🔈";
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_button);
                soundPlayer.Play();
            }
        }
    }
}