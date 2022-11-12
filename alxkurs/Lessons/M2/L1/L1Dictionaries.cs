using alxkurs.Lessons.M2.L1.ClassesAndEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M2.L1
{
    public class L1Dictionaries
    {
        public static void Run()
        {
            var fruitDictionary =new Dictionary<int, string>()
            {
                {1,"Banan" },
                {2,"Apple" },
                {3,"PineApple" },
                {4,"Lemon" },
                {5,"Tomato" },
                {6,"Melon" },
                {7,"Blueberry" },
                {8,"Kiwi" },
                {9,"Peach" },
                {10,"Pineapple" },
                {11,"Watermelon" },

            };

            Console.WriteLine(fruitDictionary[1]);
        }
        public static void Run1()
        {
            UserDTO userDTO = new UserDTO
            {
                Name="ab@ab.com",
                Role="Administrator"
            };
            UserDTO userDTO2 = new UserDTO
            {
                Name = "ab2@ab2.com",
                Role = "data contractor"
            };
            UserDTO userDTO3 = new UserDTO
            {
                Name = "ab3@ab3.com",
                Role = "data_contractor"
            };
            var user = MapDTO(userDTO);
            Console.WriteLine($"User: \n\tuser:{user.Name}\n\trole: {user.Role}");
            var user2 = MapDTO(userDTO2);
            Console.WriteLine($"User: \n\tuser:{user2.Name}\n\trole: {user2.Role}");
            var user3 = MapDTO(userDTO3);
            Console.WriteLine($"User: \n\tuser:{user3.Name}\n\trole: {user3.Role}");
        }
        private static User MapDTO(UserDTO userDTO)
        {
            var user = new User();
            user.Name = userDTO.Name;
            Dictionary<string, UserRoles> mapDictionary = new Dictionary<string, UserRoles>()
            {
                {"administrator",UserRoles.ADMINISTRATOR },
                {"user",UserRoles.USER },
                {"supervisor",UserRoles.SUPERVISOR },
                {"datacontractor",UserRoles.DATA_CONTRACTOR },
            };
            var roleFromDTO = userDTO.Role
                .ToLower()
                .Replace(" ", "")
                .Replace("_","");
            user.Role = mapDictionary[roleFromDTO];
            return user;
        }
    }
}
