
namespace ClickerMain
{
    public partial class DefeatClickerForm : Form
    {
        private Player player;
        private Enemy enemy;
        private AttackHandler attackHandler;
        private Weapons weapon;
        private Upgrade upgrade;
        private Money money;
        private MoneyCaretaker moneyCaretaker;
        private int seconds;

        private bool replayClicked = false;

        public DefeatClickerForm(/*int timerInterval, int playerHealth, int damage, int critChance, int level, int enemyHealth, int enemyReward*/)
        {
            InitializeComponent();

            //RunGame(timerInterval, playerHealth, damage, critChance, level, enemyHealth, enemyReward);
        }

        public void RunGame(DefeatClickerForm frm, int timerInterval, int playerHealth, int damage, int critChance, int level, int enemyHealth, int enemyReward)
        {
            Application.Run(frm);

            int TI = timerInterval, HP = playerHealth, PD = damage, CC = critChance, PL = level, EL = enemyHealth, ER = enemyReward;

            while (true)
            {
                player = new(HP, PD, CC, PL);
                enemy = new(EL, 0, ER);

                timer1.Interval = TI;
                seconds = 0;

                replayClicked = false;

                while (seconds < timer1.Interval && enemy.Health > 0)
                {

                }

                if (seconds >= timer1.Interval)
                {
                    replayContinueButton.Text = "You ran out of time! Hit this button to try once again";
                    replayContinueButton.Enabled = true;
                    replayContinueButton.Visible = true;

                    Thread.Sleep(100);

                    while (!replayClicked)
                        replayContinueButton.Text = "Try Again";
                }
                else if (enemyHealth <= 0)
                {
                    replayContinueButton.Text = "You Won This Time";
                    replayContinueButton.Enabled = true;
                    replayContinueButton.Visible = true;

                    TI += TI / 2;
                    PD += 1;
                    CC += 1;
                    PL += 1;

                    EL += EL / 2;
                    ER += ER / 2;

                    Thread.Sleep(100);

                    while (!replayClicked)
                        replayContinueButton.Text = "Next Level";
                }
            }
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            int hpLeft = attackHandler.DamageEnemy(player, enemy);
            healthBar.Value = hpLeft;

        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            // Restore the previous amount of money
            moneyCaretaker.Restore(money);

            // Update the label
            moneyBox.Text = " " + money.GetAmount();
        }

        private void upgradeAttackButton_Click(object sender, EventArgs e)
        {
            // Deduct the cost of the upgrade from the money
            int cost = 10;
            if (money.GetAmount() >= cost)
            {
                money.AddMoney(-cost);
                Upgrade.UpgradePlayerAndWeapon(player, weapon);

                // Update the label
                moneyBox.Text = " " + money.GetAmount();
               // attackBox.Text = "Attack: " + weapon.Attack;
            }
        }

        private void upgradePowerAttackButton_Click(object sender, EventArgs e)
        {
            // Deduct the cost of the upgrade from the money
            int cost = 20;
            if (money.GetAmount() >= cost)
            {
                money.AddMoney(-cost);
                Upgrade.UpgradePlayerAndWeapon(player, weapon);

                // Update the label
                moneyBox.Text = " " + money.GetAmount();
            }
        }

        private void getTimeButton_Click(object sender, EventArgs e)
        {
            timer1.Interval += 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            timerLabel.Text = (timer1.Interval - seconds).ToString();
        }

        private void replayContinueButton_Click(object sender, EventArgs e)
        {
            replayClicked = true;
        }
    }
}