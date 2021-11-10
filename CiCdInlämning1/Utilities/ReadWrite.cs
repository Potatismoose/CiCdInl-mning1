using CiCdInlämning1.Interfaces;
using CiCdInlämning1.Models.Users;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace CiCdInlämning1.Utilities
{
    public static class ReadWrite
    {
        readonly static string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        static List<ISaveable> listOfUsers = new();
        public static void Serialize(ISaveable user)
        {
            string fullFilePath = filePath + "\\" + user.Id + ".user";
            FileStream fileStream;
            BinaryFormatter bf = new();
            if (File.Exists(fullFilePath)) File.Delete(fullFilePath);
            fileStream = File.Create(fullFilePath);
            bf.Serialize(fileStream, user);
            fileStream.Close();
        }

        public static void Deserialize()
        {
            foreach (var file in Directory.GetFiles(filePath))
            {
                if (Path.GetExtension(file) == ".user")
                {
                    FileStream fileStream;
                    BinaryFormatter bf = new();
                    fileStream = File.OpenRead(file);
                    listOfUsers.Add((ISaveable)bf.Deserialize(fileStream));
                    fileStream.Close();
                }
            }
        }

        public static List<ISaveable> GetListOfUsers()
        {
            return listOfUsers;
        }
    }
}
