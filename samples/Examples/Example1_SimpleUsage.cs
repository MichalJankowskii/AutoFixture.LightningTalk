namespace LightningTalk.AutoFixture.Examples
{
    using System;
    using Core;
    using Ploeh.AutoFixture;

    public static class Example1_SimpleUsage
    {
        public static void Run()
        {
            var fixture = new Fixture();
            var test1 = fixture.Create<string>();

            // Result: 473293a8-9d66-4553-8923-22399b3aa88d
            var test2 = fixture.Create("Name");

            // Result: Nameca6facf4-5c84-4270-9023-c6e3bd5842cc
            var test3 = fixture.Create<int>();

            // Result: 251
            var test4 = fixture.Create<string[]>();

            // Result: df33ba00-dd95-4b3d-9d26-d442b23d1149
            // 9f24a880 - dfc2 - 4aeb - abeb - 853f19a938d9
            // 94050f0d - 87e0 - 42f3 - 8d8d - 2779c2c6cd9a
            var test5 = fixture.CreateMany<string>();

            // Result: c05df390-4c55-4248-829b-00ca185608b0
            // 0ba9f7c8 - 948b - 4956 - 91c0 - ebb53237da2f
            // eb44adba - 059f - 4d26 - a7a0 - a243c2a83aa1

            fixture.Register(() => "GeneratedValue");
            var test6 = fixture.Create<string>();
            //Result: GeneratedValue

            var user1 = fixture.Create<SimpleUser>();

            fixture.Register<ISimpleUser>(() => new SimpleUser {Name = "Jan", Surname = "Kowalski"});
            var user2 = fixture.Create<ISimpleUser>();

            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine(test3);
            Console.WriteLine();
            foreach (var s in test4)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            foreach (var s in test5)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine(test6);

            Console.WriteLine();
            Console.WriteLine(user1.Name);
            Console.WriteLine(user1.Surname);

            Console.WriteLine();
            Console.WriteLine(user2.Name);
            Console.WriteLine(user2.Surname);
        }
    }
}