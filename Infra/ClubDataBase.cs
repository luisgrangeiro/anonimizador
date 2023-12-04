using Core;
using System;
using System.Collections.Generic;

namespace Infra
{
    public static class ClubDataBase
    {
        public static List<ClubRegister> Data { get; set; } = new List<ClubRegister>();

        public static void StartDataBase()
        {
            var register1 = new ClubRegister()
            {
                User = new User()
                {
                    Age = 27,
                    CellPhone = "(21) 99900-9900",
                    Name = "Anakin Skywalker",
                    Email = "askywalker@jedi.com",
                    Gender = "Masculino"
                },
                Sports = new List<Sport>()
                {
                    new Sport()
                    {
                        Name = "Futebol"
                    },
                    new Sport()
                    {
                        Name = "Tiro ao alvo"
                    }
                },
                Active = true,
                StartDate = DateTime.UtcNow
            };

            var register2 = new ClubRegister()
            {
                User = new User()
                {
                    Age = 18,
                    CellPhone = "(21) 99900-9901",
                    Name = "Mikasa Ackerman",
                    Email = "mikasaack@gmail.com",
                    Gender = "Feminino"
                },
                Sports = new List<Sport>()
                {
                    new Sport()
                    {
                        Name = "Salto em altura"
                    },
                },
                Active = true,
                StartDate = DateTime.UtcNow
            };

            var register3 = new ClubRegister()
            {
                User = new User()
                {
                    Age = 14,
                    CellPhone = "(21) 99900-9902",
                    Name = "Raissa Leal",
                    Email = "raissa@gmail.com",
                    Gender = "Feminino"
                },
                Sports = new List<Sport>()
                {
                    new Sport()
                    {
                        Name = "Skate"
                    },
                },
                Active = true,
                StartDate = DateTime.UtcNow
            };

            var register4 = new ClubRegister()
            {
                User = new User()
                {
                    Age = 29,
                    CellPhone = "(21) 99900-9903",
                    Name = "Giorgian De Arrascaeta",
                    Email = "arraxca@hotmail.com",
                    Gender = "Masculino"
                },
                Sports = new List<Sport>()
                {
                    new Sport()
                    {
                        Name = "Futebol"
                    },
                },
                Active = true,
                StartDate = DateTime.UtcNow
            };

            var register5 = new ClubRegister()
            {
                User = new User()
                {
                    Age = 42,
                    CellPhone = "(21) 99900-9904",
                    Name = "Ronaldo de Assis",
                    Email = "bruxo@hotmail.com",
                    Gender = "Masculino"
                },
                Sports = new List<Sport>()
                {
                    new Sport()
                    {
                        Name = "Futebol"
                    },
                },
                Active = false,
                StartDate = DateTime.UtcNow
            };

            var register6 = new ClubRegister()
            {
                User = new User()
                {
                    Age = 24,
                    CellPhone = "(21) 99900-9905",
                    Name = "Rebecca Andrade",
                    Email = "rebeca@hotmail.com",
                    Gender = "Feminino"
                },
                Sports = new List<Sport>()
                {
                    new Sport()
                    {
                        Name = "Ginástica"
                    },
                },
                Active = true,
                StartDate = DateTime.UtcNow
            };

            var register7 = new ClubRegister()
            {
                User = new User()
                {
                    Age = 24,
                    CellPhone = "(21) 99900-9906",
                    Name = "Satoru Gojo",
                    Email = "satoru@jujutsu.com",
                    Gender = "Masculino"
                },
                Sports = new List<Sport>()
                {
                    new Sport()
                    {
                        Name = "Natação"
                    },
                    new Sport()
                    {
                        Name = "Basquete"
                    },
                    new Sport()
                    {
                        Name = "Remo"
                    },
                    new Sport()
                    {
                        Name = "Hóquei"
                    },
                },
                Active = true,
                StartDate = DateTime.UtcNow
            };

            Data.Add(register1);
            Data.Add(register2);
            Data.Add(register3);
            Data.Add(register4);
            Data.Add(register5);
            Data.Add(register6);
            Data.Add(register7);
        }
    }
}
