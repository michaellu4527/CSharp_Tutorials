using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClasses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            Character monster = new Character();
            
            hero.Name = "Michael";
            hero.Health = 1000;
            hero.DamageMaximum = 100;
            hero.AttackBonus = true;

            monster.Name = "Rasouli";
            monster.Health = 1000;
            monster.DamageMaximum = 100;
            monster.AttackBonus = true;

            Dice dice = new Dice();

            while (hero.Health > 0 && monster.Health > 0)
            {
                monster.Defend(hero.Attack(dice));
                hero.Defend(monster.Attack(dice));

                displayStats(hero);
                displayStats(monster);

                // Bonus Attacks
                resultLabel.Text += String.Format("<p>{0} lands a bonus attack on {1}</p>", hero.Name, monster.Name);
                monster.Defend(hero.BonusAttack(dice));
                
                resultLabel.Text += String.Format("<p>{0} lands a bonus attack on {1}</p>", monster.Name, hero.Name);
                hero.Defend(monster.BonusAttack(dice));
               
                displayStats(hero);
                displayStats(monster);
            }

            displayResult(hero, monster);
        }

        private void displayResult(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health > 0)
            {
                resultLabel.Text += String.Format("<p>{0} has defeated {1}!</p>", opponent2.Name, opponent1.Name);
            }
            else if (opponent2.Health <= 0 && opponent1.Health > 0)
            {
                resultLabel.Text += String.Format("<p>{0} has defeated {1}!</p>", opponent1.Name, opponent2.Name);
            }
            else if (opponent1.Health <= 0 || opponent2.Health <= 0)
            {
                resultLabel.Text += String.Format("<p>It was a long and arduous battle, but ultimately both {0} and {1} fell...</p>", opponent1.Name, opponent2.Name);
            }
        }

        private void displayStats(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0}<br /> Health: {1}</p>", 
                character.Name, 
                character.Health);
        }
    }

    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            // 
            Random random = new Random();
            dice.Sides = this.DamageMaximum;
        
            return dice.Roll();
        }

        public void Defend (int damage)
        {
            // Calculating damage taken
            this.Health -= damage;          
        }

        public int BonusAttack(Dice dice)
        {
            // 
            Random random = new Random();
            dice.Sides = this.DamageMaximum;

            return dice.Roll();
        }
    }

    public class Dice
    {
        public int Sides { get; set; }

        Random random = new Random();

        public int Roll()
        {
            return random.Next(this.Sides);
        }
    }

}