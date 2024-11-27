using System;



namespace OOPpractice2
{
    public class Game
    {
        public static Hero Fight(Hero warrior1, Hero warrior2, int warrior1_qty = 1, int warrior2_qty = 1)
        {
            Hero[] warriors = new Hero[] {warrior1, warrior2};
            int[] warriors_qty = new int[] { warrior1_qty, warrior2_qty };
            Random random = new Random();
            int index = random.Next(0, warriors.Length);
            //Console.WriteLine("index: "+index);
            //Console.WriteLine("length: "+warriors.Length);
            Hero first = warriors[index];
            int first_qty = warriors_qty[index];
            int first_unit_health = first.Health;  // potrzbujmy do zlicznia ilości pozostałych bohaterów danej klasy

            Hero second = warriors[(warriors.Length - 1) - index];
            int second_qty = warriors_qty[(warriors_qty.Length - 1) - index];
            int second_unit_health = second.Health; // potrzbujmy do zlicznia ilości pozostałych bohaterów danej klasy

            Console.WriteLine($"first: {first}, qty: {first_qty}");
            Console.WriteLine($"first: {second}, qty: {second_qty}");

            first.Health = first.Health * first_qty;   // na razie grupuję bohatareów we wspólną ilośc health
            second.Health = second.Health * second_qty; // na razie grupuję bohatareów we wspólną ilośc health


            /// to do: zmniejszanie ilości bohaterów (czyli iteracji ataku w pętli ponizej) wraz ze spadkiem wspólnego health
            ///
            while (true)
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXx");
                for (int i = 1; i <= first_qty; i++)
                {
                    if (Combat(first, first_qty, second, second_qty))
                        return first;
                }
                for (int i = 1; i <= second_qty; i++)
                {
                    if (Combat(second, second_qty, first, first_qty))
                        return second;
                }
            }
        }


        public static bool Combat(Hero warrior_attck, int warrior_att_qty, Hero warrior_def, int warrior_def_qty)
        {
            int attack = 0;
            int block = 0;
            int damage = 0;

                attack = warrior_attck.AttackStrength();
                block = warrior_def.BlockStrength();    
                Console.WriteLine($"attack {attack} block {block}");
                damage = attack - block;
                damage = damage < 0 ? 0 : damage;

                warrior_def.Health = warrior_def.Health - damage;

                Console.WriteLine($"{warrior_attck.Name} did {damage} damage to {warrior_def.Name}");   
                Console.WriteLine($"Bronicy się: {warrior_def}");


                if (warrior_def.Health < 0) 
                    return true;
                else return false;
        }


        private static bool IsWinner(Hero warrior)
        {
            if (warrior.Health < 0)
                return true;
            return false;
        }
    }
}
